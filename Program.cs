internal class Program
{
    static void searchInMatrix(int[,] arr, int x)
    {
        var found = false;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == x|| arr[i, j] == x )
                {
                  found=true;
                
                }
            }
        }
        if(found)
        {
            Console.WriteLine("will not take number\r\n");
        }
        else
        {
            Console.WriteLine("will take number\r\n");
        }
        return;
    }
    static void arrayInput(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = int.Parse(input[j]);
            }
        }
    }
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[,] arr = new int[n, m];
        arrayInput(arr);
        int x = Convert.ToInt32(Console.ReadLine());
        searchInMatrix(arr, x);


    }
}
