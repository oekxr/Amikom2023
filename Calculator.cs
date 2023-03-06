namespace ConsoleCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            Console.Write("Pilih menu Calculator");
            Console.WriteLine();
            Console.Write("\n1. Penambahan");
            Console.Write("\n2. Pengurangan");
            Console.Write("\n3. Perkalian");
            Console.Write("\n4. Pembagian");
            Console.WriteLine();
            Console.Write("\nInput nomor menu [1..4]: ");
            int x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                Console.Write("Input nilai a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Input nilai b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (x == 2)
            {
                Console.Write("Input nilai a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Input nilai b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (x == 3)
            {
                Console.Write("Input nilai a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Input nilai b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (x == 4)
            {
                Console.Write("Input nilai a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Input nilai b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.Write("Maaf, menu yang anda pilih tidak tersedia.");
                Console.WriteLine();
            }

            Console.WriteLine("Tekan sembarang key untuk keluar");
            Console.ReadKey();
        }
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
    }
}
