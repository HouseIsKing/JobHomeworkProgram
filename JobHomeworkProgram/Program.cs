namespace JobHomeworkProgram
{
    class Program
    {
        static List<int>? getFibonachiList(int length)
        {
            if (length <= 0)
                return null;
            List<int> result = new();
            result.Add(1);
            for (int i = 1; i < length; i++)
            {
                result.Add(i + result[i - 1]);
            }
            return result;
        }
        static void Main(string[] args)
        {
            int len = 10;
            if(args.Length == 2)
            {
                len = int.Parse(args[1]);
            }
            List<int>? fibList = getFibonachiList(len);
            if (fibList == null)
                throw new Exception();
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(fibList[j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
