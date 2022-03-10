using System;

namespace Inheritance
{
    public class Hayvanlar:Canlılar
    {
        // hayvanlar sınıfı canlılar sınıfından kaltım alır 
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar adaptan kurabilir.");

        }
        //alt sınıfta  üst sınıftan kalıtım alan alt sınıfta override anahtar kelimesi ile 
       //ovveride anahatar kelimesi ile uyaranlara tepkinin bicimi degistircem
        public override void UyaranlaraTepki(){//uyaranlara tepki metotu sanal olarak yaratıldıgını halini gel biir kere koy burada calıstır demek
            
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir");
        }
            
        
    }
    public class Sürüngenler:Hayvanlar{
        // : dersek eger kalıtım vermek istiyoruz demektir : sonra yazıdgımız sınıf ısmı de üst sınıftır miras almaya calıstıgımız sınıftır
        // kalıtım vererek hayvanlar sınıfındaki adaptosyonu sürüngenlerde yapabilir demis oldum 
        public  Sürüngenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosal();
            base.Solunum();
        }
        public void SurunerekHareketEderler(){
            Console.WriteLine("Sürüngenle sürenerek haraket ederler");
        }
    }
    public class Kuslar:Hayvanlar{
         public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosal();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        
        public void Ucmak(){
            Console.WriteLine("Kuslar ucarak haraket ederler");
        }

    }
}