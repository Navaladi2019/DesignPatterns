using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterncSharp.CreationalDesignPattern.Builder
{
    public class BuilderClient
    {
        void main()
        {
            var director = new Director();
          var car1=  director.BuildSportsNoSunRoofCar(new SportsCarBuilder());
          var car2 = director.BuildSuvCar(new SUVCarBuilder());


        }
    }
    public class Director
    {

        public Car BuildSuvCar(Builder builder)
        {
            builder.SetSeats();
            builder.SetSunRoof();
            builder.SetEngine();
            builder.SetTyres();
            return builder.GetCar();
        }

        public Car BuildSportsCar(Builder builder)
        {
            builder.SetSeats();
            builder.SetSunRoof();
            builder.SetEngine();
            builder.SetTyres();
            return builder.GetCar();
        }

        public Car BuildSportsNoSunRoofCar(Builder builder)
        {
            builder.SetSeats();
            builder.SetEngine();
            builder.SetTyres();
            return builder.GetCar();
        }
    }

    public interface Builder
    {
        void SetSeats();
        void SetEngine();
        void SetSunRoof();
        void SetTyres();
        Car GetCar();
    }

    public class SUVCarBuilder : Builder
    {

        private Car car = new Car();

        public Car GetCar()
        {
            return car;
        }

        public void SetEngine()
        {
            car.Engine = "Tata ";
        }

        public void SetSeats()
        {
            car.Seats = 2;
        }

        public void SetSunRoof()
        {
            car.SunRoof = true;
        }

        public void SetTyres()
        {
            car.TyreType = "SUV";
        }
    }

    public class SportsCarBuilder : Builder
    {

        private Car car= new Car();

        public void SetEngine()
        {
            car.Engine = "Ferari ";
        }
        public Car GetCar()
        {
            return car;
        }
        public void SetSeats()
        {
            car.Seats = 2;
        }

        public void SetSunRoof()
        {
            car.SunRoof = true;
        }

        public void SetTyres()
        {
            car.TyreType = "Sports";
        }
    }
    public class Car
    {
        public string Engine { get; set; }
        public string TyreType { get; set; }
        public bool SunRoof { get; set; }
        public int Seats { get; set; }
    }
}
