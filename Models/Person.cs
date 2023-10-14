
namespace Questionnarie2.Models
{
    internal class Person
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime Date { get; set; }

        public Person()
        {
            Name = null;
            Surname=null;
            Email = null;
            Phone = null;
            Date = DateTime.MinValue;

        }
        public Person(string name, string surname, string email, string phone, DateTime date)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Name }\n";
        }




    }
}
