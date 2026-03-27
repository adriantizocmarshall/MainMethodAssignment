using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MathMethod
    {
        public int UserNumber(int userInput)
        {
            return userInput * 4;
        }

        public int UserNumber(decimal userInput)
        {
            return (int)(userInput / 2);
        }

        public int UserNumber(string userInput)
        {
            int parsedString = int.TryParse(userInput, out int result) ? result : 0;

            return parsedString + 6;
        }
    }
}

