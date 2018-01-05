using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEK.DataContracts
{
    public class DispetcherJeka : IRobotyaga
    {
        public bool SdelyatSvoyuRabotu(string rabota)
        {
            throw new NotImplementedException();
        }

        public void PoluchitZayvku(string zayavka)
        {
            SdelyatSvoyuRabotu(zayavka);
        }
    }
}
