namespace CSharpBicycleProject;

internal class SampleReceipt
{
    private decimal total = 0.0m;
    private List<IBicycle> cartList;
    private List<IBikeOption> cartOptionsList;

    public SampleReceipt(List<IBicycle> bikeList, List<IBikeOption> optionList)
    {
        cartList = bikeList;
        cartOptionsList = optionList;

        // Show title
        ShowTitle();
        // Show colunm header
        ShowColumnHeader();
        // Show cart
        ShowCart();
        // Prep for Sale

    } // end Sample Receipt

    private void ShowCart()
    {
        foreach (IBicycle bike in cartList)
        {
            Console.WriteLine($"{bike.GetType().Name,9} {bike.Price,26}");
            Console.WriteLine($"{bike.FrameColor} Frame Color");
            Console.WriteLine($"Model #:{bike.Model}");
            Console.WriteLine($"Serial Number: {bike.SerialNumber}");
        } // end foreach
        if (cartOptionsList.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("   Custom Options");
            foreach(IBikeOption option in cartOptionsList)
            {
                Console.WriteLine($"{option.OptionType,9} {option.OptionAmount,14}");
                total += option.OptionAmount;
            } // end foreac

        } // end if

        ShowDashes();
        Console.WriteLine($"  Subtotal  {"$" + total,24}");
        Console.WriteLine($"  Assembly Cost {"$49.99",19}");
        total += 49.99m;
        ShowDashes();
        Console.WriteLine($"  Total {"$" + total,28}");

    } // end class

    private void ShowTitle()
    {
        Console.WriteLine($"{"ACME BICYCLE COMPANY",30}");
        Console.WriteLine($"{"123 Main st, City, st, Zip",33}");
        Console.WriteLine($"{"(000) 000 - 0000",27}");
        Console.WriteLine($"{"MONEY RECEIPT",27}");

    } // end class

    private void ShowColumnHeader()
    {
        Console.WriteLine($"| Description ");
        Console.WriteLine($"{" | Price |",23}");
    }


    private void ShowDashes()
    {
        for(int i = 0; i < 40; ++i)
        {
            Console.Write("-");
        } // end for
        Console.WriteLine();
    } // end class

} // end class
