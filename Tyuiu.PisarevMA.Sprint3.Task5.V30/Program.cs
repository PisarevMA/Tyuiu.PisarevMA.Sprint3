using Tyuiu.PisarevMA.Sprint3.Task5.V30.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 3 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Вложенные циклы                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 2;
int startValue1 = 1;
int startValue2 = 1;
int stopValue1 = 3;
int stopValue2 = 11;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

Console.ReadKey();
