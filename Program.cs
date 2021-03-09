using System;

namespace kalkulatorapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi kalkulator";

            static int Penambahan(int a, int b)
            {
                return a + b;
            }
            static int Pengurangan(int a, int b)
            {
                return a - b;
            }
            static int Perkalian(int a, int b)
            {
                return a * b;
            }
            static int Pembagian(int a, int b)
            {
                return a / b;
            }

        hitungulang:
            {
                Console.WriteLine("1. penambahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian\n");
            Pilihanmenu:
                {
                    Console.WriteLine("Pilih Menu yang di inginkan");
                    int menu = int.Parse(Console.ReadLine());

                    if (menu < 1)
                    {
                        Console.WriteLine("Menu tidak tersedia");
                        goto Pilihanmenu;
                    }
                    else if (menu > 4)
                    {
                        Console.WriteLine("Menu tidak tersedia");
                        goto Pilihanmenu;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Pilih Angka Pertama");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Pilih Angka Kedua");
                        int b = int.Parse(Console.ReadLine());

                        switch (menu)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Hasil Perkalian Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                                    break;
                                }
                            default:
                                Console.WriteLine("Menu Salah");
                                break;
                        }
                    keluar:
                        {
                            Console.WriteLine("1. Ulangi Program");
                            Console.WriteLine("2. Tutup Program");
                            int ulang = int.Parse(Console.ReadLine());
                            if (ulang == 1)
                            {
                                Console.Clear();
                                goto hitungulang;
                            }
                            else if (ulang == 2)
                            {
                                Console.Clear();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Menu tidak tersedia");
                                goto keluar;
                            }
                        }
                    }
                }
            }
        }
    }
}