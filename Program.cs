namespace modul4_103022330138
{
    class Program
    {
        static void Main(string[] args)
        {
            string namaProduk = "";

            Console.WriteLine("TABLE-DRIVEN");
            while (namaProduk != "Next")
            {
                Console.Write("Masukan nama produk : ");
                namaProduk = Console.ReadLine();
                Console.WriteLine(KodeProduk.getKodeProduk(namaProduk));
            }

            Console.WriteLine("\nSTATE-BASED");
            FanLaptop fanLaptop = new FanLaptop();
            fanLaptop.Run();
        }
    }
}
