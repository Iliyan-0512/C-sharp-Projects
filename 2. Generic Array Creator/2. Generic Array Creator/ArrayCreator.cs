public static class ArrayCreator
{
    // Generic method to create an array of type T
    public static T[] Create<T>(int length, T item)
    {
        T[] array = new T[length];  // Create an array of the specified length
        for (int i = 0; i < length; i++)
        {
            array[i] = item;  // Set each element to the provided item
        }
        return array;
    }
}