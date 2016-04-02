﻿using System;
using System.Collections.Concurrent;
using Akka.Actor;
using Akka.Configuration;
using Akka.Event;

namespace Akka.Persistence.Query
{
    public sealed class PersistenceQuery : IExtension
    {
        private readonly ExtendedActorSystem _system;
        private readonly ConcurrentDictionary<string, IReadJournal> _readJournalPluginExtensionIds = new ConcurrentDictionary<string, IReadJournal>();
        private ILoggingAdapter _log;

        public static PersistenceQuery Get(ActorSystem system)
        {
            return system.WithExtension<PersistenceQuery, PersistenceQueryProvider>();
        }

        public ILoggingAdapter Log => _log ?? (_log = _system.Log);

        public PersistenceQuery(ExtendedActorSystem system)
        {
            _system = system;
        }

        public TJournal ReadJournalFor<TJournal>(string readJournalPluginId) where TJournal : IReadJournal
        {
            var plugin = _readJournalPluginExtensionIds.GetOrAdd(readJournalPluginId, path => CreatePlugin(path).GetReadJournal());
            return (TJournal) plugin;
        }

        private IReadJournalProvider CreatePlugin(string configPath)
        {
            if (string.IsNullOrEmpty(configPath) || !_system.Settings.Config.HasPath(configPath))
                throw new ArgumentException("HOCON config is missing persistence read journal plugin config path: " + configPath);

            var pluginConfig = _system.Settings.Config.GetConfig(configPath);
            var pluginTypeName = pluginConfig.GetString("class");
            var pluginType = Type.GetType(pluginTypeName, true);

            return CreateType(pluginType, new object[] { _system, pluginConfig });
        }

        private IReadJournalProvider CreateType(Type pluginType, object[] parameters)
        {
            var ctor = pluginType.GetConstructor(new Type[] {typeof (ExtendedActorSystem), typeof (Config)});
            if (ctor != null) return (IReadJournalProvider)ctor.Invoke(parameters);

            ctor = pluginType.GetConstructor(new Type[] { typeof(ExtendedActorSystem) });
            if (ctor != null) return (IReadJournalProvider)ctor.Invoke(new [] { parameters[0] });

            ctor = pluginType.GetConstructor(new Type[0]);
            if (ctor != null) return (IReadJournalProvider)ctor.Invoke(new object[0]);

            throw new ArgumentException($"Unable to create read journal plugin instance type {pluginType}!");
        }
    }

    public class PersistenceQueryProvider : ExtensionIdProvider<PersistenceQuery>
    {
        public override PersistenceQuery CreateExtension(ExtendedActorSystem system)
        {
            return new PersistenceQuery(system);
        }
    }
}