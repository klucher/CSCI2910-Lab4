namespace CSCI2910_Lab4
{
    public class Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Address { get; init; }
        public string Phone { get; init; }

        public Person(string firstName, string lastName, string address, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
        }

        public override string ToString()
        {
            return
                //$"First Name:\t\t{FirstName}\n" +
                //$"Last Name:\t\t{LastName}\n" +
                //$"Address:\t\t{Address}\n" +
                //$"Phone:\t\t{Phone}";

                $"{FirstName} | {LastName} | {Address} | {Phone}";
        }
    }
}
