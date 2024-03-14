using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._03
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(IMediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: " + message);
        }
    }
}
