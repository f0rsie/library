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
        public double p, s;
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
        public virtual void dlina()
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
        public virtual void perimetr()
        {
            p = ab + bc + cd + da;
        }
        public virtual void diag()
        {
            d1 = Sqrt(Pow(t1[0] - t3[0], 2) + Pow(t1[1] - t3[1], 2));
            d2 = Sqrt(Pow(t2[0] - t4[0], 2) + Pow(t2[1] - t4[1], 2));
        }
        public virtual void ss()
        {
            double cos_d1d2 = ((l1[0] * l3[0] + l1[1] * l3[1]) / (Sqrt(l1[0] * l1[0] + l1[1] * l1[1]) * Sqrt(l3[0] * l3[0] + l3[1] * l3[1])));
            double sin_d1d2 = Sqrt(1 - Cos(cos_d1d2) * Cos(cos_d1d2));
            s = d1 * d2 * sin_d1d2;
        }
        public virtual void ugl()
        {
            dlina();
            cos1 = ((l1[0] * l2[0] + l1[1] * l2[1]) / (Sqrt(l1[0] * l1[0] + l1[1] * l1[1]) * Sqrt(l2[0] * l2[0] + l2[1] * l2[1])));
            cos2 = ((l2[0] * l3[0] + l2[1] * l3[1]) / (Sqrt(l2[0] * l2[0] + l2[1] * l2[1]) * Sqrt(l3[0] * l3[0] + l3[1] * l3[1])));
            cos3 = ((l4[0] * l3[0] + l4[1] * l3[1]) / (Sqrt(l4[0] * l4[0] + l4[1] * l4[1]) * Sqrt(l3[0] * l3[0] + l3[1] * l3[1])));
            cos4 = ((l1[0] * l4[0] + l1[1] * l4[1]) / (Sqrt(l1[0] * l1[0] + l1[1] * l1[1]) * Sqrt(l4[0] * l4[0] + l4[1] * l4[1])));
            cos1 = Acos(cos1) * 180 / PI;
            cos2 = Acos(cos2) * 180 / PI;
            cos3 = Acos(cos3) * 180 / PI;
            cos4 = Acos(cos4) * 180 / PI;
        }

        public void get()
        {
            dlina();
            diag();
            ss();
            ugl();
            perimetr();
            WriteLine($"\n\t\t\tНазвание: {name} \n1 угол: {cos1:f3}, 2 угол: {cos2:f3}, 3 угол: {cos3:f3}, 4 угол: {cos4:f3} " +
                $"\n1 диагональ: {d1:f3}, 2 диагональ: {d2:f3} \n1 сторона: {ab:f3}, 2 сторона: {bc:f3}, 3 сторона: {cd:f3}, 4 сторона: {da:f3} \nПериметр: {p:f3} \nПлощадь: {s:f3} ");
        }
    }
    public class paral : vyp
    {
        override public void ss()
        {
            double p = (ab + bc + d1) / 2;
            s = 2 * Sqrt(p * (p - ab) * (p - bc) * (p - d1));
        }
    }
    public class romb : vyp
    {
        override public void ss()
        {
            s = (d1 * d2) / 2;
        }
    }
    public class kvadrat : vyp
    {
        override public void ugl()
        {
            cos1 = 0;
            cos2 = 0;
            cos3 = 0;
            cos4 = 0;
            cos1 = Acos(cos1) * 180 / PI;
            cos2 = Acos(cos2) * 180 / PI;
            cos3 = Acos(cos3) * 180 / PI;
            cos4 = Acos(cos4) * 180 / PI;
        }
        override public void ss()
        {
            s = ab * ab;
        }
        override public void diag()
        {
            d1 = Sqrt(2 * (ab * ab));
            d2 = d1;
        }
    }
}