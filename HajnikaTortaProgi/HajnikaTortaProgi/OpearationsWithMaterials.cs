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
            int cnt = 1;

            for (int i = 0; i < data.Materials.Count; i++)
            {
                Console.WriteLine("{0}. {1}", cnt, data.Materials[i].Name);
                cnt++;
            }
        }
    }
}
