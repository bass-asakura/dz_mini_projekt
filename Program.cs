namespace dz_mini_projekt;

class Program
{
    static void Main(string[] args)
    {
        start_shop();
    }
    
    public static void shop(string[] assortiment, int[] price, string name_tovar, int count_tovara, int summa_polz)
    {
        for(int i = 0; i < price.Length; i++)
        {
            if(name_tovar.ToLower() == assortiment[i])
            {
                if(summa_polz == (price[i] * count_tovara))
                {
                    Console.WriteLine($"Вы купили товар - {assortiment[i]}, в колличестве {count_tovara} шт");
                }
                else if(summa_polz > (price[i] * count_tovara))
                {
                    int sdacha = summa_polz - (price[i] * count_tovara);
                    Console.WriteLine($"Вы купили товар - {assortiment[i]}, в колличестве {count_tovara} шт, ваша сдача - {sdacha}");
                }
                else if((summa_polz < (price[i] * count_tovara)) || (summa_polz > price[i]))
                {
                    for(int j = count_tovara; j > 0; j--)
                    {
                        if(summa_polz == (price[i] * j))
                        {
                            Console.WriteLine($"Вам хватает на {j} товар(-ов), хотите купить?");
                            string? otwet = Convert.ToString(Console.ReadLine());
                            if((otwet.ToLower() == "yes") || (otwet.ToLower() == "да"))
                            {
                                Console.WriteLine($"Вы купили {j} товар(ов)");
                                return;
                            }
                        }
                        else if(summa_polz > (price[i] * j))
                        {
                            int sdacha = summa_polz - (price[i] * j);
                            Console.WriteLine($"Вам хватает на {j} товар(-ов), хотите купить?");
                            string? otwet = Convert.ToString(Console.ReadLine());
                            if((otwet.ToLower() == "yes") || (otwet.ToLower() == "да"))
                            {
                                Console.WriteLine($"Вы купили {j} товар(ов), ваща сдача {sdacha}");
                                return;
                            }
                        }
                    }
                }
                if(summa_polz < (price[i] * count_tovara))
                {
                    Console.WriteLine("Недостаточно средств");
                }
            }
            
        }  
    }

    public static void start_shop()
    {
        string[] asort = {"молоко", " яблоки", "бананы", "протеин", "рыба"};
        int[] prc = {100, 70, 80, 200, 150};

        Console.WriteLine("Введите наименование товара");
        string name_tovar = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Введите колличество товара");
        int count_tovara = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите свою сумму");
        int summa_polz = Convert.ToInt32(Console.ReadLine());

        shop(asort, prc, name_tovar!, count_tovara!, summa_polz!);
    }
}