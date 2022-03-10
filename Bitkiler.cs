using System;

namespace Inheritance
{
    public class Bitkiler:Canlılar
    {
        protected void FotosentezYapmak(){
            // bitkilerin sadece kendisinden kaltım alan sınıflar tarafından erisilmesini istiyorum " o yüzden protected yapıyorum "
            Console.WriteLine("Bitkiler fotosentez yapar.");

        }
        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler günese tepki verir");
        }
    }
    public class TohumluBitkiler:Bitkiler{
        //protected icin= tohumlu bitkilerin constructor sayılan yapıcı metotu yazıcam
        public TohumluBitkiler(){
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosal();
            base.Solunum();
            base.UyaranlaraTepki();

            
        }
        public void TohumlaCogalma(){
           
            Console.WriteLine("Tohumlu Bitkiler thumla cogalır.");

        }
    }
    public class TohumsuzBitkiler:Bitkiler{
         public TohumsuzBitkiler(){
            base.FotosentezYapmak();
            
        }
        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla cogalır.");

        }
    }

}