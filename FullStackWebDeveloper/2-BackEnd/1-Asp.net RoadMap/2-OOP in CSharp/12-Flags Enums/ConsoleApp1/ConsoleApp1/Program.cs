using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string AlphabetWar(string fight)
        {
            bool IsAllStars = true;
            for(int i=0;i<fight.Length;i++)
            {
                if (fight[i] == '*')
                    continue;
                IsAllStars = false;
                break;
            }
            if (IsAllStars)
                return "Let's fight again!";
            StringBuilder NewString = new StringBuilder();
            for(int i=0;i<fight.Length;i++) //zz*zzs
            {
                if(fight.Length==1)
                {
                    if (fight[i] != '*')
                        NewString.Append(fight[i]);
                    continue;
                }
                if(i==fight.Length-1)
                {
                    if (fight[i - 1] != '*' && fight[i] != '*')
                        NewString.Append(fight[i]);
                    break;
                }
                if (fight[i] == '*')
                {
                    i++;
                    continue;
                }
                else if (fight[i + 1] == '*')
                    continue;
                else if (i != 0)
                {
                    if (fight[i - 1] != '*')
                        continue;
                }

                NewString.Append(fight[i]);
            }
            int LeftSide = 0, RightSide = 0; 
            for (int i = 0; i<NewString.Length;i++)
            {
                if (NewString[i]=='z')
                {

                RightSide++;

                }
                else if (NewString[i] == 'd')
                {
                    RightSide+=2;

                }
                else if (NewString[i] == 'q')
                {
                    RightSide+=3;

                }
                else if (NewString[i] == 'm')
                {
                    RightSide+= 4;
                }
                else if (NewString[i] == 's')
                {
                    LeftSide++;
                }
                else if (NewString[i] == 'b')
                {
                    LeftSide += 2;
                }
                else if (NewString[i] == 'p')
                {
                    LeftSide += 3;
                }
                else if (NewString[i] == 'w')
                {
                    LeftSide += 4;
                }

            }
            if (LeftSide > RightSide)
                return "Left side wins!";
            else if (RightSide > LeftSide)
                return "Right side wins!";
            return "Let's fight again!";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetWar("zz*zzs"));
            //1-qkwtuh*sn**qmpgbp***
            //2-qkwtun**qmpgbp***
            //3-qkwtuqmpgbp***
            //4-qkwtuqmpg
        }
    }
}
