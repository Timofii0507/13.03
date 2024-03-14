using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._03
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            colleague1.Send("How are you?");
            colleague2.Send("Fine, thanks!");
        }
    }
}
