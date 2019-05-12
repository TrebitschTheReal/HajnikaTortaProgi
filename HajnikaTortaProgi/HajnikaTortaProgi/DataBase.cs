using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HajnikaTortaProgi
{
    class DataBase
    {
        private static Import import = new Import();
        private RawMaterial[] materials = new RawMaterial[import.NumberOfLines];

        public DataBase()
        {
            GetTheMaterialData();

        }
        private void GetTheMaterialData()
        {
            string name = import.Name;
            string unitType;
            int unitPrice;


        }
    }
}
