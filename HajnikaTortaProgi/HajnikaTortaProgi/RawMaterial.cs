using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajnikaTortaProgi
{
    class RawMaterial
    {
        private string name = "";
        private string unitType = "";
        private int unitPrice = 0;
        private int unitQuantity = 0;

        public RawMaterial(string name, string unitType, int unitPrice, int materialQuantity)
        {
            this.name = name;
            this.unitType = unitType;
            this.unitPrice = unitPrice;
            this.unitQuantity = materialQuantity;
        }
        public string Name
        {
            get { return name; }
        }
        public int UnitQuantity
        {
            get { return unitQuantity; }
            set { unitQuantity = value; }
        }
        public string UnitType
        {
            get { return unitType; }
        }
        public int UnitPrice
        {
            get { return unitPrice; }
        }

    }
}
