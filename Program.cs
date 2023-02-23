using ObjectOrientedPrograms;

namespace ObjectOrientedPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\kundan\\Desktop\\Bridgelab\\rfp257\\ObjectOrientedPrograms\\ObjectOrientedPrograms\\Stock.json";
            FetchInventory fetchInventory = new FetchInventory();

            StockPortfolio data = fetchInventory.Read(path);
            Console.WriteLine("Stock Portfolio");
            Console.WriteLine("**************************");
            int totalStock = 0;
            for (int i = 0; i < data.typesOfStock.Count; i++)
            {
                Console.WriteLine(data.typesOfStock[i].name);
                Console.WriteLine(data.typesOfStock[i].numberOfShare);
                Console.WriteLine(data.typesOfStock[i].price);

                int price = data.typesOfStock[i].numberOfShare * data.typesOfStock[i].price;

                totalStock = totalStock + price;
                Console.WriteLine("The price of {1} shares of the {0} stock is : {2}", data.typesOfStock[i].name, data.typesOfStock[i].numberOfShare, price);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("The total value of your stock is {0}", totalStock);



            //Console.WriteLine("Types Of Rice");
            //Console.WriteLine("**************************");
            //for (int i = 0; i < data.typesOfRice.Count; i++)
            //{
            //    Console.WriteLine(data.typesOfRice[i].name);
            //    Console.WriteLine(data.typesOfRice[i].weight);
            //    Console.WriteLine(data.typesOfRice[i].price);

            //    int price = data.typesOfRice[i].weight * data.typesOfRice[i].price;
            //    Console.WriteLine("The price of {0} for {1}kg is {2}", data.typesOfRice[i].name, data.typesOfRice[i].weight, price);
            //}

            //Console.WriteLine("**************************");
            //Console.WriteLine("Types Of Pulses");
            //Console.WriteLine("**************************");
            //for (int i = 0; i < data.typesOfPulses.Count; i++)
            //{
            //    Console.WriteLine(data.typesOfPulses[i].name);
            //    Console.WriteLine(data.typesOfPulses[i].weight);
            //    Console.WriteLine(data.typesOfPulses[i].price);

            //    int price = data.typesOfPulses[i].weight * data.typesOfPulses[i].price;
            //    Console.WriteLine("The price of {0} for {1}kg is {2}", data.typesOfPulses[i].name, data.typesOfPulses[i].weight, price);
            //}

            //Console.WriteLine("**************************");
            //Console.WriteLine("Types Of Wheat");
            //Console.WriteLine("**************************");

            //for (int i = 0; i < data.typesOfWheat.Count; i++)
            //{
            //    Console.WriteLine(data.typesOfWheat[i].name);
            //    Console.WriteLine(data.typesOfWheat[i].weight);
            //    Console.WriteLine(data.typesOfWheat[i].price);

            //    int price = data.typesOfWheat[i].weight * data.typesOfWheat[i].price;
            //    Console.WriteLine("The price of {0} for {1}kg is {2}", data.typesOfWheat[i].name, data.typesOfWheat[i].weight, price);

            //}



        }
    }
}