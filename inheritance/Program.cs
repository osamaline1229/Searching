namespace cSharp_SchoolManagementSystem
{
    internal class Program
    {
        
        



        static void Main(string[] args)
        {

            Console.Write("Input the file path: ");
            string filePath = Console.ReadLine();

            try
            {
                // Attempt to open the file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // File opened successfully
                    Console.WriteLine("File opened successfully.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while accessing the file: " );
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " );
            }
            //int[] a = { 1, 2, 3, 0 };

            //try
            //{
            //    Console.WriteLine(a[0] / a[2]);
            //    //Console.WriteLine(a[10] / a[1]);
            //    Console.WriteLine(a[0] / a[3]);
            //} catch( DivideByZeroException  ex )
            //{
            //    Console.WriteLine("Error: Some error Occurred");
            //}catch( Exception ex )
            //{
            //    Console.WriteLine("Another Error");
            //}

            //Console.WriteLine("Outside Try block");
            //Console.WriteLine("Program Completed");
        }

        //private static float divide (int a , int b)
        //{
        //    return a / b;
        //}

        //private static float divide(float x, float y)
        //{

        //}
    }
}