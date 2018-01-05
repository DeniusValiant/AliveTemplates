using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reshala.DataContracts;

namespace Reshala
{
    public class Businessman : IHumamSuschestvo
    {
        private IReshala2 _reshala;
        private double _secretThanks;

        public void NaytyReshalu(IReshala2 r)
        {
            _reshala = r;
        }

        public void Poprosit(IVopros v)
        {
            _reshala.Prosba(v, _secretThanks);
        }

        public void Execute(IVopros v, double _t)
        {
            // Requst only , not execute
            throw new NotImplementedException();

        }
    }
}
