
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
            ForeachLoopStatement();
            ArraysDataTypes();
            Collections();
            Methods();
            Classes();
            ExceptionHandling();
            Console.WriteLine("\nPress any key to exit..."); 
            Console.ReadKey(); 
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

        static void ForeachLoopStatement()
        {
            Console.WriteLine("This is a foreach statements in C#");
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 10 ];

            foreach (int number in numbers)
            {
                Console.WriteLine($" Foreach number is {number}");
            }
        }

        static void ArraysDataTypes()
        {
            Console.WriteLine("Arrays Data Types");
            string[] names = new string[3];
            names[0] = "John";
            names[1] = "Doe";
            names[2] = "Jane";
            Console.WriteLine($"THe lenght of the list is {names.Length}");
            Console.WriteLine($"The array can be indexed, for example {names[0]} and {names[1]} are index 0 and 1.");
        }

        static void Collections()
        {
            Console.WriteLine("Collections: Complex Data Types in C#");
            List<string> names = [];
            names.Add("John");
            names.Add("Doe");
            names.Add("Jane");
            Console.WriteLine($"THe lenght of the list is {names.Count}");
            Console.WriteLine($"The indexing works as well, as inddex 1 is {names[1]}");
            Console.WriteLine($"Because we added 3 items to the list, this is its form\n {names}");
            names.Add("John");
            Console.WriteLine($"List can contain duplicates, like here:\n{names}");
            Console.WriteLine("abd this is an iteration of the list using foreach:");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Now letś go with the hashsets.");
            HashSet<float> hashset = [1,1,1,1,];
            hashset.Add(1.2f);
            hashset.Add(1.3f);
            hashset.Add(1.4f);
            hashset.Add(1.5f);
            
            foreach (float f in hashset)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("Now let's go with the dictionaries.");
            Dictionary<string, int> ages = new Dictionary<string, int>();
            string[] agesArray = {"John", "Doe", "Jane"};
            int[] agesArray2 = { 1, 2, 3,};
            foreach ((string k, int v) in Enumerable.Zip(agesArray, agesArray2))
            {
                ages[k] = v;
                Console.WriteLine($"The keys and values are: {k} : {ages[k]}");
                
                
            }

            if (ages.ContainsKey("Doe"))
            {
                Console.WriteLine($" The key  is present.");
            }
            else
            {
                Console.WriteLine($"The key doesn't exist. This are the keys:");
                foreach (string k in ages.Keys)
                {
                    Console.WriteLine(k);
                }
            }
            Console.WriteLine("Now let's go with the queues.");
            Console.WriteLine("Queues are first in  and first out structures");
            Console.WriteLine("If I add anything or remove it from the queue, it will be always the first element.");
            Queue<string> myQueueu = new Queue<string>();
            myQueueu.Enqueue("First");
            myQueueu.Enqueue("Second");
            myQueueu.Enqueue("Third");

            while (myQueueu.Count > 0)
            {
                string item = myQueueu.Dequeue();
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Now let's go with the Stacks.");
            Console.WriteLine("Stacks are last in and first out estructure.");
            Stack<string> myStacku = new Stack<string>();
            
            myStacku.Push("First");
            myStacku.Push("Second");
            myStacku.Push("Third");

            while (myStacku.Count > 0)
            {
                string item = myStacku.Pop();
                Console.WriteLine(item);
            }
            

        }
        static void Methods()
        {
            Console.WriteLine("Methods from C#. The represent the behaviour of the aplication. Let's invoke a method!");
            SayHello();
            SayHelloPublic();
            int a = 23;
            int b = 22;
            int z = Add(a, b);
            Console.WriteLine($"This is the result of calling a method inside a method, the add method returns {z}");    
        }

        private static void SayHello()
        {
            Console.WriteLine("Hello World! THis is a private method.");
        }
        public static void SayHelloPublic()
        {
            Console.WriteLine("Hello World! THis is a public method.");
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static void Classes()
        {
            Console.WriteLine("Classes for C#");
            Person Peter = new Person("John", "Doe", 13);
            string firstName = Peter.FirstName;
            string lastName = Peter.LastName;
            Console.WriteLine($"FirstName: {firstName}");
            Console.WriteLine($"LastName: {lastName}");
            Console.WriteLine($"Age: {Peter.Age}");
            Console.WriteLine($"{Peter.Greeting(name: "Héctor")}");
        }

        static void ExceptionHandling()
        {
            Console.WriteLine("ExceptionHandling in C#");
            int a = 10;
            int b = 0;
            try
            {
                int z = a /  b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            List<string> shapes =["square", "triangle", "circle"];
            try
            {
                Console.WriteLine(shapes[90]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message); // if the type of exception is not exact, it will crash the program. Usse exception

            }
            finally
            {
                Console.WriteLine("all code has been executed.");
            }
        }
    }

    public class Person
    {
        //Fields
        private string _firstName;
        private string _lastName;
        private int _age;
        //Constractors
        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }
        
        // Definir comportmiento, como set y get
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
            
        }
        public string LastName
        
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        //aalterrnative way to set propertiess
        
        public string Name {get; set;}// IN this case I do not need the constractor

        public string Greeting(string name)
        {
            return $"Hello, {name}!";
        }
    }
    
}

