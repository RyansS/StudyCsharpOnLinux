

    interface IMove
    {
        void MoveForward();
        void MoveBackwards();
    }

abstract class Vehicle
{
    public string Color {get; set;}

    public int Year {get; set;}

    public string Model {get; set;}

    public int Seats {get; set;}

    public Vehicle (string color, int year, string model, int seats)
    {
        Color = color;
        Year = year;
        Model = model;
        Seats = seats;
    }

    public void BeDriven ()
    {
        
    }


}

class Car : Vehicle, IMove
{
    public int Doors {get; set;}
    public void MoveForward()
    {
        Console.WriteLine("Car is moving forward!");
    }

        public void MoveBackwards()
    {
        Console.WriteLine("Car is moving backwards!");
    }

    public Car (string color, int year, string model, int seats, int doors) : base (color, year, model, seats)
    {
        Doors = doors;
        
    }

}  

class Boat : Vehicle, IMove
{
    
}

class Airplane : Vehicle, IMove
{
    
}

