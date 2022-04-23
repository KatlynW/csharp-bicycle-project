namespace CSharpBicycleProject;
/*
 Sample Order will be based on prchasing 1 bicycle. 
We can improve this by handling more than 1 bicycle 
this handling has to do with the custom options and
how they tie in per bicycle. This could be a simple fix
like a property of a custom options list
 */
internal class SampleOrder
{
    private List<IBicycle> bikeOrder;
    private List<IBikeOption> bikeOptions;
    private SampleInventory inventory;
    private IBicycle bikeChoice;

    public SampleOrder()
    {
        bikeOrder = new List<IBicycle>();
        bikeOptions = new List<IBikeOption>();
        inventory = new SampleInventory();
    } // end Sample

    public void WelcomeMessage()
    {
        Console.WriteLine("Welcome to ACME Bicycle Company");
        Console.WriteLine("Your one stop shop for Road and Mountain Bikes");
        BuyBike();
    } // end Welcome

    private void BuyBike()
    {
        Console.WriteLine("What kind of bike would you like to buy today?");
        Console.WriteLine("Your Options are:\n" +
            "c - CrossCountry\n" +
            "d - DownHill\n" +
            "t - Touring\n" +
            "v - Vintage");

    string type = Console.ReadLine();
    // validate the type
    ValidateType(type.ToLower());
    // custom options
    CustomOptions();
        // add to order
        bikeOrder.Add(bikeChoice);
        // send order to receipt
        new SampleReceipt(bikeOrder, bikeOptions);
    } // end Buy Bike

    public void CustomOptions()
    {
        Console.WriteLine("We offer various custom options for your bike.");
        Console.WriteLine("What options would you like?");
        Console.WriteLine("ls - Leather Seat\n" +
            "lg - Leather Grips\n" +
            "gf - Gold Painted Frame\n" +
            "wt - White Tires\n" +
            "n - None");
        string option = Console.ReadLine();
        // Validate options
    }

    private void ValidateOptions(string options)
    {
        switch (options)
        {
            case "ls":
                bikeOptions.Add(new LeatherSeat());
                break;
            case "lg":
                bikeOptions.Add(new LeatherGrips());
                break;
            case "gf":
                bikeOptions.Add(new GoldFrame());
                break;
            case "wt":
                bikeOptions.Add(new WhiteTires());
                break;
            default:
                Console.WriteLine("You have made an invalid choice.");
                CustomOptions();
                break;

        } // end switch
    } // end validate Options

    private void ValidateType(string type)
    {
        switch (type)
        {
            case "c":
                bikeChoice = inventory.CrossCountryList.ElementAt(0);
                inventory.CrossCountryList.RemoveAt(0);
                break;
            case "d":
                bikeChoice = inventory.DownHillList.ElementAt(0);
                inventory.DownHillList.RemoveAt(0);
                break;
            case "t":
                bikeChoice = inventory.TouringList.ElementAt(0);
                inventory.TouringList.RemoveAt(0);
                break;
            case "v":
                bikeChoice = inventory.VintageList.ElementAt(0);
                inventory.VintageList.RemoveAt(0);
                break;
            default:
                Console.WriteLine("You have entered an incorrect value");
                BuyBike();
                break;
        } // end switch
    }// end validate

} // end class
