using System;
using System.Reflection;
namespace MyApp
{
    internal class HasASecret
    {
        static void Main(string[] args)
        {
            HasASecrets keeper=new HasASecrets();
            FieldInfo[] fields=keeper.GetType().GetFields( BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo field in  fields)
            {
                Console.WriteLine(field.GetValue(keeper));
            }
        }
    }
    class HasASecrets
    {
        private string secret = "xyzzy";
    }
}
