string command =Console.ReadLine();
if (command=="Array")
{
    int[] number=Console.ReadLine().Split().Select(int.Parse).ToArray();
    int[] reverse = new int[number.Length];
    for (int i=number.Length-1;i>=0;i--)
    {
       
        reverse[number.Length - 1 - i] = number[i];
    }
    Console.WriteLine(string.Join(" ", reverse));
}
else if (command=="String")
{
    string text = Console.ReadLine();
    string reverse = "";
    for (int i = text.Length-1; i >= 0; i--)
    {
        reverse += text[i];
    }
    Console.WriteLine(reverse);
}