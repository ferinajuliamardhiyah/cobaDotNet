using System.Linq;
using System;
using System.Collections.Generic;

namespace csharp_basic {
    class Program {
        static void Main (string[] args) {
            jumlahKarakter();
            grade();
            oddEven();
            leapYear();
            filmRating();
            loopRange();
            oddGenerator();
            ganjilGenapKelipatan();
            balikKata();
            addToArray ();
        }

        //1.md
        static void jumlahKarakter () {
            Console.WriteLine ("Silakan tuliskan kata: ");
            string word = Console.ReadLine ();
            Console.WriteLine ($"{word.Length}");
        }

        
        //2.md
        static void grade () {
            Console.WriteLine ("Masukkan nilai: ");
            string input = Console.ReadLine ();
            int nilai = Int32.Parse (input);
            if (nilai >= 90)
                Console.WriteLine ('A');
            else if (nilai >= 80 && nilai <= 89)
                Console.WriteLine ('B');
            else if (nilai >= 70 && nilai <= 79)
                Console.WriteLine ('C');
            else if (nilai >= 60 && nilai <= 69)
                Console.WriteLine ('D');
            else if (nilai <= 59)
                Console.WriteLine ('E');
        }

        //3.md
        static void oddEven () {
            Console.WriteLine ("Masukkan angka: ");
            string input = Console.ReadLine ();
            int angka = Int32.Parse (input);
            if (angka % 2 == 0) {
                Console.WriteLine ("Genap");
            } else {
                Console.WriteLine ("Ganjil");
            }
        }

        //4.md
        static void leapYear () {
            Console.WriteLine ("Masukkan tahun: ");
            string input = Console.ReadLine ();
            int tahun = Int32.Parse (input);
            if (tahun % 400 == 0) {
                Console.WriteLine ("Kabisat");
            } else {
                if (tahun % 100 == 0) {
                    Console.WriteLine ("Bukan Kabisat");
                } else {
                    if (tahun % 4 == 0) {
                        Console.WriteLine ("Kabisat");
                    } else {
                        Console.WriteLine ("Bukan Kabisat");
                    }
                }
            }
        }

        //5.md
        static void filmRating () {
            Console.WriteLine ("Masukkan usia: ");
            string input = Console.ReadLine ();
            int usia = Int32.Parse (input);
            if (usia >= 21)
                Console.WriteLine ("Dewasa");
            else if (usia >= 13 && usia <= 20)
                Console.WriteLine ("Remaja");
            else if (usia >= 9 && usia <= 12)
                Console.WriteLine ("Bimbingan Orang Tua");
            else if (usia < 9)
                Console.WriteLine ("Semua Usia");
        }

        //6.md
        static void loopRange () {
            Console.WriteLine ("Masukkan angka pertama: ");
            string input1 = Console.ReadLine ();
            int angka1 = Int32.Parse (input1);
            Console.WriteLine ("Masukkan angka kedua: ");
            string input2 = Console.ReadLine ();
            int angka2 = Int32.Parse (input2);

            for (int i = angka1; i <= angka2; i++) {
                Console.Write ($"{i} ");
            }
        }

        //7.md
        static void oddGenerator () {
            for (int i = 0; i < 100; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine ($"{i}");
                }
            }
        }

        //8.md
        static void ganjilGenapKelipatan () {
            for (int i = 1; i <= 1000; i++) {
                if (i % 100 == 0) {
                    Console.WriteLine ($"{i}. Kelipatan Seratus");
                } else if (i % 2 == 0 && i % 5 == 0) {
                    Console.WriteLine ($"{i}. Genap Kelipatan Lima");
                } else if (i % 2 != 0 && i % 5 == 0) {
                    Console.WriteLine ($"{i}. Ganjil Kelipatan Lima");
                } else if (i % 2 == 0) {
                    Console.WriteLine ($"{i}. Genap");
                } else if (i % 2 != 0) {
                    Console.WriteLine ($"{i}. Ganjil");
                }
            }
        }

        //9.md
        static void balikKata () {
            string input = "saya ingin makan nasi goreng";
            string[] inputUbah = input.Split(" ");
            Array.Reverse(inputUbah);
            string hasil = String.Join(" ",inputUbah);
            Console.WriteLine(hasil);
        }

        //10.md
        static void addToArray () {
            string[] stuff = {"Meja", "Buku", "Topi", "Baju", "Kayu"};
            List<string> stuffNew = stuff.ToList();
            stuffNew.Insert(0, "Handuk");
            stuffNew.Add("Celana");
            string[] stuffLagi = stuffNew.ToArray();
            foreach (var item in stuffLagi)
            {
                Console.WriteLine($"{item}");
            }
        }

    }
}