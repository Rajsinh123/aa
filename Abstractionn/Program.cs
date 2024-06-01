using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractionn
{
    abstract class Animal
    {
        public abstract void animalsound();
    
    public void sleep()
    {
        Console.WriteLine("ZZZZZZZZZZZZZ");
    }
    }
    class Pig : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("Pig says+wee weee");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig mypig = new Pig();
            mypig.animalsound();
            mypig.sleep();
            Console.ReadLine();
        }
    }
}
