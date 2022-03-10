using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir  ust sınıfın alt sınıfa  miras vermesine denr
            //alt sınıf ust sınftan kalıtım alarak üst sınıfn bazı özlelliklerini kendisinin kullanabilmesi kendisinin de ait olması gibi düsünebiliriz
            
            //               Canlılar
            //                  |
            //     Bitkiler                 Hayvanlar
            //   |          |          |                 |
            //  Tohumlu      Tohumsuz   Surungenler        Kuslar
            // bitkiklerde hayvanlar da canlı fakat her ikisininde kendi icerisinde ayrıldıgı ozellikler var 
            //virtual metotlarla sanal metotlar yaratırıyoruz
            //Sealed eger siz bir sınıfın baska sınıflar tarafından türetilmesine engellemek istiyorsanız yapıyorsunuz kalıtımın onune gecmek



            // olusturdugumuz sınfların nesnesini olusturarak program ıcerisinde ne faydası oldu onu gorelim
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
  
            tohumluBitki.TohumlaCogalma();

            //hayvanlar;
            Kuslar martı= new Kuslar();
         
            martı.Ucmak();




        }
    }
}
