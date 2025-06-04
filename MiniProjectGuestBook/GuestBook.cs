using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MiniProjectGuestBook
{
    public class GuestBook
    {
        Dictionary<string, int> GuestBookDetails { get; set; } = new Dictionary<string, int>();

        // first method propmpts user for name and party size then stores them
        public void RegisterParty()
        {
            Console.Write("Please enter your full name: ");
            string name = Console.ReadLine();
            name = Regex.Replace(name, "[0-9]", "");

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("That did not work please enter your first and last name: ");
                name = Console.ReadLine();
                name = Regex.Replace(name, "[0-9]", "");
            }

            Console.Write("Great now please enter the size of your party, you must enter a size greater than zero: ");
            string partySizeText = Console.ReadLine();
            bool isValidSize = int.TryParse(partySizeText, out int partySize);

            while (!isValidSize || partySize < 1)
            {
                Console.Write("That didn't work please enter a valid party size: ");
                partySizeText = Console.ReadLine();
            }

            GuestBookDetails.Add(name, partySize);
        }

        // second method gets the total party size from the guest book
        private int calculateTotalPartySize()
        {
            int output = 0;

            if (GuestBookDetails.Count > 0) 
            {
                foreach (var party in GuestBookDetails)
                {
                    output += party.Value;
                }
            }
            return output;
        }

        //third method prints the guest list of names and a total party count
        public void Print()
        {
            int totalPartyCount = calculateTotalPartySize();
            if (GuestBookDetails.Count > 0)
            {
                foreach (var party in GuestBookDetails)
                {
                    Console.WriteLine($"Party for {party.Key} size {party.Value}");
                }
                    Console.WriteLine($"Total party guest count: {totalPartyCount}");

            } else
            {
                Console.WriteLine("No registered Parties available");
            }
        }
    }
}
