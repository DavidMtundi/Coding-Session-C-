

namespace TutorsEquity
{
    class noprinciple
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my application");

            person user = new person();

            Console.WriteLine("Enter your national id");
            user.NationalId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your first name :");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            user.LastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(user.NationalId.ToString()))
            {
                Console.WriteLine("Please enter the correct nationalid");
                user.NationalId = int.Parse(Console.ReadLine());

            }
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("Please enter the correct first name");
                user.FirstName = Console.ReadLine();

            }
            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("please enter the correct last name:");
                user.LastName = Console.ReadLine();
            }
            Console.WriteLine($"Your first name is {user.FirstName}, national id is {user.NationalId.ToString()}, last name is {user.LastName}. Thanks for your valuable input");
        }


        //read data
    }
}
