using System.Security.Cryptography;

namespace exponets_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Please enter an integer ");
                int usernum = int.Parse(Console.ReadLine());
                if (usernum >= 1 && usernum < 1290)
                {
                    Console.WriteLine($"Number \t\t\t Double \t\t\t Triple");
                    for (int i = 1; i <= usernum; i++)
                    {
                        Console.WriteLine($"{i}\t\t\t {i * i}\t\t\t\t\t{i*i*i}");
                        
                    }

                    Console.WriteLine("Do you want to contiue? y/n");
                    string choice = Console.ReadLine();
                    if (choice == "y".ToLower())
                    {
                        repeat = true;
                    }
                    else if (choice == "n".ToLower())
                    {
                        repeat = false;
                    }
                }
                else 
                {
                    Console.WriteLine("Please select a number between 1-1290.");
                }
            












            }
        }
    }
}
