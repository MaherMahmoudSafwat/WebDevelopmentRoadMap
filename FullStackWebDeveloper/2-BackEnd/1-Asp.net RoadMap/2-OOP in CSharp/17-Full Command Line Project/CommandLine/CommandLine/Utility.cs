using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    public class Utility
    {
        public static StringBuilder ReplaceFirst(StringBuilder FullStringPath, char OldChar, char NewChar)
        {
            for(int i = 0; i<FullStringPath.Length;i++)
            {
                if (FullStringPath[i] == OldChar)
                {
                    if (NewChar == ' ')
                    {
                        FullStringPath.Remove(i, 1);
                        break;
                    }
                    else
                    {
                        FullStringPath[i] = NewChar;
                        break;
                    }
                }
            }
            return FullStringPath;
        }
    }
}
