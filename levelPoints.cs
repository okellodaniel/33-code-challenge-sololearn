

using System;

namespace _33_Code_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Points(levels));
        }

        static int Points(int levels){
          if(levels < 1){
              return 0;
          }else if (levels == 1){
            return 1;
          }
          else
          {
              return levels + Points(levels - 1);
          }
        }
    }
}
