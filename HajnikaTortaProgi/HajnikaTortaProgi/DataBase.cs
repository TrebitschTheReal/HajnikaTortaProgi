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
        private RawMaterial[] materials = new RawMaterial[import.NumberOfMaterials];

        public DataBase()
        {
            GetTheMaterialData();

        }
        public RawMaterial[] Materials
        {
            get { return materials; }
        }
        private void GetTheMaterialData()
        {
            for (int i = 0; i < materials.Length; i++)
            {
                materials[i] = new RawMaterial(import.MaterialName[i], import.MaterialUnitType[i], import.MaterialUnitPrice[i]);
            }
        }
    }
}
