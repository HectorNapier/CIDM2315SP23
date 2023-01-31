namespace HomeWork2;
class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Enter a letter grade (A, B, C, D, F):");
            string letterGrade = Console.ReadLine().ToUpper();
           

           //Q1

            if(string.Equals(letterGrade, "A")) {
                    Console.WriteLine("GPA: 4.0");
                    
            }
            else if(string.Equals(letterGrade, "B")) {
                    Console.WriteLine("GPA: 3.0");
            }
            else if(string.Equals(letterGrade, "C")) {
                    Console.WriteLine("GPA: 2.0");
            }
            else if(string.Equals(letterGrade, "D")) {
                    Console.WriteLine("GPA: 1.0");
            }
            else if(string.Equals(letterGrade, "F")) {
                    Console.WriteLine("GPA: 0.0");
            }
            else{
                Console.WriteLine("Wrong Letter Grade!");
            }

            //Q2
            {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int num3 = Convert.ToInt16(Console.ReadLine());

            int smallest = num1;
            if (num2 < smallest)
            {
                smallest = num2;
            }
            if (num3 < smallest)
            {
                smallest = num3;
            }

            Console.WriteLine("Smallest number: " + smallest);
            
        }
        //Bonus Question
         
         {
            Console.WriteLine("Enter a year:");
            int year = Convert.ToInt16(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
         }
     }
    }





