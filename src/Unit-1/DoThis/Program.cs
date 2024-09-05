﻿using System;
﻿using Akka.Actor;

namespace WinTail
{
    #region Program
    class Program
    {
        public static ActorSystem MyActorSystem;

        static void Main(string[] args) {
            MyActorSystem = ActorSystem.Create("MyActorSystem");

            // time to make your first actors!
            Props consoleWriterProps = Props.Create(() => new ConsoleWriterActor());
            IActorRef consoleWriterActor = MyActorSystem.ActorOf(consoleWriterProps, "consoleWriterActor");
            Props tailCoordinatorProps = Props.Create(() => new TailCoordinatorActor());
            IActorRef tailCoordinatorActor = MyActorSystem.ActorOf(tailCoordinatorProps, "tailCoordinatorActor");
            Props fileValidationActorProps = Props.Create(() => new FileValidationActor(consoleWriterActor, tailCoordinatorActor));
            IActorRef fileValidationActor = MyActorSystem.ActorOf(fileValidationActorProps, "fileValidationActor");
            Props consoleReaderProps = Props.Create(() => new ConsoleReaderActor(fileValidationActor));
            IActorRef consoleReaderActor = MyActorSystem.ActorOf(consoleReaderProps, "consoleReaderActor");

            // tell console reader to begin
            consoleReaderActor.Tell(ConsoleReaderActor.StartCommand);

            // blocks the main thread from exiting until the actor system is shut down
            MyActorSystem.WhenTerminated.Wait();
        }
    }
    #endregion
}
