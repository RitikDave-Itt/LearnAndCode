namespace EmailCarbonFootprint
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Email Id\n");
            string emailId = Console.ReadLine();
            Console.WriteLine("Enter Source of Email\n");
            string emailSource = Console.ReadLine();


            Console.WriteLine("Enter the size of Email\n");
            double sizeOfEmail = Convert.ToDouble(Console.ReadLine());

            bool isSpam;
            while (true)
            {
                try
                {
                    Console.Write("Enter 1 for true or 0 for false:\n ");
                    string input = Console.ReadLine();

                    int result = int.Parse(input);
                    if (result == 0 || result == 1)
                    {
                        isSpam = Convert.ToBoolean(result);
                        break;        
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 1 or 0.\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format.\n");
                }
                
            }

            Console.WriteLine($"emailId : {emailId}\n");
            Console.WriteLine($"source : {emailSource}\n");
            if (isSpam) {
                Console.WriteLine($"inbox  : 0\n");

            }
            else
            {
                Console.WriteLine($"inbox : {YearlyCarbonEmmisionUtills.CarbonEmmisionForEmailStorage(sizeOfEmail)}\n");

            }
            Console.WriteLine($"sent  : {YearlyCarbonEmmisionUtills.CarbonEmmisionForEmailTransmission(sizeOfEmail)}\n");
            if (!isSpam)
            {
                Console.WriteLine($"inbox  : 0\n");

            }
            else
            {
                Console.WriteLine($"inbox : {YearlyCarbonEmmisionUtills.CarbonEmmissionForSpamEmailStorage(sizeOfEmail)}\n");

            }






        }
    }
}
