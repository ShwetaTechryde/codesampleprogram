using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codesampleprogram.Models;

namespace codesampleprogram.Interface
{
    public interface IVehcileOperations
    {
        public void  AddVehcile();

        public void DeleteVehcile(int vehid);
        public void UpdateVehcile(int vehid);
    }
}
