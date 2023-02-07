namespace HomeWork3;
class Program
{
    static void Main(string[] args)
    {
//Q1A
        
        Console.WriteLine("Input an integer:");
        int n = Convert.ToInt32(Console.ReadLine());
        bool isprime = true;
       
        if (n<=1)
        {
            isprime = false;
        }
        
        else
        {
            for (int i = 2; i <= n-1; i++)
               
                {
                
                    if (n % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
        }

        if (isprime)
        {
            Console.WriteLine("N is prime");
        }
            else
        {
            Console.WriteLine("N is non-prime");
        }
//Q2A
{
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int row = 0; row < N; row++) {
            for (int col = 0; col < N; col++){
                Console.Write('#');  
            }
            Console.WriteLine("");
        }              
}
//Q3A
{
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int row = 0; row < N; row++) {
            for (int col = 0; col < N; col++){
                if (row>=col){ 
                  Console.Write('*');    
                }
            }
            Console.WriteLine("");
        }              
}

}              

    }





