using System;
namespace OpenClose
{
	internal class Chef
	{
		//public void CookMushedPotato()
		//{
		//	//Console.WriteLine("Mushed potato is ready...");
  //      }

  //      public string CookMushedPotato()
  //      {
  //          //Console.WriteLine("Mushed potato is ready...");
  //          return "Mushed potato is ready.";
  //      }

  //      public void CookFrenchFries()
		//{
		//	Console.WriteLine("French fries are ready");
		//}

		public void CookMeal(IMeal meal)
		{
			meal.Cook();
		}
	}
}

