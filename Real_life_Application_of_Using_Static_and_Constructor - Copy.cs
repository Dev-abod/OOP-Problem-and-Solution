



    class clsPerson
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public clsPerson(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }

        public static clsPerson Find(int Id)
        {
            if (Id == 10)
                return new clsPerson(Id, "abdulla", 25);
            else
                return null;
        }

        public static clsPerson Find(string UserName, string Password)
        {
            if (UserName == "Abdullah" && Password == "1234")
                return new clsPerson(10, "abdulla", 25);
            else
                return null;
        }
    }



int main()
{
            clsPerson person1 = clsPerson.Find(10);

            if (person1 != null)
            {
                Console.WriteLine("Id = {0}", person1.Id);
                Console.WriteLine("Name = {0}", person1.Name);
                Console.WriteLine("Age = {0}", person1.Age);
            }
            else
            {
                Console.WriteLine("Could not find the person by the givin ID ");
            }


            clsPerson person2 = clsPerson.Find("Abdullah","12345");

            if (person2 != null)
            {
                Console.WriteLine("Id = {0}", person2.Id);
                Console.WriteLine("Name = {0}", person2.Name);
                Console.WriteLine("Age = {0}", person2.Age);
            }
            else
            {
                Console.WriteLine("Could not find the person by the givin ID ");
            }

}
