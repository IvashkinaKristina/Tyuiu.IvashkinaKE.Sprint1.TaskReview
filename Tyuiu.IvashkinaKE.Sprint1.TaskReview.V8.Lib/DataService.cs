using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IvashkinaKE.Sprint1.TaskReview.V8.Lib
{
    public class DataService : ISprint1Task7V8
    {
        public double Calculate(double x, double y)
        {
            double z = (x * Math.Log(x, Math.E)) + (y / (Math.Cos(x) - x / 3));
            return Math.Round(z, 3);
        }
    }
}
