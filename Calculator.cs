 class Calculator
    {
        static void Main(string[] args)
        {
             Console.Title = "Aplikasi Kalkulator ";
            Console.Write("inputkan nilai a = ");
            float a =float.Parse(Console.ReadLine());
            Console.Write("inputkan nilai b = ");
            float b = Convert.ToSingle(Console.ReadLine()); 

            Console.WriteLine("selamat datang di kalkulator fahri ");
            Console.WriteLine("Hasil Penambahan "+a+"+"+b+"=" +Penambahan (a,b));
            Console.WriteLine("hasil Pengurangan {0} - {1} = {2} ",a,b,Pengurangan (a,b));
            Console.WriteLine("hasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(a, b));
            Console.WriteLine("hasil Pembagian {0} / {1} = {2} ", a, b, Pembagian(a, b));

            Console.WriteLine("\n Tekan sembarang key untuk keluar ");
            Console.ReadKey();



        }
        static float Penambahan (float a,float b) {
            return a + b;
              }
        static float Pengurangan(float a, float b)
        {
            return a - b;
        }
        static float Perkalian(float a, float b)
        {
            return a * b;
        }
        static float Pembagian(float a, float b)
        {
            return a / b;
        }
        
    
}
