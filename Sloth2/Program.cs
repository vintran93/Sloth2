// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information


namespace Sloth2
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "sloth";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else
                {
                    outOfGuesses = true;
                }
                
            }
            if (outOfGuesses)
            {
                Console.Write("You Lose!");
            } else
            {
                Console.Write("You win!");
            }

            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("\n" + i);
                i++;
            }

            // same code as above
            /*int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
           
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[1]);
                
            }*/

            // 2D Arrays
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };
            int[,] myArray = new int[2, 3];

            // Comments
            // comment on 1 Line
            /* Multiple
               Line
               Comment */
            // short cut = contro + shift + / 

            // Exception Handling ; prevent program from terminating from errors

            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");

                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write(num1 + " divided by " + num2 + "=\n");
                Console.WriteLine(num1 / num2);
            } 
            
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            /*finally
            {

            }*/

            // Classes & Objects

            // Object (instance of a class)
            // book object
            /*Book book1 = new Book("Vincent's Book"); */

            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            /*book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;*/

            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);
            /*Book book2 = new Book("Anne's Book");
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;*/
            book2.title = "The Hobbit"; // reassigned book 2 title
            Book book3 = new Book();

            Console.WriteLine("Your book is: ");
            Console.WriteLine(book1.title + " " + book1.author + " " + book1.pages);

            Console.WriteLine("Your book is: ");
            Console.WriteLine(book2.title + " " + book2.author + " " + book2.pages);

            Console.WriteLine("\nNumber Grid: ");
            Console.WriteLine(numberGrid[0, 0]);

            Console.WriteLine("\nExponentials: ");
            Console.WriteLine(GetPow(4, 3));
            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
        


    }
}