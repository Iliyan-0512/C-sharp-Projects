string messeges=Console.ReadLine();
while (messeges != "Reveal")
{
    string[] command = messeges.Split("|");
    if (command[0]== "InsertSpace:")
    {
        int tokensOne=int.Parse(command[1]);
        messeges.Insert(tokensOne,messeges);
        
    }
    else if (command[0]== "Reverse:")
    {
        string substring = command[1];
        if (substring.Contains(messeges))
        {

        }

    }
    else if (command[0]== "ChangeAll:")
    {
        string substring = command[1];
        int replacement = int.Parse(command[2]);
        messeges.Insert(replacement,substring);
        Console.WriteLine(messeges);
    }
}
