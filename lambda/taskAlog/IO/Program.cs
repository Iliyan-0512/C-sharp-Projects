string  command =Console.ReadLine();

if (command == "Array")
{
    
    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int[] reverse = new int[arr.Length]; 

    
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        reverse[arr.Length - 1 - i] = arr[i]; 
    }

   
    Console.WriteLine(string.Join(" ", reverse));
}
else if (command =="String")
{
    string original = Console.ReadLine();
    string reversed = "";

    for (int i = original.Length - 1; i >= 0; i--)
    {
        reversed += original[i];
    }

    Console.WriteLine(reversed);
}
