using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateTest
{
    public class deletateClass
    {
        private delegate string GenericDelegate<T1, T2>(int a, int b);

        private static string Cal(int a, int b)
        {
            return (a + b).ToString();
        }

        public deletateClass()
        {
            GenericDelegate<int, int> gd = new GenericDelegate<int, int>(Cal);
            Console.WriteLine(gd(1, 2));
            Func<int, int, string> FuncIntIntString = (a, b) => (a + b).ToString();
            Console.WriteLine(FuncIntIntString(2, 3));
        }
    }
}
