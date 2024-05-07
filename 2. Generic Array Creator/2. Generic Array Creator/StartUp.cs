namespace GenericArrayCreator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // Example usage of the ArrayCreator
            int[] intArray = ArrayCreator.Create(5, 10);
            string[] stringArray = ArrayCreator.Create(3, "hello");

            // Print arrays to verify
            Console.WriteLine(string.Join(", ", intArray));  // Should print: 10, 10, 10, 10, 10
            Console.WriteLine(string.Join(", ", stringArray)); // Should print: hello, hello, hello
        }
    }
}