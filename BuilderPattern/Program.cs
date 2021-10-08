using BuilderPattern;
using System;

namespace BuilderPattern
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Director director  = new Director();
            CarBuilder builder = new CarBuilder();
            CarManualBuilder manualBuilder = new CarManualBuilder();
            director.MakeSportsCar(builder);
            director.MakeSUV(manualBuilder);
            Car car = builder.GetCar();
            Manual manual = manualBuilder.GetManual();

            Console.WriteLine(car);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(manual);
        }
    }

    public interface IBuilder
    {
        public IBuilder Reset();
        public IBuilder SetSeats(int number);
        public IBuilder SetEngine(double engine);
        public IBuilder SetTripComputer();
        public IBuilder SetGps();
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

    public class CarManualBuilder : IBuilder
    {
        private Manual Manual { get; set; } = new();

        public IBuilder Reset()
        {
            Manual = new Manual();
            return this;
        }

        public IBuilder SetSeats(int number)
        {
            Manual.Seats = number;
            return this;
        }

        public IBuilder SetEngine(double engine)
        {
            Manual.Engine = engine;
            return this;
        }

        public IBuilder SetTripComputer()
        {
           Manual.TripComputer = true;
           return this;
        }

        public IBuilder SetGps()
        {
            Manual.Gps = true;
            return this;
        }

        public Manual GetManual() => Manual;
    }

    public class CarBuilder : IBuilder
    {
        private Car Car { get; set; }

        public IBuilder Reset()
        {
            Car = new Car();
            return this;
        }

        public IBuilder SetSeats(int number)
        {
            Car.Seats = number;
            return this;
        }

        public IBuilder SetEngine(double engine)
        {
            Car.Engine = engine;
            return this;
        }

        public IBuilder SetTripComputer()
        {
            Car.TripComputer = true;
            return this;
        }

        public IBuilder SetGps()
        {
            Car.Gps = true;
            return this;
        }

        public Car GetCar() => Car;
    }

    public class Director
    {
        public void MakeSUV(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(6);
            builder.SetEngine(3.8);
            builder.SetTripComputer();
            builder.SetGps();
        }

        public void MakeSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine(2.4);
            builder.SetTripComputer();
            builder.SetGps();
        }
    }
}