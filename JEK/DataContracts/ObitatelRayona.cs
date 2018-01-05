using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEK.DataContracts
{
    public class ObitatelRayona : IObitatelRayona
    {
        private List<string> _podyanieZayavki;
        private Jek _jek;

        public ObitatelRayona(Jek jek)
        {
            _jek = jek;
        }
        public void PodatZayavkuVJek(string zayavka)
        {
            _jek.PrinyatZayavku(zayavka);
        }
    }
}
