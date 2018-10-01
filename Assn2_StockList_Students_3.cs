using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public partial class StockList
    {
        //param        : NA
        //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
        //return       : total value
        //return type  : decimal
        public decimal Value()
        {
            decimal value = 0.0m;

            if (this.IsEmpty())
            {
                return value;
            }
            else
            {
                StockNode current = this.head;
                decimal currentStockQty = current.StockHolding.Holdings;
                decimal currentStockPrice = current.StockHolding.CurrentPrice;

                while (current.Next != null)
                {
                    value = value + (currentStockQty * currentStockPrice);

                    current = current.Next;
                    currentStockQty = current.StockHolding.Holdings;
                    currentStockPrice = current.StockHolding.CurrentPrice;
                }
                value = value + (currentStockQty * currentStockPrice);
            }
            return value;
        }



        //param  (StockList) listToCompare     : StockList which has to compared for similarity index
        //summary      : finds the similar number of nodes between two lists
        //return       : similarty index
        //return type  : int
        public int Similarity(StockList listToCompare)
        {
            int similarityIndex = 0;
            StockNode listToCompareCurrent = listToCompare.head;
            StockNode listToComparePrevious = null;
            StockNode thisListCurrent = this.head;
            StockNode thisListPrevious = null;

            if (listToCompare.IsEmpty() || this.IsEmpty())
            {
                return similarityIndex;
            }
            else
            {
                while (thisListCurrent != null)
                {
                    while (listToCompareCurrent != null)
                    {
                        if (thisListCurrent.StockHolding.Symbol == listToCompareCurrent.StockHolding.Symbol)
                        {
                            similarityIndex++;

                            listToComparePrevious = listToCompareCurrent;
                            listToCompareCurrent = listToCompareCurrent.Next;
                        }
                        else
                        {
                            listToComparePrevious = listToCompareCurrent;
                            listToCompareCurrent = listToCompareCurrent.Next;
                        }
                    }
                    listToCompareCurrent = listToCompare.head;
                    listToComparePrevious = null;
                    thisListPrevious = thisListCurrent;
                    thisListCurrent = thisListCurrent.Next;
                }
                return similarityIndex;
            }
        }
        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("There is nothing to print.");
                Console.ReadLine();
            }
            else
            {
                StockNode current = this.head;
                StockNode previous = null;

                while (current.Next != null)
                {
                    Console.WriteLine("Stock Symbol: " + current.StockHolding.Symbol + "       " + "Stock Name: " +
                        current.StockHolding.Name + "       " + "Stock Holdings: " + current.StockHolding.Holdings + "       " +
                        "Current Price: " + current.StockHolding.CurrentPrice);

                    previous = current;
                    current = current.Next;
                }

                Console.WriteLine("Stock Symbol: " + current.StockHolding.Symbol + "       " + "Stock Name: " +
                        current.StockHolding.Name + "       " + "Stock Holdings: " + current.StockHolding.Holdings + "       " +
                        "Current Price: " + current.StockHolding.CurrentPrice);
            }

        }
    }
}
