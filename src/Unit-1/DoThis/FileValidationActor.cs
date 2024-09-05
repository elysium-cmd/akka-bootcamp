using Akka.Actor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WinTail
{
    public class FileValidationActor : UntypedActor
    {
        private readonly IActorRef _consoleWriterActor;

        public FileValidationActor(IActorRef consoleWriterActor)
        {
            _consoleWriterActor = consoleWriterActor;
        }

        protected override void OnReceive(object message)
        {
            var msg = message as string;
            if (string.IsNullOrEmpty(msg))
            {
                _consoleWriterActor.Tell(new Messages.NullInputError("Input was blank. Please try again.\n"));
                Sender.Tell(new Messages.ContinueProcessing());
            }
            else
            {
                if (IsFileUri(msg))
                {
                    _consoleWriterActor.Tell(new Messages.InputSuccess(string.Format("Starting processing for {0}", msg)));
                    Context.ActorSelection("akka://MyActorSystem/user/tailCoordinatorActor").Tell(new TailCoordinatorActor.StartTail(_consoleWriterActor, msg));
                }
                else
                {
                    _consoleWriterActor.Tell(new Messages.ValidationError(string.Format("{0} is not an existing URI on disk.", msg)));
                    Sender.Tell(new Messages.ContinueProcessing());
                }
            }

            Sender.Tell(new Messages.ContinueProcessing());
        }
        private static bool IsFileUri(string path)
        {
            return File.Exists(path);
        }
    }
}