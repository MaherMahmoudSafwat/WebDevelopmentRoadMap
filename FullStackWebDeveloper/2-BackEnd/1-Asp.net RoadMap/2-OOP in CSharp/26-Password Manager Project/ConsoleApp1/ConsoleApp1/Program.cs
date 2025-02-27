namespace ConsoleApp1
{
    internal class Program
    {
        public static void MoveZeroes(int[] nums)
        {
            int[] Array2 = new int[nums.Length];
            int j = 0;
            for(int i = 0 ;i<nums.Length ;i++)
            {
                if (nums[i]!=0)
                {
                    Array2[j] = nums[i];
                    j++;
                }
            }
            for(;j<nums.Length;j++)
            {
                Array2[j] = 0;
            }
            nums = Array2;
        }
        static void Main(string[] args)
        {
            int[] Array123 = { 0, 1, 0, 3, 12 };
            MoveZeroes(Array123);
        }
    }
}
