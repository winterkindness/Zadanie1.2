using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    class Pr2
    {
        static void Main(string[] args)
        {
            double x,y,r;
            Console.Write("Координата X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Координата Y: ");
            y = Convert.ToDouble(Console.ReadLine());
             r = Math.Pow(Math.Pow(x,2)+Math.Pow(x,2),0.5);
           if (r>=0.5 && r<=1)
               if (x<=0 && y>=0)
                   Console.WriteLine("Данная точка не принадлежит заштрихованной поверхности");
               else
                   Console.WriteLine("Данная точка принадлежит заштрихованной поверхности");
           else
               Console.WriteLine("Данная точка не принадлежит заштрихованной поверхности");
            Console.ReadKey();
        }
    }
}
