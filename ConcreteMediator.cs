using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ConcreteMediator : IMediator
    {
        private List<Colleague> _colleagues = new List<Colleague>();

        public void Register(Colleague colleague)
        {
            _colleagues.Add(colleague);
        }

        public void Send(string message, Colleague sender)
        {
            foreach (var colleague in _colleagues)
            {
                if (colleague != sender)
                {
                    colleague.Receive(message);
                }
            }
        }
    }
}