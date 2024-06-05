using CustomRandomList;

var list=new RandomStringList();
list.Add("1");
list.Add("2");
list.Add("3");
list.Add("1");
list.Add("1");
for (int i = 0; i <10; i++)
{
    Console.WriteLine(list.GetRandomElement());
}
var myStack = new StackOfStrings();
Console.WriteLine(myStack.IsEmpty());
myStack.AddRange(list);
