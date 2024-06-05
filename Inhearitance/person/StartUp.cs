namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Person person;
            if(age<0)
            {
                return;
            }
            if(age<=15)
            {
                person = new Child(age, name);
            }
            else
            {
                person = new Person(age, name);
            }
            Child child = new Child(age,name);
            Console.WriteLine(person);

        }
    }
}
