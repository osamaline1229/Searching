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

        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(6);


    }
}