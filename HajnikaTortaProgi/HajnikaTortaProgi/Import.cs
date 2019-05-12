using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HajnikaTortaProgi
{
    class Import
    {
        private StringOperations stringops = new StringOperations();

        private string name;
        private int quantity;
        private string unitType;
        private int unitPrice;
        private int numberOfLines;

        public Import()
        {
            this.numberOfLines = LineCounter();
            this.name = GetTheName();

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
        public int NumberOfLines
        {
            get { return numberOfLines; }
        }

        private string GetTheName()
        {
            StreamReader sr = new StreamReader(@"E:\HajnikaTortaProgi\alapanyagok.csv", Encoding.Default);
            string firstLine = sr.ReadLine();
            string secondLine = sr.ReadLine();

            string name = stringops.StringUntilFirstSpace(secondLine);
            return name;

        }
        private int LineCounter()
        {
            int numberOfLines = 0;

            StreamReader sr = new StreamReader(@"E:\HajnikaTortaProgi\alapanyagok.csv", Encoding.Default);
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                numberOfLines++;
            }

            numberOfLines -= 1;
            sr.Close();
            return numberOfLines;
        }
    }
}
