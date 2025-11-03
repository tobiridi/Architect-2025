namespace Delegue_event_generic.GenericModels
{
    public class GenericClass<T> where T : class, new()
    {
        public Action<int, string> MyAction { get; set; }

        public GenericClass() {
            MyAction += delegate (int a, string b) { Console.WriteLine($"params {a} | {b}"); };

            MyAction(10, "toto");
        }
    }

    public class GenericClass2<K,V>
    {

    }
}
