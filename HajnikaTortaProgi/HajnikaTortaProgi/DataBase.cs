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
        private List<RawMaterial> materials = new List<RawMaterial>();

        public DataBase()
        {
            Import import = new Import();
            GetTheMaterialData(import);

        }
        public List<RawMaterial> Materials
        {
            get { return materials; }
        }
        private void GetTheMaterialData(Import import)
        {
            for (int i = 0; i < import.MaterialName.Count; i++)
            {
                materials.Add(new RawMaterial(import.MaterialName[i], import.MaterialUnitType[i], import.MaterialUnitPrice[i]));
            }
        }
    }
}
