using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubTask2
{
    public class IntConverter
    {
        private Dictionary<char, int> _numbersDictionary = new Dictionary<char, int>()
        {
            {'0',0 },
            {'1',1 },
            {'2',2 },
            {'3',3 },
            {'4',4 },
            {'5',5 },
            {'6',6 },
            {'7',7 },
            {'8',8 },
            {'9',9 },
        };

        public int Convert(string inputString) {
            if (String.IsNullOrEmpty(inputString))
                throw new ArgumentNullException(inputString, "Empty string for convert");

            char[] inputChars = inputString.ToCharArray().Reverse().ToArray();
            var result = 0;
            var discharge = 0;
            foreach (char item in inputChars)
            {
                try
                {
                    if (discharge == 0)
                    {
                        result += _numbersDictionary[item];
                        discharge = 1;
                    }
                    else
                    {
                        result += _numbersDictionary[item] * discharge;
                    }
                }
                catch {
                    throw new ArgumentException("Finded symbol different than number");
                }
                discharge *= 10;
            }
            return result;
        }
    }
}
