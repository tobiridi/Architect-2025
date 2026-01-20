using Delegue_event_generic.GenericModels;

namespace Delegue_event_generic
{
    public class Program
    {
        public delegate void Alert(string message);

        static void Main(string[] args)
        {
            //TODO: test generique, event et délégué
            Alert myDelegate = PrintMessage;
            myDelegate.Invoke("coucou mon message");

            GenericClass<Program> gen = new GenericClass<Program>();


            // and, or remplace le && et le || dans une condition
            if(myDelegate is not null and Alert)
            {
                Console.WriteLine("delegate is not null and its type is Alert");
            }
        }

        public static void PrintMessage(string message) => Console.WriteLine(message);

        public void PrintMessageClass(string message) => Console.WriteLine(message);
    }
}
