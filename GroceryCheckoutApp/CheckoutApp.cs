using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryCheckoutApp
{
    public class CheckoutApp
    {

        Dictionary<char, int> shoppingList = new Dictionary<char, int>();
        Dictionary<char, int> inventoryList = new Dictionary<char, int>
        {
            { 'A',50 },
            { 'B',30 },
            { 'C',20 },
            { 'D',15 }
        };
        Dictionary<char, decimal> discountList = new Dictionary<char, decimal>
        {
            { 'X',0.5m },
            { 'Y',0.1m },
            { 'Z',0.05m }            
        };

        public void Scan (char a)
        {
            if (shoppingList.ContainsKey(a))
                shoppingList[a]++;
            else
                shoppingList.Add(a, 1);
        }

        public int Total()
        {
            decimal total = 0m;
            total = inventoryList.Sum(x =>
            {
                if (shoppingList.ContainsKey(x.Key) == inventoryList.ContainsKey(x.Key))
                    return shoppingList[x.Key] * inventoryList[x.Key];
                else
                    return 0;
            });
            //above code in another format. Not sure whose BigO Time complexity would be higher
            //foreach (var v in shoppingList)
            //{
            //    if (inventoryList.ContainsKey(v.Key))
            //        total += (v.Value * inventoryList[v.Key]);
            //}
            foreach (var v in discountList)
            {
                if (shoppingList.ContainsKey(v.Key))
                    total = Decimal.Multiply(total, (discountList[v.Key]));
            }            
            return Decimal.ToInt32(total);
        }
    }
}
