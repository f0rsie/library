using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;

namespace Vyp
{
    public class vyp
    {
        public string name;
        public double ab, bc, cd, da, d1, d2;
        public double cos1, cos2, cos3, cos4;
        double[] l1 = new double[2];
        double[] l2 = new double[2];
        double[] l3 = new double[2];
        double[] l4 = new double[2];
        public int[] t1 = new int[2];
        public int[] t2 = new int[2];
        public int[] t3 = new int[2];
        public int[] t4 = new int[2];
        public void dlina()
        {
            ab = Sqrt(Pow(t2[0] - t1[0], 2) + Pow(t2[1] - t1[1], 2));
            bc = Sqrt(Pow(t3[0] - t2[0], 2) + Pow(t3[1] - t2[1], 2));
            cd = Sqrt(Pow(t4[0] - t3[0], 2) + Pow(t4[1] - t3[1], 2));
            da = Sqrt(Pow(t1[0] - t4[0], 2) + Pow(t1[1] - t4[1], 2));
            for (int i = 0; i <= 1; i++)
            {
                l1[i] = t2[i] - t1[i];
                l2[i] = t3[i] - t2[i];
                l3[i] = t4[i] - t3[i];
                l4[i] = t1[i] - t4[i];
            }
        }
        public double perimetr()
        {
            return ab + bc + cd + da;
        }
        public void diag()
        {
            d1 = Sqrt(Pow(t1[0] - t3[0], 2) + Pow(t1[1] - t3[1], 2));
            d2 = Sqrt(Pow(t2[0] - t4[0], 2) + Pow(t2[1] - t4[1], 2));
        }
        public double s()
        {  
            double cos_d1d2 = ((l1[0] * l3[0] + l1[1] * l3[1]) / (Sqrt(l1[0] * l1[0] + l1[1] * l1[1]) * Sqrt(l3[0] * l3[0] + l3[1] * l3[1])));
            double sin_d1d2 = Sqrt(1 - Cos(cos_d1d2) * Cos(cos_d1d2));
            return d1 * d2 * sin_d1d2;
        }
        public void ugl()
        {
            s();
            cos1 = ((l1[0] * l2[0] + l1[1] * l2[1]) / (Sqrt(l1[0] * l1[0] + l1[1] * l1[1]) * Sqrt(l2[0] * l2[0] + l2[1] * l2[1])));
            cos2 = ((l2[0] * l3[0] + l2[1] * l3[1]) / (Sqrt(l2[0] * l2[0] + l2[1] * l2[1]) * Sqrt(l3[0] * l3[0] + l3[1] * l3[1])));
            cos3 = ((l4[0] * l3[0] + l4[1] * l3[1]) / (Sqrt(l4[0] * l4[0] + l4[1] * l4[1]) * Sqrt(l3[0] * l3[0] + l3[1] * l3[1])));
            cos4 = ((l1[0] * l4[0] + l1[1] * l4[1]) / (Sqrt(l1[0] * l1[0] + l1[1] * l1[1]) * Sqrt(l4[0] * l4[0] + l4[1] * l4[1])));
        }
        public void get()
        {
            dlina();
            diag();
            ugl();
            WriteLine($"\n\t\t\tНазвание: {name} \n1 угол: {Acos(cos1) * 180 / PI:f3}, 2 угол: {Acos(cos2) * 180 / PI:f3}, 3 угол: {Acos(cos3) * 180 / PI:f3}, 4 угол: {Acos(cos4) * 180 / PI:f3} " +
                $"\n1 диагональ: {d1:f3}, 2 диагональ: {d2:f3} \n1 сторона: {ab:f3}, 2 сторона: {bc:f3}, 3 сторона: {cd:f3}, 4 сторона: {da:f3} \nПериметр: {perimetr():f3} \nПлощадь: {s():f3} ");
        }
    }
    public class paral : vyp
    {
        new public double s()
        {
            double p = (ab + bc + d1) / 2;
            return 2 * Sqrt(p * (p - ab) * (p - bc) * (p - d1));
        }
        new public void get()
        {
            dlina();
            diag();
            ugl();
            WriteLine($"\n\t\t\tНазвание: {name} \n1 угол: {Acos(cos1) * 180 / PI:f3}, 2 угол: {Acos(cos2) * 180 / PI:f3}, 3 угол: {Acos(cos3) * 180 / PI:f3}, 4 угол: {Acos(cos4) * 180 / PI:f3} " +
                $"\n1 диагональ: {d1:f3}, 2 диагональ: {d2:f3} \n1 сторона: {ab:f3}, 2 сторона: {bc:f3}, 3 сторона: {cd:f3}, 4 сторона: {da:f3} \nПериметр: {perimetr():f3} \nПлощадь: {s():f3} ");
        }
    }
    public class romb : vyp
    {
        new public double s()
        {
            return (d1 * d2) / 2;
        }
        new public void get()
        {
            dlina();
            diag();
            ugl();
            WriteLine($"\n\t\t\tНазвание: {name} \n1 угол: {Acos(cos1) * 180 / PI:f3}, 2 угол: {Acos(cos2) * 180 / PI:f3}, 3 угол: {Acos(cos3) * 180 / PI:f3}, 4 угол: {Acos(cos4) * 180 / PI:f3} " +
                $"\n1 диагональ: {d1:f3}, 2 диагональ: {d2:f3} \n1 сторона: {ab:f3}, 2 сторона: {bc:f3}, 3 сторона: {cd:f3}, 4 сторона: {da:f3} \nПериметр: {perimetr():f3} \nПлощадь: {s():f3} ");
        }
    }
    public class kvadrat : vyp
    {
        new public void ugl()
        {
            cos1 = 0;
            cos2 = 0;
            cos3 = 0;
            cos4 = 0;
        }
        new public double s()
        {
            return ab * ab;
        }
        new public void diag()
        {
            d1 = Sqrt(2 * (ab * ab));
            d2 = d1;
        }
        new public void get()
        {
            dlina();
            diag();
            ugl();
            WriteLine($"\n\t\t\tНазвание: {name} \n1 угол: {Acos(cos1) * 180 / PI:f3}, 2 угол: {Acos(cos2) * 180 / PI:f3}, 3 угол: {Acos(cos3) * 180 / PI:f3}, 4 угол: {Acos(cos4) * 180 / PI:f3} " +
                $"\n1 диагональ: {d1:f3}, 2 диагональ: {d2:f3} \n1 сторона: {ab:f3}, 2 сторона: {bc:f3}, 3 сторона: {cd:f3}, 4 сторона: {da:f3} \nПериметр: {perimetr():f3} \nПлощадь: {s():f3} ");
        }
    }
}