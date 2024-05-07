int numberCommand = int.Parse(Console.ReadLine());
var registerNumber = new Dictionary<string, string>();

for (int i = 1; i <= numberCommand; i++)
{
    List<string> register = Console.ReadLine().Split().ToList();
    string registerAndUnregister = register[0];
   
    if (registerAndUnregister == "register")
    {
        string username = register[1];
        string licensePlateNumber = register[2];

        if (registerNumber.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: already registered with plate number " +
               $"{licensePlateNumber}");
            //Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
        }
        else
        {

            registerNumber[username] = licensePlateNumber;
            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
        }
    }
    else if (registerAndUnregister == "unregister")
    {
       string   username = register[1];
        if (!registerNumber.ContainsKey(username))
        {
            
            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {
            Console.WriteLine($"{username} unregistered successfully");
            registerNumber.Remove(username);
        }


    }

}
foreach (var item in registerNumber)
{
    Console.WriteLine($"{item.Key} => {item.Value}");
}




