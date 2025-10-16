namespace Structure
{
    internal class Program
    {
        public uint volume;

        public Program(uint volume)
        {
            this.volume = volume;
        }

        static void Main(string[] args)
        {

            //la différence entre une structure et une classe est que :
            /*
             * 1) les classes font des copies par références tandis qu'une structure fait une copie par valeur
             * et donc une deuxième variable ne contient pas la même référence mais une copie du contenu de la structure
             * 
             * 2) une structure gardera toujours un constructeur par défaut pas pour une classe
             * 
             * 
             */
            //meilleur performance du programme si la strucutre reste legère dans son contenu sinon utiliser une classe

            //Program p1 = new Program(10);
            //Program p2 = p1;

            //p2.volume = 25;
            //Console.WriteLine(p1.volume);

            //CoffeStruct struct1 = new CoffeStruct(2);
            //CoffeStruct struct2 = struct1;

            //struct2.volume = 70;
            //Console.WriteLine(struct1.volume);

            Point?[,] points = new Point?[5,5];
            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Point p = new Point(i + 1, i + 1);
                        points[i, i] = p;
                        Console.Write($"\"X: {p.x} - Y : {p.y}\"");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    public struct CoffeStruct
    {
        public uint volume;

        public CoffeStruct(uint volume)
        {
            this.volume = volume;
        }
    }

    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
