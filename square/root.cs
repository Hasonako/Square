using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    internal class root
    {
        public static string squareRoot(int a, int b, int c)
        {
            string square = "";
            double x1, x2;
            double d = Math.Pow(b,2) - 4 * a * c;

            if (d < 0) square = "Корней нет";

            if (d == 0) square = $"Дискриминант = 0\nКорень = {-b / (2 * a)}";

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                square = $"Первый корень: {x1};\nВторой корень: {x2}";
            } 
                
            return square;
        }
    }
}
