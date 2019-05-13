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
        private static int numberOfMaterials;
        private string[] materialName = new string[numberOfMaterials];
        private string[] materialUnitType = new string[numberOfMaterials];
        private int[] materialUnitPrice = new int[numberOfMaterials];

        public Import()
        {
            numberOfMaterials = MaterialCounter();
            GenerateMaterialData();

        }
        public string[] MaterialName
        {
            get { return materialName; }
        }
        public string[] MaterialUnitType
        {
            get { return materialUnitType; }
        }
        public int[] MaterialUnitPrice
        {
            get { return materialUnitPrice; }
        }


        public int NumberOfMaterials
        {
            get { return numberOfMaterials; }
        }

        public string StringUntilFirstSpace(string text)
        {
            string textPiece = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    textPiece += text[i];
                }
            }
            return textPiece;
        }
        public int MaterialCounter()
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
        private void GenerateMaterialData()
        {
            StreamReader sr = new StreamReader(@"E:\HajnikaTortaProgi\alapanyagok.csv", Encoding.Default);
            int cnt = 0;
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] elements = line.Split(' ');

                materialName[cnt] = elements[cnt];
                materialUnitType[cnt] = elements[cnt+1];
                materialUnitPrice[cnt] = int.Parse(elements[cnt+2]);

                cnt++;
            }
            sr.Close();
        }

    }
}
