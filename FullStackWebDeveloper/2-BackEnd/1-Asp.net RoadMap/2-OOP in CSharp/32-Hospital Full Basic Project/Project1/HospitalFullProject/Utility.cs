using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class Utility
    {
        public static Boolean IsSpecialCharactersFound(string Word, string SpecialCharacters)
        {
            for(int i =0;i<SpecialCharacters.Length;i++)
            {
                if (Word.Contains(SpecialCharacters[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
