namespace Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Entrer votre nom");
            //string? name = Console.ReadLine();
            //Console.WriteLine($"nom : {name}");
            //Console.WriteLine("nom : " + name);
            //Console.WriteLine("nom : {0}" , name);

            #region les variables

            //int n1 = 150;
            //float n2 = 5465.32f;
            //double n3 = 4654654654.989878;
            //long n4 = 78945612345L;
            //byte n5 = 255;
            //uint n6 = 78; //pas de valeur négatif avec les types non signé
            //n6 = uint.MaxValue;
            //Console.WriteLine(3.42 % 1.16f);

            //if(int.TryParse(Console.ReadLine(), out int convertion))
            //{
            //    Console.WriteLine(convertion / 2);
            //}
            //else { 
            //    Console.WriteLine("fin du programme");
            //}

            //var dynamicVariable = 5;
            //string t = "bonjour a " + 8 + " personnes";

            #endregion

            #region conditionnel

            //byte age = 25;
            //if (age < 4)
            //{
            //    Console.WriteLine("c'est un mineur");
            //}
            //else if (age == 15)
            //{
            //    Console.WriteLine("vous avez 15 ans");
            //}
            //else
            //{
            //    Console.WriteLine("tu es majeur");
            //}

            #endregion

            //Exercices(1);
            //Exercices(2);
            //Exercices(3);
            Exercices(4);
        }

        private static void Exercices(int nbExercice = 1)
        {
            switch(nbExercice)
            {
                case 1: 
                    {
                        #region exercice 1

                        Console.WriteLine("Exercice 1 : \n--------");
                        Console.Write("premier nombre : ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("deuxieme nombre : ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"somme = {num1 + num2}");

                        Console.Write("premier nombre : ");
                        int.TryParse(Console.ReadLine(), out num1);
                        Console.Write("deuxieme nombre : ");
                        int.TryParse(Console.ReadLine(), out num2);
                        Console.WriteLine($"somme = {num1 + num2}");

                        #endregion
                    }
                    break;
                case 2:
                    {
                        #region exercice 2

                        Console.WriteLine("Exercice 2 : \n--------");
                        Console.Write("Entrer un nombre entier : ");
                        int.TryParse(Console.ReadLine(), out int input);
                        Console.WriteLine($"Le nombre est {(input % 2 == 0 ? "paire" : "impaire")}");

                        #endregion
                    }
                    break;
                case 3:
                    {
                        #region exercice 3 (suite de fiboanacci)

                        //0 1 1 2 3 5 8 13
                        int previous = 0, current = 1;
                        Console.Write(previous + ",");
                        Console.Write(current + ",");
                        for (int i = 1; i < 25; i++)
                        {
                            Console.Write((previous + current) + ",");
                            current += previous;
                            previous = current - previous;
                        }
                        Console.WriteLine((previous + current));

                        #endregion
                    }
                    break;
                case 4:
                    {
                        #region exercice 4 (factoriel)

                        //6! = 6 * 5 * 4 * 3 * 2 * 1
                        Console.Write("Entrer un nombre pour calculer sa factorielle : ");
                        int.TryParse(Console.ReadLine(), out int n);
                        Console.WriteLine($"Factorielle de {n}! = {Factorial(n)}");

                        #endregion
                    }
                    break;

                default: Console.WriteLine($"Exercice {nbExercice} non trouve!");
                    break;

            }
        }

        private static int Factorial(int n)
        {
            int sum = n;
            if (n > 1)
            {
                sum *= Factorial(n - 1);
            }
            return sum;
        }

    }
    
}
