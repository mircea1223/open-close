







List<Cars> cars = new List<Cars>
{
    new Cars { Collor = "red", Is4x4 = true, NumberOfSeats = 4, Name = "Tahoma" },
    new Cars { Collor = "blue", Is4x4 = true, NumberOfSeats = 4, Name = "Sultan" },
    new Cars { Collor = "Yellow", Is4x4 = true, NumberOfSeats = 4, Name = "Huntley" }
};

foreach (var car in cars)
{
    Console.WriteLine(car.Name, car.Collor, car.Is4x4,car.IsRented);
}



