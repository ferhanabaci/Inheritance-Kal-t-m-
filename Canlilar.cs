using System;

namespace Inheritance
{
  public  class Canlılar

    {
        protected void Beslenme(){
            Console.WriteLine("Canlılar beslenir.");

        }
        protected void Solunum(){
            Console.WriteLine("Canlılar solunum yapar.");

        }
        protected void Bosal(){
            Console.WriteLine("Canlılar solunum yapar.");
        }
        public virtual void UyaranlaraTepki(){
            Console.WriteLine("Canlılar uyaranlara tepki verir");
        }
    }
}