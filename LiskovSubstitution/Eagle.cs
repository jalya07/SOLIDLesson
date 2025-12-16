using System;
namespace LiskovSubstitution
{
    internal class Eagle : Bird,IFly
	{
		public int ClawPower { get; set; }
        public int FlySpeed { get ; set ; }

        public void Fly()
        {
            Console.WriteLine("Eagle fly away");
        }
    }
}

