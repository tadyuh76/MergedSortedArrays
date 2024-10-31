namespace baitap
{
    internal class Program
    {
        static int[] Merge(int[] a1, int m, int[] a2, int n)
        {
            var merged = new int[m + n];
            int i = 0, j = 0;
            int ind = 0;
            while (i < m && j < n)
            {
                if (a1[i] < a2[j])
                {
                    merged[ind] = a1[i++];
                } 
                else
                {
                    merged[ind] = a2[j++];
                }
                ind++;
            }

            while (i < m)
            {
                merged[ind++] = a1[i++];
            }

            while (j < n)
            {
                merged[ind++] = a2[j++];
            }

            return merged;
        }

        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            
        }

        static void Main(string[] args)
        {
            var a1 = new int[] { 1, 5, 5, 7 };
            var a2 = new int[] { 0, 4, 7, 9 };
            var merged = Merge(a1, a1.Length, a2, a2.Length);
            PrintArray(merged);
            
        }
    }
}
