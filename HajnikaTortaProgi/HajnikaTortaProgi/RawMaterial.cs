using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajnikaTortaProgi
{
    class RawMaterial
    {
        private string name;
        private int quantity;
        private string unitType;
        private int unitPrice;

        public RawMaterial(string name, string unitType, int unitPrice)
        {
            this.name = name;
            this.quantity = 0;
            this.unitType = unitType;
            this.unitPrice = unitPrice;
        }
        public string Name
        {
            get { return name; }
        }
        public int Quantity
        {
            get { return quantity; }
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
