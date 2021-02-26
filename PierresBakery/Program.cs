using System;
using PierresBakery.Models;
using System.Threading;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome To Pierre's Bakery!");
      Thread.Sleep(1000);
      Console.WriteLine("Here are the deals we have available today!");
      Thread.Sleep(3000);
      Console.WriteLine("---------------------------");
      Console.WriteLine("Bread:");
      Console.WriteLine("Buy 2, get 1 free! A single loaf costs 5$");
      Console.WriteLine("---------------------------");
      Thread.Sleep(3000);
      Console.WriteLine("---------------------------");
      Console.WriteLine("Pastries:");
      Console.WriteLine("Buy 1 for 2$, or 3 for 5$!");
      Console.WriteLine("---------------------------");
      Thread.Sleep(3000);
      Console.WriteLine("How much bread would you like?");
      int breadCount = int.Parse(Console.ReadLine());
      Bread userBread = new Bread(breadCount);
      Console.WriteLine("Your bread will cost: " + userBread.BreadDeal() +"$");
      Console.WriteLine("---------------------------");
      Thread.Sleep(2000);
      Console.WriteLine("How many pastries would you like?");
      int pastryCount = int.Parse(Console.ReadLine());
      Pastry userPastry = new Pastry(pastryCount);
      Console.WriteLine("Your pastries will cost: " + userPastry.PastryDeal() +"$");
      Console.WriteLine("---------------------------");
      Thread.Sleep(3000);
      Console.WriteLine("Total Cost:");
      Console.WriteLine(userBread.Price + userPastry.Price + "$");
      Thread.Sleep(2000);
      Console.WriteLine("Thank you for shopping with us today!");
    }
  }
}