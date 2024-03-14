using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._03
{
    public interface IMediator
    {
        void Send(string message, Colleague colleague);
    }
}
