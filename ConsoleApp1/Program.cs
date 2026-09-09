Console.WriteLine("Добро пожаловать в дарк фэнтези");
Console.WriteLine("Ваша цель спасти принцессу из подземелья");
Console.WriteLine("");

Console.Write("Введите имя вашего рыцаря:");
string heroName = Console.ReadLine();

Console.Write("Введите ваш возраст:");
int heroAge = Convert.ToInt32(Console.ReadLine()!);

if (heroAge <= 17)
{
    Console.WriteLine();
    Console.WriteLine("Еще не дорос принцесс ебать");
    Console.WriteLine("Пошел нахуй отсюда");
    return;
}

Console.Write("Введите ваш рост в метрах (например, 1,85): ");
double heroHeight = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine($"Рыцарь {heroName} {heroAge} лет, рост {heroHeight} м - был направлен в пещеру дабы спасти принцессу");
Console.WriteLine();
Console.WriteLine("Вы шли в пещеру целых 3 дня и после того, как вы в нее зашли, перед вами появилась развилка");
Console.WriteLine("Справа доносились мужские крики, слева горел яркий и ослепляющий свет");
Console.WriteLine();

Console.Write("Куда пойдете? (L - налево, R - направо):");
char choice = Convert.ToChar(Console.ReadLine()!);

if (choice == 'L' || choice == 'l')
{
    Console.WriteLine();
    Console.WriteLine("Вы встретили змея горыныча спящего на огромной горе золота и принцессу рядом с ним");
    Console.WriteLine();
    Console.WriteLine("Перед вами выбор - украсть принцессу тихим методом или громким (Q - тихим, N - громким):");
    char choicee = Convert.ToChar(Console.ReadLine()!);

    if (choicee == 'Q' || choicee == 'q')
    {
        Console.WriteLine("Вы тихо спиздили принцессу и сбежали");
        Console.WriteLine("После пробуждения она вас поблагодарила и вы отвели ее домой");
    }
    if (choicee == 'N' || choicee == 'n')
    {
        Console.WriteLine("Вы побежали с криком, что хохлы на сдаются и разбудили змея гориныча");
        Console.WriteLine("После пробуждения змей очень разозлился, но пока он щелкал еблом вы спиздили эту мымру");
        Console.WriteLine("После пробуждения она в вас влюбилась и дала вам");
    }
}

if (choice == 'R' || choice == 'r')
{
    Console.WriteLine();
    Console.WriteLine("Вы встретили армию гомосеков");
    if (heroHeight <= 1.65)
    {
        Console.WriteLine();
        Console.WriteLine("Так как вы низкого роста гомосеки посчитали вас слабым звеном и пустили вас по кругу и ебали вас до тех пор, пока вы не умрете");
    }
    else
    {
        Console.WriteLine("Вы достаточно высокого роста, они посчитали вас привлекательным и вы устроили оргию");
        Console.WriteLine("Вы стали гомосеком");
    }
   
}