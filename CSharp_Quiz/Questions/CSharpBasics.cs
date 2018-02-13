namespace SYMC.GLOBALIZATION.LOCALIZATION
{
    class CSharpBasic
    {
        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
            static void Main();
            {
            console.WriteLine("\nEnter the Width and Height of image :"); // Diplay Request
            var width = Console.ReadLine(); //Read Input from user
            var height = Console.ReadLine();    
            Console.WriteLine("\nImage is Landscape."); //Print image format
            }
    }
 }
    




        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>
        /// 
namespace SYMC.GLOBALIZATION.LOCALIZATION
{
    class CSharpBasic2
        {
        static void Main(string[] args);
        {
            int a, num, fact;
            Console.WriteLine("\nEnter a Number :");
             num = int.Parse(Console.ReadLine()); // get a number as an integer
             fact = num; // assigning fact to num
             for (i = num - 1; i >= 1; i--)  // loop to execute the process
             {
                fact = fact * i; // Factorial operation
             }
             Console.WriteLine("\nFactorial of Given Number is: "+fact); //Print Factorial
             Console.ReadLine();
        }
    }
}

        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>
        /// 

namespace SYMC.GLOBALIZATION.LOCALIZATION
{
    class CSharpBasic3
        {
        static void Main();
        {
        Console.WriteLine("/nEnter your name : ");
        String[] ar = Console.ReadLine();
        Array.Reverse(ar);
        String[] arnew = ar;
        Console.WriteLine("Reversed name is: ", +arnew);
        Console.ReadLine();
        }
    }
}

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        /// 



    }
}
