
internal class Program
{
    private static void Main(string[] args)
    {
        int SumForSpend=int.Parse(Console.ReadLine());
        Dictionary<int,int> nominal=new Dictionary<int,int>();
       
        nominal.Add(100, 10);
        nominal.Add(50, 34);
        nominal.Add(20, 14);
        nominal.Add(10, 44);
       
    }
    public void Menu(int choose,double totalSumWIt)
    {
        if (choose==1)
        {
            Withdraw(totalSumWIt);
        }
    }
    public double Withdraw(double totalSumWIt)
    {
        return  
    }
}