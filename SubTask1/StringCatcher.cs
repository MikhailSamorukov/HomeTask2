using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubTask1
{
    public class StringCatcher
    {
        private string _result;

        public string Result
        {
            get { return _result; }
        }

        public void CatchString(string cathedString) {
            if (String.IsNullOrEmpty(cathedString))
                throw new ArgumentNullException(cathedString, "found empty string");
            _result += cathedString[0];
        }

        public StringCatcher()
        {
            _result = "";
        }
    }
}
