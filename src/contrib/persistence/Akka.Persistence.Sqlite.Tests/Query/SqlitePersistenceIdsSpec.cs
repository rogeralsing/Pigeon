﻿//-----------------------------------------------------------------------
// <copyright file="SqlitePersistenceIdsSpec.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2020 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2020 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using Akka.Configuration;
using Akka.Persistence.Query;
using Akka.Persistence.Query.Sql;
using Akka.Persistence.TCK.Query;
using Akka.Util.Internal;
using Xunit.Abstractions;

namespace Akka.Persistence.Sqlite.Tests.Query
{
    public class SqlitePersistenceIdsSpec : PersistenceIdsSpec
    {
        public static readonly AtomicCounter Counter = new AtomicCounter(0);

        public static Config Config(int id) => ConfigurationFactory.ParseString($@"
            akka.loglevel = INFO
            akka.persistence.journal.plugin = ""akka.persistence.journal.sqlite""
            akka.persistence.journal.sqlite {{
                class = ""Akka.Persistence.Sqlite.Journal.SqliteJournal, Akka.Persistence.Sqlite""
                plugin-dispatcher = ""akka.actor.default-dispatcher""
                table-name = event_journal
                metadata-table-name = journal_metadata
                auto-initialize = on
                connection-string = ""Filename=file:memdb-journal-persistenceids-{id}.db;Mode=Memory;Cache=Shared""
                refresh-interval = 200ms
            }}
            akka.test.single-expect-default = 10s")
            .WithFallback(SqlReadJournal.DefaultConfiguration());

        public SqlitePersistenceIdsSpec(ITestOutputHelper output) : base(Config(Counter.GetAndIncrement()), nameof(SqlitePersistenceIdsSpec), output)
        {
            ReadJournal = Sys.ReadJournalFor<SqlReadJournal>(SqlReadJournal.Identifier);
        }
    }
}
