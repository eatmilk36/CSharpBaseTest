using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateTest
{
    public class ActionTest
    {
        /// <summary>
        /// 跟Func<T1,T2>(T3)很像只是沒有傳入值跟回傳值
        /// </summary>
        public ActionTest()
        {
            Action a = new Action(Cal);
            Action showMethod = Cal;
            Action showMethod2 = delegate () { Cal(); };
        }

        private void Cal()
        {
            Console.WriteLine("Ya");
        }

    }
}
