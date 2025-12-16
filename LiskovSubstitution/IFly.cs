using System;
namespace LiskovSubstitution
{
	public interface IFly
	{
        int FlySpeed { get; set; }

        void Fly();
    }
}

