using System;

namespace phone_book_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Operation");
            Console.WriteLine("1) Add Contact");
            Console.WriteLine("2) Display contact by number");
            Console.WriteLine("3) View all contacts");
            Console.WriteLine("4 Search for contacts for a given name");
            Console.WriteLine("Press'x' to exit program");

            var userInput = Console.ReadLine();

            var phoneBook = new Phonebook();


            while (true)
            {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Contact name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Contact number:");
                    var number = Console.ReadLine();

                    var newContact = new Contact(name, number);
                    phoneBook.AddContact(newContact);
                    break;
                case "2":
                        Console.WriteLine("Contact number to search:");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                    break;
                case "3":

                        phoneBook.DisplayAllContacts();
                    break;
                case "4":
                        Console.WriteLine("Name search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPhrase);
                    break;
                    case "x":
                        return;
                default:
                    Console.WriteLine("Select valid operation");
                    break;
                     
            }

                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();
            }

        }
    }
}
