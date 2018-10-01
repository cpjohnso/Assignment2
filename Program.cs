using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stockOne = new Stock("GOOG", "Google", 1.2m, 6.27m);
            Stock stockTwo = new Stock("MSFT", "Microsoft", 5m, 111.2m);
            Stock stockThree = new Stock("AAPL", "Apple", 6m, 222.7m);
            Stock stockFour = new Stock("AMZN", "Amazon", 1.2m, 198.7m);
            Stock stockFive = new Stock("Z", "Zillow", 2.4m, 207.6m);
            Stock stockSix = new Stock("B", "Barnes ", 2.2m, 68.7m);
            Stock stockSeven = new Stock("GOOG", "Google", 3.6m, 115.3m);
            Stock stockEight = new Stock("AAPL", "Apple", 5m, 147.6m);
            Stock stockNine = new Stock("GOOG", "Google", 1.2m, 6.27m);

            ClientPortfolio client1 = new ClientPortfolio("Andrew", "Mountain View", "555-111-9070");
            client1.StockList.AddStock(stockOne); // GOOG
            client1.StockList.AddStock(stockTwo); // MSFT
            client1.StockList.AddStock(stockThree); // AAPL
            client1.StockList.AddStock(stockFour); // AMZN
            client1.StockList.AddStock(stockNine); //GOOG

            Console.WriteLine("**************************Client-1 Portfolio*****************************************");
            Console.WriteLine("");
            client1.StockList.Print();
            Console.WriteLine("");
            Console.WriteLine("Number of shares :" + client1.StockList.Length());
            Console.WriteLine("Current value of portfolio for client 1 :" + client1.GetPortfolioValue());
            Console.WriteLine("Stock with most shares for client 1:" + client1.StockList.MostShares());
            Console.WriteLine("");
            client1.StockList.SortByValue();
            Console.WriteLine("");
            Console.WriteLine("Portfolio sorted in descending order by number of holdings for client 1:");//good
            client1.StockList.Print();

            Console.WriteLine("");
            Console.WriteLine("**************************Client-2 Portfolio*****************************************");
            Console.WriteLine("");
            ClientPortfolio client2 = new ClientPortfolio("Chris", "New York", "435-111-000");
            client2.StockList.AddStock(stockFive); // Z
            client2.StockList.AddStock(stockSix); //B
            client2.StockList.AddStock(stockSeven); // GOOG
            client2.StockList.AddStock(stockEight); //AAPL

            client2.StockList.Print();//good
            Console.WriteLine("");
            Console.WriteLine("Number of shares :" + client2.StockList.Length());// good
            Console.WriteLine("Current value of portfolio for client 2 :" + client2.GetPortfolioValue());
            Console.WriteLine("Stock with most shares for client 2 :" + client2.StockList.MostShares());
            Console.WriteLine("");
            client2.StockList.SortByValue();
            Console.WriteLine("Portfolio sorted in descending order by number of holdings for client 2:");
            client2.StockList.Print();
            Console.WriteLine("");
            client2.StockList.SortByName();
            Console.WriteLine("Portfolio sorted in alphabetical order for client 2:");
            client2.StockList.Print();
            Console.WriteLine("");
            Console.WriteLine("Similarity Index for Client-1 and Client-2 :" + client1.StockList.Similarity(client2.StockList));
            Console.WriteLine("");
            Console.WriteLine("**************************Client-1,Client -2 Merged Portfolio*****************************************");
            Console.WriteLine("");
            StockList mergedPortfolio = client1.StockList.MergeList(client2.StockList);
            mergedPortfolio.Print();

            Console.ReadLine();
        }
    }
}
