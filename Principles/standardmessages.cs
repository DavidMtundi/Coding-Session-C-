namespace TutorsEquity.Principles
{
    public class standardmessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my Application");

        }
        public static void ErrorMessage(String element)
        {
            Console.WriteLine($"The {element} entered is incorrect, please try a new one");
        }
        public static void EndApplication()
        {
            Console.ReadLine();

        }
        public static void DisplayPerson(person user)
        {
            Console.WriteLine($"Your first name is {user.FirstName}, national id is {user.NationalId.ToString()}, last name is {user.LastName}. Thanks for your valuable input");

        }
    }
}
