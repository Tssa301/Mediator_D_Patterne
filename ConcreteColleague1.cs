using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(IMediator mediator) : base(mediator) { }

        public override void Send(string message)
        {
            Console.WriteLine($"\nColleague 1 sent a message: {message}");
            mediator.Send(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"Colleague 1 received the message!");
        }
    }
}