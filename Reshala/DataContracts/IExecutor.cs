using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reshala.DataContracts
{
    public interface IExecutor
    {
        void Execute( IVopros v, double _t);
    }
}
