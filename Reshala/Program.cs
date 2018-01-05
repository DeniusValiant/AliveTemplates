using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reshala.DataContracts;

namespace Reshala
{
    class Program
    {
        static void Main(string[] args)
        {
            IReshala2 con = new Reshala2();

            Businessman businessman = new Businessman();

            businessman.NaytyReshalu(con);

            Chinovnik chinovnik = new Chinovnik();

        }
    }
}
