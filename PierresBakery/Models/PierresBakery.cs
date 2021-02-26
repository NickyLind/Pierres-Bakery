using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int AmountOfBread { get; set; }
    public List<int> breadCount = new List<int> { };
    public Bread(int amountOfBread)
    {

      AmountOfBread = amountOfBread;
    }

    public int BreadDeal()
    {
      for (int i = 1; i <= AmountOfBread; i++)
      {
        if (i % 3 != 0)
        {
        breadCount.Add(i);
        }
      }
      foreach (int count in breadCount)
      {
        Price = breadCount.Count * 5;
      }
      return Price;
    }
  }

  public class Pastry
  {
    public int Price { get; set; }
    public int AmountOfPastries { get; set; }
    public List<int> pastryCount = new List<int> { };
    public Pastry(int amountOfPastries)
    {

      AmountOfPastries = amountOfPastries;

    }

    public int PastryDeal()
    {
      for (int i = 1; i <= AmountOfPastries; i++)
      {
        pastryCount.Add(i);
      }
      Price = pastryCount.Count * 2;
      foreach (int count in pastryCount.ToArray())
      {
        if (count % 3 == 0)
        {
          Price--;
        }
      }
      return Price;
    }
  }
}