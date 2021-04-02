﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Actor.Setup;
using Akka.Serialization;
using Newtonsoft.Json;

namespace DocsExamples.Networking.Serialization
{
    public class ProgrammaticJsonSerializerSetup
    {
        public ProgrammaticJsonSerializerSetup()
        {
            #region CustomJsonSetup
            var jsonSerializerSetup = NewtonSoftJsonSerializerSetup.Create(
                settings =>
                {
                    settings.NullValueHandling = NullValueHandling.Include;
                    settings.PreserveReferencesHandling = PreserveReferencesHandling.None;
                    settings.Formatting = Formatting.None;
                });

            var systemSetup = ActorSystemSetup.Create(jsonSerializerSetup);

            var system = ActorSystem.Create("MySystem", systemSetup);
            #endregion

            system.Terminate().Wait();
        }
    }
}
