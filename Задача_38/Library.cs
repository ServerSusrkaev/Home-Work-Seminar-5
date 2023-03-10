public  class Library
{
    public static void FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1 , 11);
            System.Console.Write(arr[i] + ", ");
        }
        return;
    }

}