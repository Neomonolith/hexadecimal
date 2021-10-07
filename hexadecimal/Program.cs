

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hexaddecimal
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Kérek egy kétjegyű hexadecimális számot");

      //string hexa = Console.ReadLine();
      for (int i = 0; i < 5; i++)
      {




        string hexString = Console.ReadLine();
        int num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine($"Hexadecimális megfelelője: {num}");



        /*

        string hexa = Console.ReadLine();
        // this returns 1322173
        int intValue = int.Parse(hexa, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine(intValue);

        */
      }

      Console.ReadKey();
    }

  }
}
