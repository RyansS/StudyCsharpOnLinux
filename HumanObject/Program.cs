Console.WriteLine("Create a new human!");
Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("\nAge: ");
int age = int.Parse(Console.ReadLine());

Console.Write("\nSkin color: ");
string skincolor = Console.ReadLine();

Console.Write("\nWork role: ");
string workrole = Console.ReadLine();

Human newHuman = Human.CreateHuman(name, age, skincolor, workrole);

Human.Humans.Add(newHuman);

class Human
{
    //Properties or characteristics from the object
    public string Name;
    public int Age;
    public string SkinColor;
    public string WorkRole;

    public static List<Human> Humans = new List<Human>();

    //Encapsulation
    private int Id = 1;

    //Constructor
    public Human (string name, int age, string skincolor, string workrole)
    {
        Name = name;
        Age = age;
        SkinColor = skincolor;
        WorkRole = workrole;
        Id += Id;
    }

    //Methods
    public static Human CreateHuman (string name, int age, string skincolor, string workrole)
    {
        return new Human(name,age,skincolor,workrole);
    }



}