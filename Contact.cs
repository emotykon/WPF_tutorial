using System;

namespace ContactManager
{
    public enum Gender { Male, Female }

    public class Contact
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public Gender Gender { get; set; }

        public Contact() { }
    }
}