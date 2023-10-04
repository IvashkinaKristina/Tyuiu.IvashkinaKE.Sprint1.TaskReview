using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.IvashkinaKE.Sprint1.TaskReview.V8.Lib;

namespace Tyuiu.IvashkinaKE.Sprint1.TaskReview.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "SprintReview | Выполнила: Ивашкина К.Э. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* SprintReview                                                            *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Ивашкина Кристина Эдуардовна | АСОиУб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                        y                                                *");
            Console.WriteLine("* z = x ln * x + ----------------                                         *");
            Console.WriteLine("*                cos * x - x / 3                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"z = {ds.Calculate(x, y)}");
            Console.ReadKey();

        }
    }
}
