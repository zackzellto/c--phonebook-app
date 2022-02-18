using System;
namespace phone_book_tutorial
{
    public class Contact
    {
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }
public string Name { get; set; }
        public string Number { get; set; }
    }
}
