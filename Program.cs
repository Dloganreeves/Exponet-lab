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
                    Console.WriteLine($"Header \t\t\t Double \t\t\t Triple");
                    for (int i = 0; i < usernum; i++)
                    {
                        Console.WriteLine($"{i}\t\t\t {i * i}\t\t\t\t\t{i*i*i}");
                        
                    }

                    Console.WriteLine("Do you want to contiue? y/n");
                    string choice = Console.ReadLine();
                    if (choice == "y".ToUpper())
                    {
                        repeat = true;
                    }
                    else if (choice == "n".ToUpper())
                    {
                        repeat = false;
                    }
                }
                else 
                {
                    Console.WriteLine("Please select a number greater than 0.");
                }
            












            }
        }
    }
}
