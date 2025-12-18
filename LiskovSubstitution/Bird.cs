using System;
namespace LiskovSubstitution
{
    abstract class Bird
	{
		public int AvgLifeTime { get; set; }
		//public int FlySpeed { get; set; }

		//public virtual void Fly()
		//{
		//	Console.WriteLine(FlySpeed+" "+"Flied away");
		//}

		public virtual void Eat()
		{
			Console.WriteLine("grass");
		}
	}
}

