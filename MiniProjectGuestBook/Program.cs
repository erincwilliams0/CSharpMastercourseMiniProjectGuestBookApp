namespace MiniProjectGuestBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuestBook guestBook = new GuestBook();
            int actionCode = 0;

            while (actionCode != 3)
            {
                Console.WriteLine("Please read the following actions closely");
                Console.WriteLine("1. Register a party");
                Console.WriteLine("2. Print a list of guest names and total party count");
                Console.WriteLine("3. Exit the application");
                Console.WriteLine("Please select an action number: ");
                string actionCodeText = Console.ReadLine();
                bool isValidCode = int.TryParse(actionCodeText, out actionCode);

                if (!isValidCode) 
                {
                    Console.WriteLine("\n that was not a valid code please try again");
                    return;
                }




                Console.WriteLine("\n");
            }

            guestBook.Print();

            Console.WriteLine();
        }
    }
}
