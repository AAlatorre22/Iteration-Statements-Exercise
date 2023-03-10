using System.Globalization;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program!");
            Console.WriteLine();
            Console.WriteLine("Let's begin by showing you how fast I can count from -1,000 to 1,000!");
            Console.WriteLine();
            Console.WriteLine("Please hit ENTER to begin the program!");
            Console.ReadLine();

            //METHOD 1

            SoManyNumbers();

            Console.WriteLine();
            Console.WriteLine("If you thought that was impressive,\nlook how I can count from 3 to 999 by counting every third number!");
            Console.WriteLine("Please hit ENTER to continue:");
            Console.ReadLine();

           // METHOD 2

           SkipByThree();

            Console.WriteLine();
            Console.WriteLine("Impressed yet?");
            Console.WriteLine();
            Console.WriteLine("Please hit ENTER to continue:");
            Console.ReadLine();

            //METHOD 3

            AmISeeingDouble();

            Console.WriteLine();
            Console.WriteLine("Please hit ENTER to continue:");
            Console.ReadLine();

            //METHOD 4

            EvenOrOdd();

            Console.WriteLine();
            Console.WriteLine("Please hit ENTER to continue:");
            Console.ReadLine();

            //METHOD 5

            CanTheyVote();

            Console.WriteLine();
            Console.WriteLine("Please hit ENTER to continue:");
            Console.ReadLine();

            //METHOD 6

            IsThisPosOrNeg();

            Console.WriteLine();
            Console.WriteLine("Please hit ENTER to conitnue:");
            Console.ReadLine();

            //METHOD 7

            BetweenTwoFerns();

            Console.WriteLine();
            Console.WriteLine("Please hit ENTER to continue:");
            Console.ReadLine();

            //METHOD 8 

            MultiplyThis();

            Console.WriteLine();
            Console.WriteLine("You have reached the end of the program!\nThanks for playing. Good bye!");


        }


        public static void SoManyNumbers()
        {
            for (int i = -1000; i <= 1000; i++ )
            {
                Console.WriteLine(i);
            }
        }

        public static void SkipByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
               
                Console.WriteLine(i);
            }
        }

        public static void AmISeeingDouble()
        {
            Console.WriteLine("We are going to compare two numbers to see if they are equal.");
            Console.WriteLine("Please enter your first number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Great number! Please enter your second number.");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (x == y)
                Console.WriteLine("Looks like you've got a match!");
            else
                Console.WriteLine("Hmm.. these aren't quite the same.");

        }


        public static void EvenOrOdd()
        {
            Console.WriteLine("We are going to determine if any number of your choosing is even or odd!");
            Console.WriteLine("Please enter your number!");
            var a = int.Parse(Console.ReadLine());
            var b = (a % 2);
            Console.WriteLine();

            string result = b == 0 ? "Your number is even!" : "You number is odd!";

            Console.WriteLine(result);


        }


        public static void IsThisPosOrNeg()
        {
            Console.WriteLine("We are going to determine if your number is positive or negative.");
            Console.WriteLine("Please enter a positive or negative number.");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (p < 0)

                Console.WriteLine("Your number is like Nancy. Negative!");
            else if (p > 0)
                Console.WriteLine("You must have a great personality. You are so positive!");
            else
                Console.WriteLine("Trying to outsmart me? Nice try! \nThat is neither positive or negative!");
            
        }



        public static void CanTheyVote()
        {
            Console.WriteLine("Let's determine whether you can vote or not!");
            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (age >= 18)
            
            Console.WriteLine("Head to the polls my friend!");
            else
                Console.WriteLine("Sorry. Not this election, junior!");
        }

        public static void BetweenTwoFerns()
        {
            Console.WriteLine("Let's check to see if your number is between -10 and 10! \nPlease enter your number:");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (g >= -10 && g <= 10)
                Console.WriteLine("Your number fits in the range!");
            else
                Console.WriteLine("Sorry, your number is outside the scope of my paramaters!");
        }

        public static void MultiplyThis()
        {
            Console.WriteLine("We are now going to do our multiplication tables from 1-12 of any number of your choosing!\nPlease enter a number you wish to multiply!");
            int j = int.Parse(Console.ReadLine());
            int m = (j * 1);
            int u = (j * 2);
            int l = (j * 3);
            int t = (j * 4);
            int i = (j * 5);
            int p = (j * 6);
            int v = (j * 7);
            int y = (j * 8);
            int c = (j * 9);
            int z = (j * 10);
            int a = (j * 11);
            int h = (j * 12);
            Console.WriteLine();

            Console.WriteLine($"{j} times 1 = {m}\n{j} times 2 = {u}\n{j} times 3 = {l}\n{j} times 4 = {t}\n{j} times 5 = {i}\n{j} times 6 = {p}\n{j} times 7 = {v}\n{j}" +
            $" times 8 = {y}\n{j} times 9 = {c}\n{j} times 10 = {z}\n{j} times 11 = {a}\n{j} times 12 = {h}");
        }
    }
}
