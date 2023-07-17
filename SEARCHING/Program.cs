
class Program
{
    

    static void Main(string[] args)
    {

        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        Console.WriteLine("Enter the word to remove:");
        string wordToRemove = Console.ReadLine();

        Sentence manipulator = new Sentence();
        string result = manipulator.RemoveWord(sentence, wordToRemove);
        Console.WriteLine("Result: " + result);







    }
}