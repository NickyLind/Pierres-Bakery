

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price {get; set;}
    public int Counter  {get; set;}
    public Bread(int counter)
    {
      // Price = int.Parse(price);
      Counter = counter;
      Counter = 0;
    }

    // public int BreadDeal()
    // {
    //   if (Counter % 2 == 0)
    //   {
    //     Price = Counter / 2 * 5;
    //   }
    //   else
    //   {
    //     Price = ((Counter - 1) / 2) + 5;
    //   }
    // }
  }
}