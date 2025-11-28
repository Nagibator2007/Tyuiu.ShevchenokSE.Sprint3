using Tyuiu.ShevchenokSE.Sprint3.Task7.V20.Lib;
namespace Tyuiu.ShevchenokSE.Sprint3.Task7.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шевченок С.Е. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил Шевченок Сергей Евгеньевич | СМАРТб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("*         sin(x) - 2x                                                     *");
            Console.WriteLine("* F(x) = ------------- + sin(x) - 3x + 2                                  *");
            Console.WriteLine("*            3x - 1                                                       *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5] c шагом 1 *");
            Console.WriteLine("* Произвести проверку деления на 0. При делении на 0 вернуть значение 0.  *");
            Console.WriteLine("* Значение округлить до двух знаков после запятой. Значения занести в     *");
            Console.WriteLine("* массив                                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    f(x)   |");
            Console.WriteLine("+----------+-----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0, 5:d}     |   {1, 6:f2}  |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();
        }
    }
}