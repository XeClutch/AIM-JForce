using System;
using System.Collections;
using System.Text;

namespace AIM_JForce
{
    public class Bruteforce/* : IEnumerable*/
    {
        private StringBuilder sb = new StringBuilder();
        public string charset = "";
        public ulong counter = 0;
        private ulong len;
        private int _max;
        public int max { get { return _max; } set { _max = value; } }
        private int _min;
        public int min { get { return _min; } set { _min = value; } }

        //public IEnumerator GetEnumerator()
        //{
        //    len = (ulong)this.charset.Length;
        //    for (double x = min; x <= max; x++)
        //    {
        //        ulong total = (ulong)Math.Pow((double)charset.Length, (double)x);
        //        ulong counter = 0;
        //        while (counter < total)
        //        {
        //            string a = factoradic(counter, x - 1);
        //            yield return a;
        //            counter++;
        //        }
        //    }
        //}

        public string GetNext()
        {
            len = (ulong)charset.Length;
            for (double x = min; x <= max; x++)
            {
                ulong total = (ulong)Math.Pow((double)charset.Length, (double)x);
                while (counter < total)
                {
                    string a = factoradic(counter, x - 1);
                    counter++;
                    return a;
                }
            }
            return "fail";
        }

        private string factoradic(ulong l, double power)
        {
            sb.Length = 0;
            while (power >= 0)
            {
                sb = sb.Append(this.charset[(int)(l % len)]);
                l /= len;
                power--;
            }
            return sb.ToString();
        }
    }
}