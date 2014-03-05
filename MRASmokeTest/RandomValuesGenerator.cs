using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    class RandomValuesGenerator
    {
        public static void generateSKData (string client)
    {
        if (string.Compare(client, "hartford", true)==0) 
        { 
        
        
        }

    }


        public static int setRandomInt(int minValue, int maxValue)
        {
            Random random = new Random();
            int randomNumber = random.Next(minValue, maxValue);
            return randomNumber;
        }
        public static string setRandomString(int stringSize)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < stringSize; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
