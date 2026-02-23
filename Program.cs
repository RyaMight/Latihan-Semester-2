using System;
using System.Runtime.InteropServices;

namespace HargaBaju
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("=== Selamat Datang di Toko Baju Rayasa ===");

            Console.Write("Masukkan merk baju (H&M / Uniqlo / Raya): ");
            string merk = Console.ReadLine().ToLower();

            Console.Write("Masukkan ukuran baju (S / M / L / XL): ");
            string ukuran = Console.ReadLine().ToUpper();

            int harga = 0;

            if (merk == "h&m")
            {
                if (ukuran == "S")
                    harga = 49000;
                else if (ukuran == "M")
                    harga = 54000;
                else if (ukuran == "L")
                    harga = 59000;
                else if (ukuran == "XL")
                    harga = 69000;
                else
                {
                    Console.WriteLine("Ukuran tidak tersedia.");
                }
            }
            else if (merk == "uniqlo")
            {
                if (ukuran == "S")
                    harga = 44000;
                else if (ukuran == "M")
                    harga = 49000;
                else if (ukuran == "L")
                    harga = 54000;
                else if (ukuran == "XL")
                    harga = 64000;
                else
                {
                    Console.WriteLine("Ukuran tidak tersedia.");
                }
            }
            else if (merk == "raya")
            {
               if (ukuran == "S")
                    harga = 200000;
                else if (ukuran == "M")
                    harga = 49500;
                else if (ukuran == "L")
                    harga = 56000;
                else if (ukuran == "XL")
                    harga = 62500;
                else
                {
                    Console.WriteLine("Ukuran tidak tersedia.");
                }
            }
            else
            {
                Console.WriteLine("Merk tidak tersedia.");
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("Merk       : " + merk.ToUpper());
            Console.WriteLine("Ukuran     : " + ukuran);
            Console.WriteLine("Harga      : Rp. " + harga);
            Console.WriteLine("--------------------------");

            Console.Write("Silahkan pilih metode pembayaran (Tunai/Qris) : ");
            string pembayaran = Console.ReadLine().ToLower();

            if (pembayaran == "tunai")
            {
                Console.WriteLine("Pembayaran dilakukan dengan tunai.");
                Console.WriteLine("Silahkan Tunjukan code ini pada kasir : Anggap ini code");
            }
            else if (pembayaran == "qris")
            {
                Console.WriteLine("Pembayaran dilakukan dengan QRIS.");
                Console.WriteLine("Anggap saja ini qris wokwowk");
            }
            else 
            {
                Console.WriteLine("Metode pembayaran tidak tersedia.");
            }
            */
/*
            Console.WriteLine("=== Selamat Datang di Toko Baju Rayasa ===");

            Console.Write("Masukkan merk baju (H&M / Uniqlo / R): ");
            string merk = Console.ReadLine().ToLower();

            Console.Write("Masukkan ukuran baju (S / M / L / XL): ");
            string ukuran = Console.ReadLine().ToUpper();

            int harga = 0;
            bool valid = true;

            switch (merk)
            {
                case "h&m":
                    switch (ukuran)
                    {
                        case "S": harga = 49000; break;
                        case "M": harga = 54000; break;
                        case "L": harga = 59000; break;
                        case "XL": harga = 69000; break;
                        default:
                            Console.WriteLine("Ukuran tidak tersedia.");
                            valid = false;
                            break;
                    }
                    break;

                case "uniqlo":
                    switch (ukuran)
                    {
                        case "S": harga = 44000; break;
                        case "M": harga = 49000; break;
                        case "L": harga = 54000; break;
                        case "XL": harga = 64000; break;
                        default:
                            Console.WriteLine("Ukuran tidak tersedia.");
                            valid = false;
                            break;
                    }
                    break;
                case "r":
                    switch (ukuran)
                    {
                        case "S": harga = 200000; break;
                        case "M": harga = 49500; break;
                        case "L": harga = 56000; break;
                        case "XL": harga = 62500; break;
                        default:
                            Console.WriteLine("Ukuran tidak tersedia.");
                            valid = false;
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Merk tidak tersedia.");
                    valid = false;
                    break;
            }

            if (!valid) return;

            Console.WriteLine("--------------------------");
            Console.WriteLine("Merk   : " + merk.ToUpper());
            Console.WriteLine("Ukuran : " + ukuran);
            Console.WriteLine("Harga  : Rp. " + harga);
            Console.WriteLine("--------------------------");

            Console.Write("Silahkan pilih metode pembayaran (Tunai / Qris): ");
            string pembayaran = Console.ReadLine().ToLower();

            switch (pembayaran)
            {
                case "tunai":
                    Console.WriteLine("Pembayaran dilakukan dengan tunai.");
                    Console.WriteLine("Silahkan tunjukan kode ini pada kasir.");
                    break;

                case "qris":
                    Console.WriteLine("Pembayaran dilakukan dengan QRIS.");
                    Console.WriteLine("Silahkan scan QR Code.");
                    break;

                default:
                    Console.WriteLine("Metode pembayaran tidak tersedia.");
                    break;
                    */


/*
Console.WriteLine("Login Sederhana");

        Console.Write("Silakan masukkan username: ");
        string username = Console.ReadLine().Trim();

        Console.Write("Silakan masukkan password: ");
        string password = Console.ReadLine().Trim();

        string correctUsername = "Raya";
        string correctPassword = "Rayasa123@";

        if (username == "Raya" && password == correctPassword)
        {
            Console.WriteLine("\nSelamat Datang Master " + username);
        }
        else
        {
            Console.WriteLine("Username atau password salah!");
        }
        Console.WriteLine("\nTekan Untuk Keluar");
        Console.ReadKey();
*/

/* Perulangan */
/*
Console.Write("Silahkan Masukkan Kata: ");
String tulisan = Console.ReadLine();

Console.Write("Masukkan Jumlah Perulangan: ");
int jumlah = int.Parse(Console.ReadLine());



int i = 1;
while (i <= jumlah)
{
    Console.WriteLine(tulisan);
    i++;
}
*/
/*
int i = 9;

while (i >= 1)
{
    Console.Write(i + " ");
    i--;
}
*/


int pilihan;

        do
        {
            Console.WriteLine("Silahkan pilih apa yang ingin kamu lakukan dibawah ini : ");
            Console.WriteLine("1. Mencetak kalimat ");
            Console.WriteLine("2. Keluar Program");
            Console.Write("Ketik angka menu yang dipilih : ");

            pilihan = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (pilihan == 1)
            {
                Console.Write("Silahkan Masukkan Kata: ");
                String tulisan = Console.ReadLine();

                 Console.Write("Masukkan Jumlah Perulangan: ");
                 int jumlah = int.Parse(Console.ReadLine());

                         int i = 1;
                while (i <= jumlah)




{
    Console.WriteLine(tulisan);
    i++;
}
            }
            else if (pilihan == 2)
            {
                Console.WriteLine("Program selesai.");
            }
            else
            {
                Console.WriteLine("Angka yang anda masukan salah");
            }

            Console.WriteLine();
        } while (pilihan != 2);
       
        } 
     }
 }
