using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._03
{
    public abstract class Colleague
    {
        protected IMediator mediator;

        public Colleague(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }

        public abstract void Notify(string message);
    }
}
