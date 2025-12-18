using System;
namespace LiskovSubstitution
{
	internal class FlyShow<T> where T:Bird,IFly,new()
	{
		public T Bird { get; set; } = new();

		public void StartShow()
		{
			Bird.Fly();
		}
	}
}

