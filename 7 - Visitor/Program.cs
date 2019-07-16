using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Liquor vodka = new Liquor(95);
            Console.WriteLine(vodka);
            IVisitor vodkaEndOfYearVisitor = new EndOfYearTax();
            Console.WriteLine($"Price after tax = {vodka.Accept(vodkaEndOfYearVisitor)}");

            Perfume boss = new Perfume(100);
            Console.WriteLine(boss);
            IVisitor bossEndOfYearVisitor = new EndOfYearTax();
            Console.WriteLine($"Price after tax = {boss.Accept(bossEndOfYearVisitor)}");

            IVisitor bossOneShekelPrice = new OneShekelPrice();
            Console.WriteLine($"Price after One Shekel Sale = {boss.Accept(bossOneShekelPrice)}");

            ShopRent shop = new ShopRent(1000);
            Console.WriteLine(shop);
            IVisitor shopEndOfYearVisitor = new EndOfYearTax();
            Console.WriteLine($"Price after tax = {shop.Accept(shopEndOfYearVisitor)}");
        }
    }
}
