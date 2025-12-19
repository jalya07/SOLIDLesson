namespace OpenClose;

class Program
{
    static void Main(string[] args)
    {
        //Chef chef = new Chef();
        //chef.CookMushedPotato();

        IMeal meal = new MushedPotato();
        IMeal meal2 = new FrenchFries();
        Chef chef = new Chef();
        chef.CookMeal(meal);
        chef.CookMeal(meal2);

    }
}

