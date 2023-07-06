internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = {1, 2,3,4,5,6,67,8,9,10};
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
        Console.WriteLine("printing for each");
        foreach(int i in a)
        {
            Console.WriteLine(i);
        }


    }
}