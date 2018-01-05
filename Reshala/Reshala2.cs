using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reshala.DataContracts;

namespace Reshala
{
    public class Reshala2 : IReshala2
    {
        private IHumamSuschestvo _client;
        private IVopros _vopros;
        private IHumamSuschestvo _executor;
        private double _secretCommission;
        private double _thanks;

        public void Prosba( IVopros v, double thanks)
        {
            _vopros = v;
            _thanks = thanks;

        }

        public void ReshitVopros()
        {
            _executor.Execute(_vopros, _thanks - _secretCommission);
        }

    }
}
