

namespace TutorialConsoleApp
{
    class TutorialConsoleApp
    {
        private static void Main()
        {
            PrintToConsole();
            VariablesAndDataTypes();
            MathOperations();
            TryExceptOperations();
            NumberConversion();
            ComparisonOperators();
            LogicalOperators();
            ConditionalStatements();
            SwitchStatements();
            ForLoopStatements();
            WhileLoopStatements();
            DoWhileStatements();
        }

        static void PrintToConsole()
        {
            Console.WriteLine("Hello World!");
        }

        static void VariablesAndDataTypes()
        {
            Console.WriteLine("Variables and data types in C#");
            // Number data types in C#
            const int age = 16;
            Console.WriteLine("this is a integer in C#: " + age);
            const float temperature = 20.4f;
            Console.WriteLine("This is a float in C#: " + temperature);
            const double number = 20.4;
            Console.WriteLine("This is a double in C#: " + number);
            const decimal stockPrice = 10.5m;
            Console.WriteLine("This is a decimal in C#: " + stockPrice);

            // Other datatypes in C#
            const char grade = 'A'; // To define char we use single quotes.
            Console.WriteLine("This is a char in C#: " + grade);
            const string name = "John";
            Console.WriteLine("This is a string in C# " + name);
            const bool boolean = true;
            Console.WriteLine("This is a boolean in C#: " + boolean);
            const string fstringstyle = "Héctor";
            Console.WriteLine(
                $"This is a string in C#: {fstringstyle}. This is done with $in from of the string variable.");

            int quantity; //This way we can define variables that are empty and ready to use later.
            string product; // constants needs initializers.

            // here we can define for later.
            quantity = 10;
            product = "boxers";
            Console.WriteLine($"This is a variable with a value assigned later: {quantity}");
            Console.WriteLine($"This is a variable with a value assigned later: {product}");

            // Lets talk about constants in .NET

            const decimal pyDecimal = 3.14m;
            Console.WriteLine($"This number is a constant, it cannot be changed: {pyDecimal}");

        }

        static void MathOperations()
        {
            Console.WriteLine("This is a math operations in C#");
            int number1 = 10;
            int number2 = 20;
            int sum = number1 + number2;
            Console.WriteLine($"The sum of numbers is {sum}");
            int difference = number1 - number2;
            Console.WriteLine($"The difference of numbers is {difference}");
            int multiply = number1 * number2;
            Console.WriteLine($"The multiply of numbers is {multiply}");
            int divide = number2 / number1;
            Console.WriteLine($"The divide of numbers is {divide}");
            int modulo = number1 % number2;
            Console.WriteLine($"The modulo of numbers is {modulo}");

        }

        static void TryExceptOperations()
        {
            int zero = 0;
            int one = 1;
            Console.WriteLine("This is a try except operations in C#");
            try
            {
                int result = one / zero;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error catching: {ex.Message}");
            }
        }

        static void NumberConversion()
        {
            Console.WriteLine("This is a number conversion in C#");
            int num3 = 105;
            double num3asDouble = (double)num3;
            Console.WriteLine($"The number {num3} is now {num3asDouble}");
        }

        static void ComparisonOperators()
        {
            Console.WriteLine("This is a comparison operators in C#");
            int equal_number1 = 1;
            int equal_number2 = 2;
            bool isEqual = (equal_number1 == equal_number2);
            Console.WriteLine($"The number {equal_number1} is equal to {equal_number2}? the answer is {isEqual}");
            bool isNotEqual = (equal_number1 != equal_number2);
            Console.WriteLine(
                $"The number {equal_number1} is not equal to {equal_number2}? the answer is {isNotEqual}");
            bool isLessThan = (equal_number1 < equal_number2);
            Console.WriteLine($"The number {equal_number1} is less than {equal_number2}? the answer is {isLessThan}");
            bool isGreaterThan = (equal_number1 > equal_number2);
            Console.WriteLine(
                $"The number {equal_number1} is greater than {equal_number2}? the answer is {isGreaterThan}");
            bool isLessThanOrEqualTo = (equal_number1 <= equal_number2);
            Console.WriteLine(
                $"$The number {equal_number1} is less than or equal to {equal_number2}? the answer is {isLessThanOrEqualTo} ");
            bool isGreaterThanOrEqualTo = (equal_number1 >= equal_number2);
            Console.WriteLine(
                $"The number {equal_number1} is greater or equal to {equal_number2}? the answer is {isGreaterThanOrEqualTo}");

        }

        static void LogicalOperators()
        {
            Console.WriteLine("This is a logical operators in C#");


            bool x = true;
            bool y = false;
            bool endresult = (x && y);
            Console.WriteLine($"The operator && which is and in python: {endresult}");
            bool orResult = (x || y);
            Console.WriteLine($"The operator || which is or in python: {orResult}");
            bool NotResult1 = (x && !y);
            Console.WriteLine($"The operator && !y which is not: {NotResult1}");
            bool NotResult2 = !x;
            Console.WriteLine($"To negate the x which iss !x: {NotResult2}");
        }

        static void ConditionalStatements()
        {
            Console.WriteLine("These are conditional statements in C#");
            Console.WriteLine("Let`s start with the if/else statements");
            int age = 25;
            Console.WriteLine($"The age is {age}");
            if (age < 18)
            {
                Console.WriteLine("The condition is below 18");
            }
            else if (age >= 18 && age <= 56)
            {
                Console.WriteLine("The condition is above 56");
            }
            else
            {
                Console.WriteLine("The condition is above 18");
            }

        }

        static void SwitchStatements()
        {
            Console.WriteLine("This is a switch statements in C#");
            int day = 3;
            string DayName;

            switch (day)
            {
                case 1:
                    DayName = "Monday";
                    break;
                case 2:
                    DayName = "Tuesday";
                    break;
                case 3:
                    DayName = "Wednesday";
                    break;
                case 4:
                    DayName = "Thursday";
                    break;
                case 5:
                    DayName = "Friday";
                    break;
                default:
                    DayName = "Invalid day";
                    break;

            }

            Console.WriteLine(
                $"As the day is an int with the number {day}, the switch goes to the case 3, which results in {DayName}");

        }

        static void ForLoopStatements()
        {
            Console.WriteLine("This is a for loop statements in C#");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"For loop number is {i}");
            }
        }

        static void WhileLoopStatements()
        {
            Console.WriteLine("This is a while loop statements in C#");
            int count = 0;

            while (count < 10)
            {
                Console.WriteLine($" While loop number is {count}");
                count++;
            }
        }

        static void DoWhileStatements()
        {
            Console.WriteLine("This is a while statements in C#");
            int count = 0;
        }
    }
}

