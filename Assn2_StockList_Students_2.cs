using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public partial class StockList
    {


        //param        : NA
        //summary      : finds the stock with most number of holdings
        //return       : stock with most shares
        //return type  : Stock
        //param        : NA
        //summary      : finds the stock with most number of holdings
        //return       : stock with most shares
        //return type  : Stock
        public string MostShares()
        {
            string mostShareStock = null;

            /* 1. total stock one holdings
             2. find stock two - make sure not doing the one that is stock 1
             3. total stock two holdings 
             4. compare stock one and two
             5. make stock one the one with largest holdings
             6. repeat 2-5 until at end of list
             ----or----
             1. find holdings of one
             2. see if empty
             3. if not compare to next stock
             4. highest one remains, compare rest of nodes*/

            StockNode current = this.head;
            mostShareStock = current.StockHolding.Name;
            decimal mostShareStockHolding = current.StockHolding.Holdings;
            if (this.IsEmpty())
            {
                return mostShareStock;
                //need to see what it means about can't conver string to Assignment_2.Stock
            }
            else
            {
                while (current.Next != null)
                {
                    if (current.Next.StockHolding.Holdings > mostShareStockHolding)
                    {
                        mostShareStock = current.Next.StockHolding.Name;
                        mostShareStockHolding = current.Next.StockHolding.Holdings; // was missing this line
                        current = current.Next;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            return mostShareStock;
            //need to see what it means about can't conver string to Assignment_2.Stock
        }




        //param        : NA
        //summary      : finds the number of nodes present in the list
        //return       : length of list
        //return type  : int
        public int Length()
        {


            int length = 0;

            if (this.IsEmpty())
            {
                return length;
            }
            else
            {
                StockNode current = this.head;
                //   StockNode previous = null; // no need for previous

                if (current.Next == null) // good, this situation will only happen if there is one item in list
                {
                    length = 1;
                }
                else
                {

                    while (current.Next != null)
                    {
                        length++;

                        //   previous = current; // no need for previous
                        current = current.Next;


                    }
                    length = length + 1; // this is the same as length ++, it works here, I just find it easier to be consistent;
                }
            }
            return length;
        }




    }
}
