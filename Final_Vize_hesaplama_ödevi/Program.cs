namespace Final_Vize_hesaplama_ödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Öğrenci sayısını giriniz => ");
            int ögrsayisi = Convert.ToInt32(Console.ReadLine());

            float vize, final;
            float enb = 0;
            float enk = 100;
            float ort;
            float gnlort = 0;
            string OgrAdi = "";
            string enbOgrAdi = "";
            string enkOgrAdi = "";
            for (int i = 0; i < ögrsayisi;)

            {
                Console.WriteLine("Öğrenci Adı Giriniz");
                OgrAdi = Console.ReadLine();

                Console.WriteLine($"{i + 1}. vize notunuzu giriniz");
                vize = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}. Final notunuzu giriniz");
                final = Convert.ToInt32(Console.ReadLine());
                if (vize >= 0 && vize <= 100 && final >= 0 && final <= 100)
                {


                    ort = (float)(vize * 0.4) + (float)(final * 0.6);

                    Console.WriteLine($"{i + 1}Ortalamanız ={ort}");
                    gnlort += ort;
                    if (ort >= enb)
                    {
                        enb = ort;
                        enbOgrAdi = OgrAdi;
                    }
                    if (ort < enk)
                    {
                        enk = ort;
                        enkOgrAdi = OgrAdi;
                    }

                    i++;
                }
            }
            Console.WriteLine($"Sınıf ortalaması = {gnlort / ögrsayisi} ");
            Console.WriteLine($"En Büyük Ortalama = {enb}. Öğrenci Adı : {enbOgrAdi}");
            Console.WriteLine($"En Küçük Ortalama = {enk}. Öğrenci Adı : {enkOgrAdi}");
        }
    }
}