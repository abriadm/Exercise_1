using System;

// arr = giveon
// j = AA

namespace Exercise_1
{
    class Program
    {
        private int[] a = new int[36]; // Deklarasi array int ukuran 36.

        private int n; // menyimpan banyak data.
       
        public void read() // buat masukin data object.
        {
            while (true) // perulangan while true
            {
                Console.Write("Masukan elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s); // mengubah variable s menjadi integer.
                if (n <= 36)
                    break; // break => program berhenti jika benar
                else
                    Console.WriteLine("Array maksimal 36 element.\n");
            }

            for (int i = 0; i < n; i++) // tampilan pengguna masukan data
            {
                Console.Write((i + 1) + " | ");
                string s1 = Console.ReadLine();
                giveon[i] = Int32.Parse(s1);
            }
        }

        public void display() // show or print data
        {
            for (int AA = 0; AA < n;AA++)
            {
                Console.WriteLine(giveon[AA]);
            }
            Console.WriteLine(" ");
        }

        public void Exercise_1()
        {
            for (int i = 1; i < n; i++)
            {
                for (int AA = 0; AA < n - i; AA++)
                {
                    if (giveon[AA] > giveon[AA + 1])
                    {
                        int temp;
                        temp = giveon[AA];
                        giveon[AA] = giveon[AA + 1];
                        giveon[AA + 1] = temp;
                    }
                }
            }
        }

        static void Main() // call function.
        {
            Program myList = new Program();

            myList.read(); // call read
            myList.Exercise_1(); // call Exxercise_1
            myList.display(); // call display

            Console.Read();
        }
    }
}