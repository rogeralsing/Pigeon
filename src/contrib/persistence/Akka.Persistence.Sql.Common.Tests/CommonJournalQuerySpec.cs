﻿//-----------------------------------------------------------------------
// <copyright file="CommonJournalQuerySpec.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2015 Typesafe Inc. <http://www.typesafe.com>
//     Copyright (C) 2013-2015 Akka.NET project <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using Akka.Configuration;
using Akka.Persistence.Sql.Common.TestKit;
using Akka.Util.Internal;
using Xunit.Abstractions;

namespace Akka.Persistence.Sql.Common.Tests
{
    public class CommonJournalQuerySpec : SqlJournalQuerySpec
    {
        const string ConnectionString = @"Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=true;MultipleActiveResultSets=True";

        private static AtomicCounter counter = new AtomicCounter(0);

        public CommonJournalQuerySpec(ITestOutputHelper output)
            : base(CreateSpecConfig(ConnectionString, string.Format("event_journal_queryspec_{0}", counter.IncrementAndGet())), "CommonJournalQuerySpec", output: output)
        {
            var exten = CommonPersistence.Get(Sys);

            exten.DropJournalTable();

            Initialize();
        }

        private static Config CreateSpecConfig(string connectionString, string tableName)
        {
            return ConfigurationFactory.ParseString(@"
                akka.persistence {
                    publish-plugin-commands = on
                    journal {
                        plugin = ""akka.persistence.journal.common""
                        common {
                            class = ""Akka.Persistence.Sql.Common.Journal.CommonJournal, Akka.Persistence.Sql.Common""
                            plugin-dispatcher = ""akka.actor.default-dispatcher""
                            table-name = """ + tableName + @"""
                            auto-initialize = on
                            connection-string = """ + connectionString + @"""
                        }
                    }
                }" + TimestampConfig("akka.persistence.journal.common"));
        }
    }
}