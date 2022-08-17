namespace Workshop1
{
     class TicTacToe

    {
       atic void UC_CASE(string[] args)
        {
        

            int employePresent = 5;

            Random random = new Random();

            int empCheck = random.Next(0,6);

            
              if  (employePresent == empCheck)

            Console.WriteLine("Employe is present");


            else
                Console.WriteLine("Employe is absent");
                 
               Console.ReadLine();

        {

        }
        

        
    }
    
}