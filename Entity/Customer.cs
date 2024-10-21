namespace Entity
{
    public class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string address;

        public Customer() { }

        public Customer (int customerId, string firstName, string lastName, string email, string phoneNumber, string address)
        {
            this.customerId = customerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void PrintCustomerInfo()
        {
            Console.WriteLine($"Customer ID: {customerId}");
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
