using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
namespace bai_2
{
    class Phanso
    {
        private int tu, mau;
        public Phanso()
        {
            tu = mau = 0;
        }
        public Phanso(int x, int y)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public void nhap()
        {
            Console.WriteLine("nhap tu"); tu = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap mau"); mau = int.Parse(Console.ReadLine());
        }
        public void hien()
        {
            //Console.WriteLine("phan so co dang {0}/{1}", tu, mau);
            
            Console.WriteLine($"{tu}/{mau}");
        }
        public int Uscln(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }
        public Phanso rutgon()
        {
            int uc = Uscln(this.tu, this.mau);
            this.tu = this.tu / uc;
            this.mau = this.mau / uc;
            return this;
        }
        public static Phanso operator +(Phanso t1, Phanso t2)
        {
            Phanso t = new Phanso();
            t.tu = t1.tu * t2.mau + t1.mau * t2.tu;
            t.mau = t1.mau * t2.mau;
            return t;
        }
        public static Phanso operator -(Phanso t1, Phanso t2)
        {
            Phanso t = new Phanso();
            t.tu = t1.tu * t2.mau - t1.mau * t2.tu;
            t.mau = t1.mau * t2.mau;
            return t;
        }
        public static Phanso operator /(Phanso t1, Phanso t2)
        {
            Phanso t = new Phanso();
            t.tu = t1.tu * t2.mau;
            t.mau = t1.mau * t2.tu;
            return t;
        }
        public static Phanso operator *(Phanso t1, Phanso t2)
        {
            Phanso t = new Phanso();
            t.tu = t1.tu * t2.tu;
            t.mau = t1.mau * t2.mau;
            return t;
        }
        public static bool operator >(Phanso t1, Phanso t2)
        {
            return t1.tu * t2.mau > t2.tu * t1.mau;
        }
        public static bool operator <(Phanso t1, Phanso t2)
        {
            return t1.tu * t2.mau < t2.tu * t1.mau;
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            Phanso t = new Phanso();
            t.nhap(); t.hien();
            Phanso t2 = new Phanso();
            t2.nhap(); t2.hien();
            Phanso t3 = t + t2; t3.hien();
            Phanso t4 = t * t2; t4.hien();
            if (t > t2)
            {
                Console.WriteLine("ps t1>t2");
            }
            else if (t < t2)
            {
                Console.WriteLine("ps t1<t2S");
            }
            else
                Console.WriteLine("hai ps = nhau");
            Console.ReadKey();
        }
    }
}