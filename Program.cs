using System;

namespace CSharp_Abstraction
{
    public abstract class InfinitiyGautlet
    {
        protected string Stones;

    }

    public class TimeStone : InfinitiyGautlet
    {
        public void power()
        {
            Stones = "Time Stone";
            System.Console.WriteLine(Stones + " can manipulate time. Either going forward, back into time, or get stuck in an infinite loop.");
        }
    }

    public class PowerStone : InfinitiyGautlet
    {
        public void power()
        {
            Stones = "Power Stone";
            System.Console.WriteLine(Stones + " makes the wielder the most strongest entity in all the universe!");
        }
    }

    public class RealityStone : InfinitiyGautlet
    {
        public void power()
        {
            Stones = "Reality Stone";
            System.Console.WriteLine(Stones + " can create thought into reality. Imagination is the only limit to this power.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TimeStone timestone = new TimeStone();
            timestone.power();

            PowerStone powerstone = new PowerStone();
            powerstone.power();

            RealityStone realitystone = new RealityStone();
            realitystone.power();
        }
    }
}
