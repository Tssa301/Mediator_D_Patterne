using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IMediator
    {
        //Methods Register and Send messages.
        void Register(Colleague colleague);
        void Send(string message, Colleague sender);
    }
}