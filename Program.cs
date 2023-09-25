using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Created objs 
            var mediator = new ConcreteMediator();
            var colleague1 = new ConcreteColleague1(mediator);
            var colleague2 = new ConcreteColleague2(mediator);

            // Colleagues list
            mediator.Register(colleague1);
            mediator.Register(colleague2);

            // Send messages from Colleague1 and Colleague2
            colleague1.Send("Hello, Colleague 2!");
            colleague2.Send("Hi, how are you Colleague 1?");

            colleague1.Send("Not too bad, how about you?");
            colleague2.Send("I'm better than good, Thanks!");
        }
    }
}