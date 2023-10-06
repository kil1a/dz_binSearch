class Program
{
    static bool SearchBin(int[] mass, int poisk)
    {
        int left = 0;
        int right = mass.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (mass[mid] == poisk)
                return true;
            else if (mass[mid] < poisk)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
    static void Main(string[] args)
    {
        int[] nums = { 1, 3, 5, 6 };
        int target = 5;
        bool found = SearchBin(nums, target);
        Console.WriteLine(found);
    }
}
