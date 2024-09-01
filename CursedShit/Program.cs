using CursedShit;

public class Program
{
    public static void Main(string[] args)
    {
        Person Tobias = new Person("Tobias", 30);
        Person Weronika = new Person();

        String TobiasLol = Tobias.ToXML();

        Weronika.FromXML(TobiasLol);

        Console.WriteLine(Weronika.Age);


    }
}