﻿//-----------------------------------------------------------------------
// <copyright file="ActorPathCache.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2020 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2020 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Text;
using Akka.Actor;
using System.Threading;
using Akka.Util;

namespace Akka.Remote.Serialization
{
    /// <summary>
    /// INTERNAL API
    /// </summary>
    internal sealed class ActorPathThreadLocalCache : ExtensionIdProvider<ActorPathThreadLocalCache>, IExtension
    {
        private readonly ThreadLocal<ActorPathCache> _current = new ThreadLocal<ActorPathCache>(() => new ActorPathCache());
        private readonly  ThreadLocal<ActorPathFastCache> _currentAs = new ThreadLocal<ActorPathFastCache>(()=>new ActorPathFastCache());
        public ActorPathCache Cache => _current.Value;
        public ActorPathFastCache FastCache => _currentAs.Value;
        public override ActorPathThreadLocalCache CreateExtension(ExtendedActorSystem system)
        {
            return new ActorPathThreadLocalCache();
        }

        public static ActorPathThreadLocalCache For(ActorSystem system)
        {
            return system.WithExtension<ActorPathThreadLocalCache, ActorPathThreadLocalCache>();
        }
    }

    public class HeldSegment
    {
        public HeldSegment(ArraySegment<byte> segment)
        {
            Segment = segment;
        }
        public ArraySegment<byte> Segment { get; }
    }
    internal sealed class ActorPathFastCache : LruSegmentCache<ActorPath>
    {
        public ActorPathFastCache(int capacity = 1024, int evictAgeThreshold = 600) : base(capacity, evictAgeThreshold)
        {
            
        }
        

        protected override ActorPath Compute(ReadOnlySpan<byte> k)
        {
            if (ActorPath.TryParse(Encoding.UTF8.GetString(k.ToArray()), out var actorPath))
                return actorPath;
            return null;
        }

        protected override bool IsCacheable(ActorPath v)
        {
            return v != null;
        }
    }
    /// <summary>
    /// INTERNAL API
    /// </summary>
    internal sealed class ActorPathCache : LruBoundedCache<string, ActorPath>
    {
        public ActorPathCache(int capacity = 1024, int evictAgeThreshold = 600) : base(capacity, evictAgeThreshold)
        {
        }

        protected override int Hash(string k)
        {
            return FastHash.OfStringFast(k);
        }

        protected override ActorPath Compute(string k)
        {
            if (ActorPath.TryParse(k, out var actorPath))
                return actorPath;
            return null;
        }

        protected override bool IsCacheable(ActorPath v)
        {
            return v != null;
        }
    }
}
