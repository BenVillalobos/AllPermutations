using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            AllPermutations("ABC", "");
            Console.ReadKey();
        }

        //Backtracking:
        //make a choice
        //explore the options
        //undo the choice
        static void AllPermutations(string data, string chosen)
        {
            if (data.Length == 0)
            {
                Console.WriteLine(chosen);
            }

            for(int i = 0; i < data.Length; i++)
            {
                chosen += data[i];
                data = data.Remove(i, 1);

                AllPermutations(data, chosen);

                data = data.Insert(i, chosen[chosen.Length - 1].ToString());
                chosen = chosen.Remove(chosen.Length - 1);
            }
        }
    }
}
