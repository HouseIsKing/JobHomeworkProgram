namespace JobHomeworkProgram
{
    public class Program
    {
        public static List<int>? GetFibonachiList(int length)
        {
            if (length <= 0)
                return null;
            List<int> result = new();
            result.Add(1);
            if (length == 1)
                return result;
            result.Add(1);
            for (int i = 2; i < length; i++)
            {
                result.Add(result[i-2] + result[i - 1]);
            }
            return result;
        }
        static void Main(string[] args)
        {
            int len = 10;
            if(args.Length >= 1)
            {
                len = int.Parse(args[0]);
            }
            List<int>? fibList = GetFibonachiList(len);
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
