





















public class Excavator : InventoryItemModel, IRentable
{
    public void Dig()
    {
        Console.WriteLine("Digging");
    }

    public void Rent()
    {
        QuantityInStock -= 1;
        Console.WriteLine("This excavator has been rented");
    }

    public void ReturnRent()
    {
        QuantityInStock += 1;
        Console.WriteLine("This excavator has been returned");
    }
}