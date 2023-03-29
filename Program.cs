namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { firstName = "Sagar",lastName = "Shahu",city = "Nagpur",state = "Maharashtra", zipcode = "440023",country = "India",phone = "55455665",email = "shahu@gmail.com" });
            people.Add(new Person { firstName = "shahu", lastName = "Shahu", city = "Nagpur", state = "Maharashtra", zipcode = "440023", country = "India", phone = "5545556", email = "shu@gmail.com" });
            people.Add(new Person { firstName = "vicky", lastName = "Shahu", city = "Nagpur", state = "Maharashtra", zipcode = "440023", country = "India", phone = "55455665", email = "shahu@gmail.com" });


            Person newEntry1 = new Person { firstName = "Sagar", lastName = "Shahu", city = "Nagpur", state = "Maharashtra", zipcode = "440023", country = "India", phone = "55455665", email = "shahu@gmail.com" };
            if (people.Any(e => e.city == newEntry1.city || e.state == newEntry1.state))
            {
                Console.WriteLine("Contact" +newEntry1.phone );
            }

        }

    }
}