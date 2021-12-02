using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
   abstract class grafobjekt
    {
        protected int x;
        protected int y;

        public abstract void Kirajzol();
        public abstract void Letorol();
     

        public void Athelyez(int eltolasX, int eltolasY)
        {
            Letorol();
            x += eltolasX;
            y += eltolasY;
            Kirajzol();
        }
        


    }

    class kor: grafobjekt
    {
        public kor(int x,int y)
        {
            this.x = x;
            this.y = y;

        }

        public override void Kirajzol() {
            Console.SetCursorPosition(x,y);
            Console.Write("O"); }
        public override void Letorol() { Console.Clear(); }
       
    }
    class negyzet : grafobjekt
    {
        public negyzet(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public override void Kirajzol()
        {
            Console.SetCursorPosition(x, y);
            Console.Write((char)9600);
        }
        public override void Letorol() { Console.Clear(); }

    }
    class Program
    {
        static void Main(string[] args)
        {

            kor k = new kor(3,4);
            negyzet n = new negyzet(4, 5);
            k.Kirajzol();
            Console.ReadLine();
            n.Kirajzol();
            k.Athelyez(5,11);
            Console.ReadLine();
            n.Athelyez(10, 6);
            k.Athelyez(7, 6);
            Console.ReadLine();
 
       
            n.Athelyez(7, 8);
            Console.ReadLine();
        }
    }
}
