namespace CasserMotDePasseAlphaForceBrute
{
   class Program
   {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            // génère un code ASCII entre 97 et 122
            int codeASCIIHasard1 = rnd.Next(97, 122);
            int codeASCIIHasard2 = rnd.Next(97, 122);

            // obtient la lettre aléatoire à partir du code ASCII
            char lettreHasard1 = (char)codeASCIIHasard1;
            char lettreHasard2 = (char)codeASCIIHasard2;
            string motDePasse = lettreHasard1.ToString() + lettreHasard2.ToString();


            for (int i = 97; i < 122; i++)
            {
                char lettreHasardForceBrute1 = (char)i;
                if (lettreHasardForceBrute1 == lettreHasard1)
                  {
                    Console.WriteLine("Première lettre trouvée : " + lettreHasardForceBrute1);

                    for (int j = 97; j < 122; j++)
                    {
                        char lettreHasardForceBrute2 = (char)j;
                        if (lettreHasardForceBrute2 == lettreHasard2)
                        {
                            Console.WriteLine("Deuxième lettre trouvée : " + lettreHasardForceBrute2);
                            Console.WriteLine("Mot de passe trouvé : " + motDePasse);
                            break;
                        }
                    }
                }
            }
        }

    }
}