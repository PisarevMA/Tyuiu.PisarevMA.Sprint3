using Tyuiu.PisarevMA.Sprint3.Task4.V16.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 3 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
Console.WriteLine("* функции y=((cos(x)+x)/x)+0.25. При х = 0 пропустить значение.           *");
Console.WriteLine("* Полученные значения перемножать.                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine("Старт шага: " + startValue);
Console.WriteLine("Конец шага: " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("получилось=" + ds.Calculate(startValue, stopValue));

Console.ReadKey();
