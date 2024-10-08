﻿using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinTail
{
    public class TailCoordinatorActor : UntypedActor
    {
        public class StartTail
        {
            public IActorRef ReporterActor { get; private set; }
            public string FilePath { get; private set; }

            public StartTail(IActorRef reporterActor, string filePath)
            {
                ReporterActor = reporterActor;
                FilePath = filePath;
            }
        }

        public class StopTail
        {
            public string FilePath { get; private set; }
            public StopTail(string filePath)
            {
                FilePath = filePath;
            }
        }

        protected override void OnReceive(object message)
        {
            if (message is StartTail)
            {
                var msg = message as StartTail;
                Context.ActorOf(Props.Create(() => new TailActor(msg.ReporterActor, msg.FilePath)));
            }
        }

        protected override SupervisorStrategy SupervisorStrategy()
        {
            return new OneForOneStrategy(10, TimeSpan.FromSeconds(30), x =>
            {
                if (x is ArithmeticException) return Directive.Resume;
                else if (x is NotSupportedException) return Directive.Stop;
                else return Directive.Restart;
            });
        }
    }
}
