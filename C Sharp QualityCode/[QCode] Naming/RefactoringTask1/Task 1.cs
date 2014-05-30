// Refactor the following examples to produce code with well-named C# identifiers:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public class OuterClass
    {
        const int MAX_COUNT = 6;

        public class InnerClass
        {
            public void ConvertBoolToString(bool value)
            {
                string promenlivaKatoString = value.ToString();
                Console.WriteLine(promenlivaKatoString);
            }
        }
        public static void Main()
        {
            OuterClass.InnerClass obj = new OuterClass.InnerClass();
            obj.ConvertBoolToString(true);
        }
    }

}
