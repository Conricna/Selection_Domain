namespace MobileDeviceC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(Solution.Arg());
            Console.WriteLine("\nВыберите домен по которому хотите совершть переход");
            ///               {                          visitwar.com                   fruonline.co.uk    australia.open.com    credit.card.us  }
            string[] array1 = { "unlock.microvirus.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us" };
            string[] array2 = { "microvirus.md", "visitwar.de", "piratebay.co.uk", "list.stolen.credit.card.us" };
            for (int i = 1; i < array1.Length+1; i++)
            {
                Console.WriteLine(i + ": " + array1[i-1]);
            }
            Console.Write("\n По этим доменам можно совершить переход: ");
            Console.WriteLine(string.Join("  ", Solution.solution(array1, array2)));


            /*                                   Тут предлогается пользователю выбрать доиен по которому он хотел бы перейти
             *                                             нужно только их расскоментить 
             *                                                                            Спасибо вам, мне понравилост)))
            Console.Write("\nВаш выбор - ");
            int choise = Convert.ToInt32(Console.ReadLine())-1;  
            Console.WriteLine(string.Join(" \n ", Solution.solutionans(array1, array2, choise)));
            */
        }
    }
}