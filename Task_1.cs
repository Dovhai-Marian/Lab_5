using System;
using System.Collections.Generic;

abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}

class Human
{
    public int Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Human is moving.");
    }
}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car is moving.");
    }
}

class Bus : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Bus is moving.");
    }
}

class Train : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Train is moving.");
    }
}

class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }
}

class TransportNetwork
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ControlMovement()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }

    public string CalculateOptimalRoute(Route route, Vehicle vehicle)
    {
        return $"Optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name}";
    }

    public void PassengerHandling(Vehicle vehicle)
    {
        Console.WriteLine($"Passenger handling for {vehicle.GetType().Name}");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car { Speed = 60, Capacity = 4 };
        Bus bus = new Bus { Speed = 50, Capacity = 20 };
        Train train = new Train { Speed = 80, Capacity = 200 };

        TransportNetwork transportNetwork = new TransportNetwork();
        transportNetwork.AddVehicle(car);
        transportNetwork.AddVehicle(bus);
        transportNetwork.AddVehicle(train);

        transportNetwork.ControlMovement();

        Route route = new Route { StartPoint = "A", EndPoint = "B" };
        Console.WriteLine(transportNetwork.CalculateOptimalRoute(route, car));

        transportNetwork.PassengerHandling(bus);
    }
}
