using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input for Q1
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int largest = GetLargestNumber(num1, num2); //Call the logic for Q1 using the user imput from above.

            Console.WriteLine("The largest number is: " + largest);
            
            //Get user input for Q2
            Console.WriteLine("Enter a number for N:");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 'left' or 'right' for shape:");
            string shape = Console.ReadLine();
            triangle(N, shape); //Call the logic for Q2 using the user imput from above.
        
        }
        //Q1 Logic
        static int GetLargestNumber(int a, int b)
        {
        
            return a > b ? a : b;
        }
        //Q2 Logic
        static void triangle(int n, string shape)
        {
            int i,j,k; 
            if(shape=="left")
            {
    
                for (i=1;i<=n;i++)
                {
                    for(j=1;j<=i;j++)
                    Console.Write("*"); 
                    Console.Write("\n"); 
                    
                }
            }
            else if(shape=="right")
            {
            
                for (i = 1; i <= n; i++)  
                    {  
                    
                        for (j = 1; j <= n-i; j++)  
                        {Console.Write(" ");}  
                        for (k = 1; k <= i; k++)  
                        {  Console.Write("*");}  
                        Console.WriteLine("");  
                    }  
                Console.ReadLine();
            }
        }

    }
}