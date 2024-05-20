namespace lab_1;

class Program
{
    static void Main(string[] args)
    {
        int[,,] arr = new int[3, 3, 3]{
                { { 1, 2, 3}, {4, 5, 6}, {7,8, 9}},
                { { 10, 11, 12}, {13, 14, 15},{16, 17, 18} },
                { { 19, 20, 21}, {22, 23, 24}, {25, 26, 27}}
            };
        int l1 = arr.GetLength(0);
        int l2 = arr.GetLength(1);
        int l3 = arr.GetLength(2);

        for (int i = 0; i < l1; i++)
        {
            for (int j = 0; j < l2; j++)
            {
                for (int k = 0; k < l3; k++)
                {
                    Console.WriteLine("a[{0},{1},{2}] = {3}", i, j, k, arr[i, j, k]);
                }
            }
        }
    }
}
