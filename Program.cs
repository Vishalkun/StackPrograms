namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackProblems stackobj = new StackProblems();
            stackobj.pushData(56);
            stackobj.pushData(30);
            stackobj.pushData(70);

            stackobj.DisplayData();


        }
    }
}