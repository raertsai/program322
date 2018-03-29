using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _322practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "ade", "eff", "vrtc", "yv", "ub", "ub", "tv", "yvut", "yf", "vytf" };
            int[] height = { 23, 24, 54, 24, 23, 67, 67, 78, 43, 89 };
            Random rand = new Random();

            int r = rand.Next(0, height.Length);

            Console.WriteLine(r + ":" + height[r]);

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);

            }
            Console.ReadLine();
        }
    }
}
            
    

