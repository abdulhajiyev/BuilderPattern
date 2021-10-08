using BuilderPattern;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IBuilder
    {
        public IBuilder Reset();
        public IBuilder SetSeats(int number);
        public IBuilder SetEngine(double engine);
        public IBuilder SetTripComputer(bool tripComputer);
        public IBuilder SetGps(bool gps);
    }

    public class Car
    {
        public int Seats { get; set; }
        public double Engine { get; set; }
        public bool TripComputer { get; set; }
        public bool Gps { get; set; }

        public override string ToString() =>
            @$"Seats: {Seats}
Engine: {Engine}
Tripcomputer: {TripComputer}
Gps: {Gps}";
    }

    public class Manual
    {
        public int Seats { get; set; }
        public double Engine { get; set; }
        public bool TripComputer { get; set; }
        public bool Gps { get; set; }

        public override string ToString() =>
            @$"Seats: {Seats}
Engine: {Engine}
Tripcomputer: {TripComputer}
Gps: {Gps}";
    }
}

public class CarManualBuilder : IBuilder
{
    public Manual Manual { get; set; }

    public IBuilder Reset()
    {
        throw new NotImplementedException();
    }

    public IBuilder SetSeats(int number)
    {
        throw new NotImplementedException();
    }

    public IBuilder SetEngine(double engine)
    {
        throw new NotImplementedException();
    }

    public IBuilder SetTripComputer(bool tripComputer)
    {
        throw new NotImplementedException();
    }

    public IBuilder SetGps(bool gps)
    {
        throw new NotImplementedException();
    }
}

public class CarBuilder : IBuilder
{
    public Car Car { get; set; }

    public IBuilder Reset()
    {
        throw new NotImplementedException();
    }

    public IBuilder SetSeats(int number)
    {
        throw new NotImplementedException();
    }

    public IBuilder SetEngine(double engine)
    {
        throw new NotImplementedException();
    }

    public IBuilder SetTripComputer(bool tripComputer)
    {
        throw new NotImplementedException();
    }

    public IBuilder SetGps(bool gps)
    {
        throw new NotImplementedException();
    }
}