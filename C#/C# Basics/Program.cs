namespace C__Basics 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("What Would you like to do? ");
            string action = Console.ReadLine().ToLower();

            Test test = new Test();

            if (action == "add") 
            {
                Console.WriteLine($"Answer: {test.add()}");
            }

        }
    }

    public class Test 
    {
        public int add() 
        {
            int answer = 0;
            bool endIf = false;

            while (endIf != true) 
            {
                Console.WriteLine("Type number: (Enter = to calculate)");
                string userInput = Console.ReadLine();

                if (userInput == "=")
                {
                    endIf = true;
                }
                else if (Int32.TryParse(userInput, out var convertedInput)) {
                    answer += Convert.ToInt32(convertedInput);
                }
                else
                {
                    Console.WriteLine("Something went wrong please type a number to add or = to calculate.");                  
                }
            }

            return answer; 
        }

    }






}
