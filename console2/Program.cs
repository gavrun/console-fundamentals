using System;

namespace console2
{
    class Program // Introduction to C# // C# 101 // Channel 9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //string 

            string aFriend = "Bill";
            Console.WriteLine(aFriend);

            aFriend = "Maira";
            Console.WriteLine(aFriend);

            Console.WriteLine("Hello " + aFriend); //variable + constant

            aFriend = "Ben";
            Console.WriteLine($"Hello {aFriend}"); //string interpolation

            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}!");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            //trim

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            //replace

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);

            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            //search

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));

            //integer 

            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            //math

            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);

            //precedence

            int a1 = 5;
            int b1 = 4;
            int c1 = 2;
            int d1 = a1 + b1 * c1;
            Console.WriteLine(d1);

            d1 = (a1 + b1) * c1;
            Console.WriteLine(d1);

            d1 = (a1 + b1) - 6 * c1 + (12 * 41) / 3 + 12;
            Console.WriteLine(d1); //no decimal or fractional

            //remainder 

            int a2 = 7;
            int b2 = 4;
            int c2 = 3;
            int d2 = (a2 + b2) / c2;
            Console.WriteLine("is: " + d2);
            int e2 = (a2 + b2) % c2;
            Console.WriteLine($"quotient: {d2}");
            Console.WriteLine($"remainder: {e2}");

            //int limit

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int value = max + 3; //overflow 
            Console.WriteLine($"An example of overflow: {value}");

            //float (single-precision number)

            //double (double-precision number)

            double a3 = 5;
            double b3 = 4;
            double c3 = 2;
            double d3 = (a3 + b3) / c3;
            Console.WriteLine(d3);

            double a4 = 19;
            double b4 = 23;
            double c4 = 8;
            double d4 = (a4 + b4) / c4;
            Console.WriteLine(d4);

            //double limit

            double max1 = double.MaxValue;
            double min1 = double.MinValue;
            Console.WriteLine($"The range of double is {min1} to {max1}"); //significand + exponent

            //rounding

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            double a5 = 5.55;
            double b5 = 100;
            double c5 = 200;
            double d5 = (a5 + b5) - 6 * c5 + (12 * 41) / 3 + 1200;
            Console.WriteLine(d5); //no decimal or fractional

            //decimal

            decimal a6 = 1;
            decimal b6 = a6 / 3;
            Console.WriteLine(b6);

            double a7 = 1.01;
            double b7 = 3.01;
            Console.WriteLine(a7 / b7);
            decimal c7 = 1.01M;
            decimal d7 = 3.01M;
            Console.WriteLine(c7 / d7);

            //decimal limit

            decimal min2 = decimal.MinValue;
            decimal max2 = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min2} to {max2}");

            //find area of a circle
            double r = 2.50;
            Console.WriteLine(Math.PI * r * r);

            //if condition 

            int a8 = 5;
            int b8 = 6;
            if (a8 + b8 > 10)
                Console.WriteLine("The answer is greater than 10.");

            int a9 = 5;
            int b9 = 3;
            if (a9 + b9 > 10)
                Console.WriteLine("The answer is greater than 10.");

            //if else condition 

            int a10 = 5;
            int b10 = 3;
            if (a10 + b10 > 10)
                Console.WriteLine("Another answer is greater than 10");
            else
                Console.WriteLine("Another answer is not greater than 10");

            //if else conditions must have { } braces with multiple statements

            int a11 = 5;
            int b11 = 3;
            int c11 = 4;
            if ((a11 + b11 + c11 > 10) && (a11 == b11)) //or use ||
            {
                Console.WriteLine("This answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("This answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            //while loop

            int counter = 0;
            while (counter < 10) //infinite loop if condition never false
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++; //increment 
            }
            Console.WriteLine("Hello World! The counter has ended");

            //do while loop

            int counter1 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter1}");
                counter1++;
            } while (counter1 < 10);
            Console.WriteLine("Hello World! The counter has ended");

            //for loop

            for (int counter2 = 0; counter2 < 10; counter2++) //initializer + condition + iterator
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
            }
            Console.WriteLine("Hello World! The counter has ended");



        }
    }
}
