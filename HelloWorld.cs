using System;

namespace HelloCSharp
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // This is a simple C# program that prints a greeting message to the console.
            Console.WriteLine("Hello, World! Greetings from C#!");

            string myString = "This is a string in C# Developer";
            myString += " and it is mutable.";
            Console.WriteLine(myString);

            int myInt = 42;
            Console.WriteLine("The value of myInt is: " + myInt);
            myInt += 10;
            Console.WriteLine("After adding 10, myInt is: " + myInt);
            Console.WriteLine("The value of myInt now in execution is: {0}", (myInt - 10) );

            float myFloat = 3.14f;
            Console.WriteLine("The value of myFloat is: " + myFloat);
            Console.WriteLine("Remember a float number is shorter than a double number");

            double myDouble = 3.14159;
            Console.WriteLine("The value of myDouble is: " + myDouble);

            Console.WriteLine("The total is {0}", (myDouble + myFloat + myInt) );

            dynamic myDynamic = "This is a dynamic variable";
            Console.WriteLine(myDynamic);
            myDynamic = 100;
            Console.WriteLine(myDynamic);
            myDynamic = 3.14;
            Console.WriteLine(myDynamic);
            myDynamic = true;
            Console.WriteLine(myDynamic);
            myDynamic = new { Name = "John", Age = 30 };
            Console.WriteLine("Dynamic object: Name = {0}, Age = {1}", myDynamic.Name, myDynamic.Age);

            // Inferred types
            var myVarString2 = "This is a string with inferred type";
            var myVarInt2 = 100;
            var myVarFloat2 = 3.14f;
            var myVarDouble2 = 3.14159;
            var myVarBool2 = true;

            Console.WriteLine("Inferred types:");
            Console.WriteLine(myVarString2, myVarInt2, myVarFloat2, myVarDouble2, myVarBool2);

            bool myBool = true;
            Console.WriteLine("The value of myBool is: " + myBool);
            myBool = false;
            Console.WriteLine("The value of myBool is now: " + myBool);
            Console.WriteLine($"The value of myBool is now: {myBool} and myInt is now: {myInt}");

            const string MyConst = "This is a constant string";
            Console.WriteLine(MyConst);

            // Demonstrating a simple list
            var myList = new System.Collections.Generic.List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("List elements:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            myList.Add(6);
            Console.WriteLine("After adding 6:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            myList.Remove(3);
            Console.WriteLine("After removing 3:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            // Demonstrating a simple dictionary
            // Dictionary is a collection of key-value pairs.
            // Dictionary is a generic collection, so we can specify the type of keys and values it will contain.
            // Dictionary is a good choice when we need to store key-value pairs
            // and need to look up values by keys. Dictionary is faster than List for looking up values
            // because it uses a hash table for storage.
            var myDictionary = new System.Collections.Generic.Dictionary<string, int>
            {
                { "One", 1 },
                { "Two", 2 },
                { "Three", 3 }
            };

            Console.WriteLine("Value in my Dictionary: " + myDictionary["Two"]);
            myDictionary["Two"] = 22;
            Console.WriteLine("Updated value in my Dictionary: " + myDictionary["Two"]);
            myDictionary.Add("Four", 4);
            Console.WriteLine("Added new key-value pair to my Dictionary: Four = " + myDictionary["Four"]);
            myDictionary.Remove("One");
            Console.WriteLine("After removing key 'One':");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            /*  Demostrating a simple Set
                HashSet is a collection that contains no duplicate elements
                and is not sorted. It is implemented as a hash table.
                HashSet is a generic collection, so we can specify the type of elements it will contain.
                HashSet is a good choice when we need to store unique elements
                and do not care about the order of elements.
                HashSet is faster than List for checking if an element exists
                because it uses a hash table for storage. 
            */

            var mySet = new System.Collections.Generic.HashSet<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Set elements:");
            foreach (var item in mySet)
            {
                Console.WriteLine(item);
            }

            // Demonstrating a simple tuple
            // Tuple is a data structure that can hold a fixed number of elements
            // of different types. It is useful for returning multiple values from a method.
            // Tuple is immutable, meaning that once it is created, its elements cannot be changed.
            // Tuple is a good choice when we need to group related values together
            // and do not need to modify them.
            // Tuple is implemented as a class in the System namespace.
            var myTuple = Tuple.Create(1, "Hello", 3.14);
            Console.WriteLine($"Tuple values: Item1 = {myTuple.Item1}, Item2 = {myTuple.Item2}, Item3 = {myTuple.Item3}");

            // Demonstrating a simple array
            // Array is a collection of elements of the same type.
            // Array is a fixed-size collection, meaning that once it is created,
            // its size cannot be changed. Array is a good choice when we need to store
            // a fixed number of elements and do not need to modify them.
            int[] myArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array elements:");

            // Demonstrating a simple foreach loop
            foreach (int num in myArray)
            {
                Console.WriteLine(num);
            }

            // Demonstrating a simple for loop
            Console.WriteLine("For loop:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            // Demonstrating a simple while loop
            Console.WriteLine("While loop:");
            int j = 0;
            while (j < myArray.Length)
            {
                Console.WriteLine(myArray[j]);
                j++;
            }
            // Demonstrating a simple do-while loop

            Console.WriteLine("Do-while loop:");
            int k = 0;
            do
            {
                Console.WriteLine(myArray[k]);
                k++;
            } while (k < myArray.Length);

            // Demonstrating a simple conditional statement
            if (myInt > 50)
            {
                Console.WriteLine("myInt is greater than 50");
            }
            else
            {
                Console.WriteLine("myInt is not greater than 50");
            }

            // Demonstrating a simple switch statement
            switch (myInt)
            {
                case 42:
                    Console.WriteLine("myInt is 42");
                    break;
                case 50:
                    Console.WriteLine("myInt is 50");
                    break;
                default:
                    Console.WriteLine("myInt is neither 42 nor 50");
                    break;
            }

            // Demonstrating a simple try-catch block
            try
            {
                int result = myInt / 0; // This will cause a divide by zero exception
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught an exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This block always executes");
            }

            MyFunction();
            Console.WriteLine("The result of Add(1, 1200) is: " + Add(1, 1200));

            // Demonstrating a simple lambda expression
            // Lambda expression is a concise way to represent an anonymous function
            // Lambda expression is a function that can be used as a delegate or an expression tree.
            // Lambda expression is defined using the => operator.
            // Lambda expression can take any number of parameters and can return a value.
            // Lambda expression is a good choice when we need to define a short function
            // that is used only once and does not need a name.
            // Lambda expression is often used in LINQ queries and event handlers.
            Func<int, int, int> addFunc = (x, y) => x + y;
            Console.WriteLine("Lambda expression result: " + addFunc(5, 10));

            var myClass = new MyClass("Hello");
            Console.WriteLine(myClass.MyMethod());
            myClass.MyField = "Developer";
            Console.WriteLine("myField value: " + myClass.MyField);
            Console.WriteLine(myClass.MyMethod());
        }
    
    //Demonstrating a simple function
    static void MyFunction()
        {
            Console.WriteLine("This is a simple function");
        }

    // Demostrating a function with parameters and return value
    static int Add(int a, int b)
        {
            return a + b;
        }

    // Demonstrating a simple class
    class MyClass
        {
            // Properties
            // Properties are used to encapsulate the fields of a class.
            // Properties are used to provide a way to access the fields of a class
            // without exposing the fields directly.
            // Properties are defined using the get and set accessors.
            public string MyField { get; set; }
            
            // Constructor
            public MyClass(string myField = "Default value")
            {
                MyField = myField;
            }
            
            // Method
            // Method is a function that is defined inside a class.
            // Method is used to define the behavior of a class.
            // Method can take parameters and can return a value.
            // Method can be overloaded, meaning that we can define multiple methods
            // with the same name but different parameters.
            // Method can be static or instance method.
            // Static method is a method that belongs to the class itself
            // and can be called without creating an instance of the class.
            // Instance method is a method that belongs to an instance of the class
            // and can be called only after creating an instance of the class.
            // Method can be virtual or abstract.
            // Virtual method is a method that can be overridden in a derived class.
            // Abstract method is a method that must be implemented in a derived class.
            // Method can be private, protected, or public.
            // Private method is a method that can be accessed only within the class.
            // Protected method is a method that can be accessed only within the class
            // and its derived classes. Public method is a method that can be accessed
            // from outside the class.
            // Method can be async or synchronous.
            // Async method is a method that can be executed asynchronously
            // and can be awaited. Synchronous method is a method that is executed  
            public string MyMethod()
            {
                return "This is a method in MyClass, the first field is: " + MyField;
            }
        }
    // Demonstrating a simple struct
    struct MyStruct
        {
            public int MyField;
            public string MyMethod()
            {
                return "This is a method in MyStruct";
            }
        }
    // Demonstrating a simple enum
    enum MyEnum
        {
            Value1,
            Value2,
            Value3
        }
    // Demonstrating a simple interface
    interface IMyInterface
        {
            void MyMethod();
        }
    // Demonstrating a simple abstract class
    abstract class MyAbstractClass
        {
            public abstract void MyMethod();
        }
    // Demonstrating a simple derived class
    class MyDerivedClass : MyAbstractClass
        {
            public override void MyMethod()
            {
                Console.WriteLine("This is a method in MyDerivedClass");
            }
        }
    // Demonstrating a simple base class
    class MyBaseClass
        {
            public virtual void MyMethod()
            {
                Console.WriteLine("This is a method in MyBaseClass");
            }
        }
    }
}