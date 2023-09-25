using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(IMediator mediator) : base(mediator) { }

        public override void Send(string message)
        {
            Console.WriteLine($"\nColleague 2 sent a message: {message}");
            mediator.Send(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"Colleague 2 received the message!");
        }
    }
}