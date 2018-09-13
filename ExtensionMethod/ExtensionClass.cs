using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class ExtensionClass
    {
        public static int IntCevir(this string deger)
        {
            return Convert.ToInt32(deger);
        }

        public static string StrCevir(this object deger)
        {
            return deger.ToString();
        }

        public static string ClazzTest(this Clazz clazz, string str)
        {
            return str + ":" + clazz.id.ToString();
        }

        public static string ClazzTest(this Clazz clazz, int str)
        {
            return str.ToString() + ":" + clazz.id.ToString();
        }
    }
}
