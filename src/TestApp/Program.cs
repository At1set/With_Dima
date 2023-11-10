class Program
{
    static void Main(string[] args)
    {
        string result = FileWorker.ReadFile(Path.Combine(Environment.CurrentDirectory, "1.txt").Replace("\\Debug\\net6.0", ""));
        Console.WriteLine(Path.Combine(Environment.CurrentDirectory, "1.txt").Replace("\\Debug\\net6.0", ""));

        Console.ReadLine();
    }
}