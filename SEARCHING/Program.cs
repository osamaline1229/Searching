
class Program
{
    

    static void Main(string[] args)
    {

        BracketChecker bracketChecker = new BracketChecker();

        
        string input1 = "((()])";           
        string input2 = "{[()]}";           
        string input3 = "([{}])";           
        string input4 = "((()))))";         
        string input5 = "[[{(())}]]";       

        Console.WriteLine($"Input1: {bracketChecker.CheckBalance(input1)}"); 
        Console.WriteLine($"Input2: {bracketChecker.CheckBalance(input2)}"); 
        Console.WriteLine($"Input3: {bracketChecker.CheckBalance(input3)}"); 
        Console.WriteLine($"Input4: {bracketChecker.CheckBalance(input4)}"); 
        Console.WriteLine($"Input5: {bracketChecker.CheckBalance(input5)}"); 







    }
}