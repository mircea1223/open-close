





List<InventoryItemModel> inventoryItems = new List<InventoryItemModel>();
List<IRentable> rentables = new List<IRentable>();
List<IPurchasable> purchasable = new List<IPurchasable>();

var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Renault Megane" };
var book = new BookModel { NumberOfPages = 450, ProductName = " The doors of perception" };
var excavator = new Excavator { ProductName = "Buldozer", QuantityInStock = 2 };

rentables.Add(vehicle);
rentables.Add(excavator);

purchasable.Add(book);
purchasable.Add(vehicle);

Console.Write("Do you want rent or purchase?: (rent, purchase) ");

string rentalDecision = Console.ReadLine();

if (rentalDecision.ToLower() == "rent")
{
    foreach(var item in rentables)
    {
        Console.WriteLine($"Item: {item.ProductName}");
        Console.Write("Do you want to rent this item(yes/no): ");
        string wantToRent = Console.ReadLine();

        if(wantToRent.ToLower() == "yes")
        {
            item.Rent();
        }

        Console.Write("Do you want to return this item(yes/no): ");
        string wantToReturn = Console.ReadLine();

        if (wantToReturn.ToLower() == "yes")
        {
            item.ReturnRent();
        }
    }
}else
{
    foreach (var item in purchasable)
    {
        Console.WriteLine($"Item: {item.ProductName }");
        Console.Write("Do you want to purchase this? (yes/no): ");
        string wantToPurchase = Console.ReadLine();

        if (wantToPurchase.ToLower() == "yes")
        {
            item.Purchase();
        }
    }

    
}

Console.WriteLine("done");
