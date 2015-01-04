using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    public class Program
    {
        public static string input { get; set; }
        public static bool[] used { get; set; }
        public static StringBuilder sb { get; set; }
        public static int position { get; set; }
        public static int wordLength { get; set; }
        public static void Main()
        {
            input = Console.ReadLine();
            position = 0;
            sb = new StringBuilder();
            wordLength = 0;
            used = new bool[input.Length];
            DoPermutations(input, /*position,*/ used, sb, wordLength);
            Console.ReadKey();
        }

        public static void DoPermutations(string s, /*int pos,*/ bool[] used, StringBuilder sb, int length)
        {
            #region foreach
            if (length == s.Length)
            {
                Console.WriteLine(sb.ToString());
                return;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    sb.Append(s[i]);
                    length++;
                    //pos++;
                    DoPermutations(s, /*pos,*/ used, sb, length);
                    used[i] = false;
                    length--;
                    sb.Remove(sb.Length - 1, 1);
                }
            }
            #endregion

            #region for
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (used[i] == false)
            //    {
            //        if (length == s.Length)
            //        {
            //            Console.WriteLine(sb.ToString());
            //            return;
            //        }
            //        else
            //        {
            //            used[i] = true;
            //            sb.Append(s[i]);
            //            length++;
            //            pos++;
            //            output(s, pos, used, sb, length);
            //        }
            //    }
            //}
            #endregion
        }
    }
}
