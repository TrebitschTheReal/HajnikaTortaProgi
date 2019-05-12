using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajnikaTortaProgi
{
    class StringOperations
    {
        public string StringUntilFirstSpace(string text)
        {
            string textPiece = "";

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] != ' ')
                {
                    textPiece += text[i];
                }
            }
            return textPiece;
        }
    }
}
