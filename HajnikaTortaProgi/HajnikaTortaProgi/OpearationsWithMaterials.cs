using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajnikaTortaProgi
{
    class OpearationsWithMaterials
    {
        public OpearationsWithMaterials(DataBase data)
        {
            data.Materials[0].UnitQuantity = +2;
        }
    }
}
