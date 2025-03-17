using task_3_27;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Pet> pets = new List<Pet>();
        Console.WriteLine("Enter inf for dog");
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        Pet dog = new Pet(name,age,type);
        pets.Add(dog);
        
        Console.WriteLine("Enter inf for cat");
        string nameC = Console.ReadLine();
        int ageC = int.Parse(Console.ReadLine());
        string typeC = Console.ReadLine();
        Pet cat = new Pet(nameC, ageC, typeC);
        pets.Add(cat);
        
        Console.WriteLine("Enter inf for snake");
        string nameSnake = Console.ReadLine();
        int ageS = int.Parse(Console.ReadLine());
        string typeS = Console.ReadLine();
        Pet snake = new Pet(nameSnake, ageS, typeS);
        pets.Add(snake);

        pets.OrderBy(pets => pets.Age).ToList();
        foreach (Pet item in pets)
        {
            Console.WriteLine(item.ToString());
        }


    }
}