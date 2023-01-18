namespace Delegates_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Delegates");

            DelgateOperation obj = new DelgateOperation(ArthematicOperation.Addition);
            DelgateOperation obj1 = new DelgateOperation(ArthematicOperation.Multiplication);
            Console.WriteLine("{0}", obj(2, 4));

            Console.WriteLine(""+obj1.Invoke(2, 4));
        }
    }
}