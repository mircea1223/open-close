

using Magazin;

public class VehicleShop : Shop
{
    protected List<Car> cars { get; set; }

    public VehicleShop(Employee firstEmployee) : base(firstEmployee)
    {
        cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void RemoveCar(int VehicleId)
    {
        foreach(Car car in cars)
        {
            if(car.Id == VehicleId)
                cars.Remove(car);
        }
    }

    public Car? RentCar()
    {
        foreach(Car car in cars)
        {
            if (!car.IsRented)
                return car;
        }
        return null;
    }



}



