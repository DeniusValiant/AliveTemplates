using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reshala.DataContracts;

namespace Reshala
{
    public class Reshala
    {
        private IClient cl;
        private IVopros v;
        private IExecutor e;

        void Listen(IClient client, IVopros vopros)
        {
            cl = client;
            v = vopros;
        }

        void Resolve(IExecutor executor)
        {
            e = executor;
        }
    }
}
