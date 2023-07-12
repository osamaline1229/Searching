using C_sharp_List;

internal class Program
{
    private static void Main(string[] args)
    {
        List<person> person = new List<person>();
        person.Add(new person(34002, "7hoom", "Male", "Ectrical"));
        person.Add(new person(35002, "Nora", "Female", "Software Engineering"));
        person.Add(new person(34002, "Maryam", "Feale", "Medical"));
        foreach (var i in person)
        {
            Console.WriteLine(i);
        }

    }
}