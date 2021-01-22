using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateTest
{
    /// <summary>
    /// 碰到yield可以先回傳到呼叫端執行後再返回
    /// </summary>
    public class yieldTest
    {
        private IEnumerable<int> cal(int start, int end)
        {
            for (int i = start; i < end; i++)
                yield return i;
            yield break;
        }

        public yieldTest()
        {
            foreach (int item in cal(5, 88))
                Console.WriteLine(item);
        }
    }
}
