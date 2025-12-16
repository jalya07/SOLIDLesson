namespace LiskovSubstitution;

class Program
{
    static void Main(string[] args)
    {
        FlyShow<Eagle> flyShow = new FlyShow<Eagle>();
        flyShow.StartShow();

        //Penguin penguin = new Penguin();
        //penguin.Fly();
    }
}

