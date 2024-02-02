using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            
            Console.Write("Введите кол-во сотрудников:");
            int N = Convert.ToInt32(Console.ReadLine());
            //массив из N объектов
            Staff[] employees = new Staff[N];
            // ввод информации о сотрудниках с клавиатуры
            for (int i = 0; i < N; i++)
            {
                employees[i] = new Staff();
                Console.Write("Введите табельный номер сотрудника:");
                employees[i].EmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите ФИО сотрудника:");
                employees[i].FullName = Console.ReadLine();
                Console.Write("Введите дату рождения сотрудника:");
                employees[i].DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Введите должность сотрудника:");
                employees[i].Position = Console.ReadLine();
                Console.Write("Введите оклад сотрудника:");
                employees[i].Salary = Convert.ToInt32(Console.ReadLine());
            }
            // Сведения об объектах
            Console.WriteLine("Информация о сотрудниках:");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("табельный номер\tФИО\tДата рождения\tДолжность\tОклад");
            Console.WriteLine("--------------------------------------------------------------");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{employees[i].EmployeeId}\t\t{ employees[i].FullName}\t {employees[i].DateOfBirth.ToShortDateString()}\t {employees[i].Position}\t\t{ employees[i].Salary}");
            }
            //отсутствие информации
                if (N == 0)
                {
                    Console.WriteLine("нет информ");
                }


                Console.WriteLine("\nИнформация возрасте  сотрудников:");
                Console.WriteLine("\nФИО\tВозраст");
                //Вывод информации о возрасте каждого сотрудника на данный момент времени
                foreach (Staff employee in employees)
                {
                    if (employee != null)
                    {
                        Console.WriteLine($"{employee.FullName}\t{employee.Age()}");
                    }
                 

                }
                Console.ReadKey();
            

        }
    }
}