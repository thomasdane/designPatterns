
//represents an action as an object
//decouples clients that execute the command from the details of the command



namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo.Run(args);
        }
    }

    class Foo
    {
        public static void Run(string[] args)
        {
        }
    }
}
