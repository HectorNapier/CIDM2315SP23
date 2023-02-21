namespace HomeWork5;
class Program
{
    static void Main(string[] args)
    {
        //Q1 User Input
        Console.WriteLine("Enter number for a:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number for b:");
        int b = Convert.ToInt32(Console.ReadLine());

        int largest = Largest(a, b);
        Console.WriteLine("The largest number is: " + largest);

        //Q2 User input
        
        Console.Write("Enter First number: ");
   
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        
        int num4 = Convert.ToInt32(Console.ReadLine());

        int max1 = Q2(num1, num2);
        int max2 = Q2(num3, num4);
        int max = Q2(max1, max2);

        Console.WriteLine("The largest number is: " + max);

        //Q3 User Input (Create AN ACCT)
        createAccount();    

        static void createAccount() {
        Console.WriteLine("Please input your username:");
        string? username = Console.ReadLine();

        Console.WriteLine("Please input your password:");
        string? password = Console.ReadLine();

        Console.WriteLine("Please input your password again:");
        string? password_confirm = Console.ReadLine();

        Console.WriteLine("Please input your birth year:");
        int birthyear = Convert.ToInt32(Console.ReadLine());
     
        bool is_above_18 = checkAge(birthyear);
        if (is_above_18) {
            if (password == password_confirm) {
                Console.WriteLine("Account is created successfully");
            }
            else {
                Console.WriteLine("Wrong password");
            }
        }
        else {
            Console.WriteLine("Could not create an account");
        }
    }

        
    }
    //Q1 Logic
    static int Largest(int a, int b) {
        if(a>b){
            return a;
        }
        else{
            return b;
        }
        }
        //Q2 Logic
    static int Q2(int a, int b) {
        if (a > b) {
            return a;
        }
        else {
            return b;
        }
    }
    //Q3 Check Age

static bool checkAge(int birth_year) {
        int age = 2022 - birth_year;
        if (age >= 18) {
            return true;
        }
        else {
            return false;
        }

    }
    
}


