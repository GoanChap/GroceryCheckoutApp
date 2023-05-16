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

        public void Scan (char a)
        {
            if (shoppingList.ContainsKey(a))
                shoppingList[a]++;
            else
                shoppingList.Add(a, 1);
        }

        public int Total()
        {
            int total = 0;
            foreach (var v in shoppingList)
            {
                if (inventoryList.ContainsKey(v.Key))
                    total += (v.Value * inventoryList[v.Key]);
            }
            return total;
        }

    }
}
