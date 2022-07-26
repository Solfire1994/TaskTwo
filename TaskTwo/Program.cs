using System;

namespace TaskTwo
{
    static class Program
    {
        static void Main(string[] args)
        {
            string name = "Dzmitry";
            string surName = "Karunny";
            string lastName = "Sergeevich";
            string eMail = "solfire1994@gmail.com";
            int age = 28;
            double progTestResult = 97.4;
            double mathTestResult = 54.12;
            double physTestResult = 1015.94;
            Console.WriteLine("Ф.И.О " + surName + " " + name + " " + lastName);
            Console.WriteLine("Возраст " + age + " лет");
            Console.WriteLine("Email " + eMail);
            Console.WriteLine("Результаты теста по программированию " + progTestResult +
                "\nРезультаты теста по математике " + mathTestResult +
                "\nРезультаты теста по физике " + physTestResult);
            Console.WriteLine("Нажмите любую клавишу чтобы найти сумму баллов и средний балл");
            Console.ReadKey();
            double sum = progTestResult + mathTestResult + physTestResult;
            double gpa = sum / 3;
            Console.WriteLine("Сумма по баллам " + sum);
            Console.WriteLine("Средний балл " + gpa);
            Console.ReadKey();

        }
    }
}
