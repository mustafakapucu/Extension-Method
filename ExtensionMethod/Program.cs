using ExtensionMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Clazz clazz = new Clazz();
            var vv = clazz.ClazzTest("Değer");

            Console.ReadLine();
        }
    }
}
