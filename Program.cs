namespace modul4_103022330138
{
    class Program
    {
        static void Main(string[] args)
        {
            string namaProduk;
            
            Console.Write("Masukan nama produk :");
            namaProduk = Console.ReadLine();
            Console.WriteLine(KodeProduk.getKodeProduk(namaProduk));
        }
    }
}
