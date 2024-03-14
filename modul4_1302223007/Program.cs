using modul4_1302223007;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        // IMPLEMENTASI TABLE-DRIVEN
        KodeBuah kodeBuah = new KodeBuah();

        void printInfo(KodeBuah.Buah buah)
        {
            Console.WriteLine("[" + kodeBuah.getKodeBuah(buah) + "]" + buah);
        }

        Console.WriteLine("[Kode Buah] Nama Buah");
        printInfo(KodeBuah.Buah.Apel);
        printInfo(KodeBuah.Buah.Aprikot);
        printInfo(KodeBuah.Buah.Alpukat);
        printInfo(KodeBuah.Buah.Pisang);
        printInfo(KodeBuah.Buah.Paprika);
        printInfo(KodeBuah.Buah.Blackberry);
        printInfo(KodeBuah.Buah.Ceri);
        printInfo(KodeBuah.Buah.Kelapa);
        printInfo(KodeBuah.Buah.Jagung);
        printInfo(KodeBuah.Buah.Kurma);
        printInfo(KodeBuah.Buah.Durian);
        printInfo(KodeBuah.Buah.Anggur);
        printInfo(KodeBuah.Buah.Melon);
        printInfo(KodeBuah.Buah.Semangka);

        Console.WriteLine("");

        // IMPLEMENTASI STATE-BASED CONSTRUCTION
        // NIM => 1302223007 % 3 = 2
        Console.WriteLine("SIMULASI SESUAI NIM");
        PosisiKarakterGame karakter = new PosisiKarakterGame(); 
        Console.WriteLine("State Awal : " + karakter.currState);
        // berdiri -> terbang
        karakter.ActivateTrigger(Trigger.TombolW);
        // terbang -> jongkok
        karakter.ActivateTrigger(Trigger.TombolX);

        Console.WriteLine("");
        // SIMULASI SEMUA
        Console.WriteLine("SIMULASI SEMUA STATE");
        karakter.ActivateTrigger(Trigger.TombolW);
        karakter.SimulasiTrigger(Trigger.TombolW);
        karakter.SimulasiTrigger(Trigger.TombolS);
        karakter.SimulasiTrigger(Trigger.TombolS);
        karakter.SimulasiTrigger(Trigger.TombolW);
        karakter.SimulasiTrigger(Trigger.TombolW);
        karakter.SimulasiTrigger(Trigger.TombolX);
        karakter.SimulasiTrigger(Trigger.TombolS);
        karakter.SimulasiTrigger(Trigger.TombolW);
    }
}