using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Grafobj
    {
        protected int X;
        protected int Y;
        public abstract void Kirajzol();
        public abstract void Letorol();
        public abstract int Kerulet();
        public void Athelyez(int eltolasX, int eltolasY)
        {
            Letorol();
            X += eltolasX;
            Y += eltolasY;
            Kirajzol();
        }
    }

    class Kor : Grafobj
    {
        public Kor(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override void Kirajzol() { Console.SetCursorPosition(X,Y); Console.WriteLine("O"); }
        public override void Letorol() { Console.Clear(); }
        public override int Kerulet() { return 1; }
    }

    class Negyzet : Grafobj
    {
        public Negyzet(int x, int y) { X = x; Y = y; }
        public override void Kirajzol() { Console.SetCursorPosition(X, Y); Console.WriteLine((char)9600); }
        public override void Letorol() { Console.Clear(); }
        public override int Kerulet() { return 1; }
    }

    class Program
    {
        static void Main()
        {
            Negyzet kor = new Negyzet(3,4);
            kor.Kirajzol();
            Console.ReadKey();
            kor.Athelyez(5,6);
            Console.ReadKey();
            kor.Athelyez(-2, -3);
            Console.ReadKey();
        }
    }
}
