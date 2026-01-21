using System;

namespace HargaBaju
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    return;
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
                    return;
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
                    return;
                }
            }
            else
            {
                Console.WriteLine("Merk tidak tersedia.");
                return;
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("Merk   : " + merk.ToUpper());
            Console.WriteLine("Ukuran : " + ukuran);
            Console.WriteLine("Harga  : Rp. " + harga);
            Console.WriteLine("--------------------------");

            Console.Write("Silahkan pilih metode pembayaran (Tunai/Qris) : ");
            string pembayaran = Console.ReadLine().ToLower();

            if (pembayaran == "tunai")
            {
                Console.WriteLine("Pembayaran dilakukan dengan tunai.");
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
        }
    }
}
