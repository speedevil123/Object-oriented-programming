using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Class1
    {
        class Mainframe
        {
            int OperativeMemory { get; set; }
            int VideoMemory { get; set; }
            string CPU_model {  get; set; }

            public Mainframe()
            {
                OperativeMemory = 0; 
                VideoMemory = 0;
                CPU_model = string.Empty;
            }

            public Mainframe(int OperativeMemory_, int VideoMemory_, string CPU_model_)
            {
                OperativeMemory = OperativeMemory_;
                VideoMemory = VideoMemory_;
                CPU_model = CPU_model_;
            }

            public string getName()
            {
                return "Mainframe";
            }

            public virtual void print()
            {
                Console.WriteLine(
                    "Характеристики " + getName() + ":\n" +
                    "Размер оперативной памяти (MB): " + OperativeMemory + "\n" +
                    "Размер видеопамяти (MB): " + VideoMemory + "\n" +
                    "Модель процессора: " + CPU_model);
            }
            public virtual void scan()
            {
                Console.Write("Введите размер оперативной памяти (MB): ");
                OperativeMemory = int.Parse(Console.ReadLine());
                Console.Write("\nВведите размер видеопамяти (MB): ");
                VideoMemory = int.Parse(Console.ReadLine());
                Console.Write("\nВведите модель процессора: ");
                CPU_model = Console.ReadLine();
            }
        }

        class PersonalComputer : Mainframe
        {
            int UsbConnectorsAmount {  get; set; }
            string CaseModel {  get; set; }

            public PersonalComputer() : base()
            {
                UsbConnectorsAmount = 0;
                CaseModel = string.Empty;
            }

            public PersonalComputer(int OperativeMemory_, int VideoMemory_, string CPU_model_, int usbConnectorsAmount_, string caseModel_) : base(OperativeMemory_, VideoMemory_, CPU_model_)
            {
                UsbConnectorsAmount = usbConnectorsAmount_;
                CaseModel = caseModel_;
            }

            public override void print()
            {
                base.print();
                Console.WriteLine(
                    "Количество раъемов для USB-устройств: " + UsbConnectorsAmount + "\n" +
                    "Модель корпуса: " + CaseModel);
            }
            public override void scan()
            {
                base.scan();
                Console.Write("\nВведите кол-во USB-разъемов: ");
                UsbConnectorsAmount = int.Parse(Console.ReadLine());
                Console.Write("\nВведите модель корпуса: ");
                CaseModel = Console.ReadLine();
            }
        }
        class Laptop : Mainframe
        {
            int BatteryHours;
            string BatteryModel;

            public Laptop() : base()
            {
                BatteryHours = 0;
                BatteryModel = string.Empty;
            }

            public Laptop(int OperativeMemory_, int VideoMemory_, string CPU_model_, int batteryHours_, string batteryModel_) : base(OperativeMemory_, VideoMemory_, CPU_model_)
            {
                BatteryHours = batteryHours_;
                BatteryModel = batteryModel_;
            }

            public override void print()
            {
                base.print();
                Console.WriteLine(
                   "Количество часов без подзарядки: " + BatteryHours + "\n" +
                   "Модель аккумулятора: " + BatteryModel);
            }

            public override void scan()
            {
                base.scan();
                Console.Write("\nВведите кол-во часов без подзарядки: ");
                BatteryHours = int.Parse(Console.ReadLine());
                Console.Write("\nВведите модель аккумулятора: ");
                BatteryModel = Console.ReadLine();
            }
        }

        static void Main()
        {
            int ans = 0, pc_size = 0, laptop_size = 0, mainframe_size = 0;
            PersonalComputer[] mas_pc = new PersonalComputer[0];
            Laptop[] mas_laptop = new Laptop[0];
            Mainframe[] mas_mainframe = new Mainframe[0];

            Console.WriteLine("Выберите пункт меню: ");
            do
            {
                Console.WriteLine("1 - Personal Computer");
                Console.WriteLine("2 - Laptop");
                Console.WriteLine("3 - Выход");
                ans = int.Parse(Console.ReadLine());

                switch (ans)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("1 - Ввести данные с клавиатуры");
                            Console.WriteLine("2 - Использовать для заполнения seed");
                            Console.WriteLine("3 - Вывести на экран");
                            Console.WriteLine("4 - Выйти в главное меню");

                            ans = int.Parse(Console.ReadLine());

                            switch (ans)
                            {
                                case 1:
                                    Console.Write("Введите кол-во ПК: ");
                                    pc_size = int.Parse(Console.ReadLine());
                                    mas_pc = new PersonalComputer[pc_size];
                                    for (int i = 0; i < pc_size; i++)
                                    {
                                        mas_pc[i] = new PersonalComputer();
                                        Console.WriteLine(i + 1 + " - Компьютер: ");
                                        mas_pc[i].scan();
                                    }
                                    break;
                                case 2:
                                    mas_pc = new PersonalComputer[4] {
                                        new PersonalComputer(4096,512,"Intel Celeron N4000",4,"AeroCool"),
                                        new PersonalComputer(1024, 2048, "AMD Athlon 3000G", 8, "Thermaltake"),
                                        new PersonalComputer(16384, 4096,"Intel Core i5-9400F", 12,"COUGAR" ),
                                        new PersonalComputer(256, 1024, "AMD Ryzen 9 5900X", 6, "Deepcool")
                                    };
                                    break;
                                case 3:
                                    int cnt = 1;
                                    if (mas_pc.Length > 0)
                                    {
                                        foreach (PersonalComputer pc in mas_pc)
                                        {
                                            Console.WriteLine(cnt++ + " - Компьютер: ");
                                            pc.print();
                                            Console.WriteLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Задайте кол-во компьютеров!");
                                    }
                                    break;
                            }
                        } while (ans != 4);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("1 - Ввести данные с клавиатуры");
                            Console.WriteLine("2 - Использовать для заполнения seed");
                            Console.WriteLine("3 - Вывести на экран");
                            Console.WriteLine("4 - Выйти в главное меню");

                            ans = int.Parse(Console.ReadLine());

                            switch (ans)
                            {
                                case 1:
                                    Console.Write("Введите кол-во ноутбуков: ");
                                    laptop_size = int.Parse(Console.ReadLine());
                                    mas_laptop = new Laptop[laptop_size];
                                    for (int i = 0; i < laptop_size; i++)
                                    {
                                        mas_laptop[i] = new Laptop();
                                        Console.WriteLine(i + 1 + " - Ноутбук: ");
                                        mas_laptop[i].scan();
                                        Console.WriteLine();
                                    }
                                    break;
                                case 2:
                                    mas_laptop = new Laptop[4] {
                                        new Laptop(4096,512,"Intel Celeron N4000",20,"AeroCool"),
                                        new Laptop(1024, 2048, "AMD Athlon 3000G", 12, "Thermaltake"),
                                        new Laptop(16384, 4096,"Intel Core i5-9400F", 96,"COUGAR" ),
                                        new Laptop(256, 1024, "AMD Ryzen 9 5900X", 48, "Deepcool")
                                    };
                                    break;
                                case 3:
                                    int cnt = 1;
                                    if (mas_laptop.Length > 0)
                                    {
                                        foreach (Laptop lp in mas_laptop)
                                        {
                                            Console.WriteLine(cnt++ + " - Ноутбук: ");
                                            lp.print();
                                            Console.WriteLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Задайте кол-во ноутбуков!");
                                    }
                                    break;

                            }
                        } while (ans != 4);
                        break;
                }
            } while (ans != 3);
        }
    }
}
