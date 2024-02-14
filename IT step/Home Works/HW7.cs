using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW7
    {

        interface IRefuelable
        {
            double FuelCapacity { get; set; }
            double FuelStorage { get; set; }
            string FuelType { get; set; }
            void Refuel();
        }

        interface IDriveable
        {
            double MaxSpeed { get; set; }
            double CurrentSpeed { get; set; }
            void Drive();
        }



        abstract class Vehicle
        {
            public int WheelCount { get; set; }
            public double VehicleWeight { get; set; }
            public string Color { get; set; }
            public int SitCount { get; set; }
            public abstract void StartVehicle();
            public abstract void StopVehicle();
            public abstract void Brake();
            public abstract void Accelerate();
            protected bool IsOn { get; set; }
        }

        class Car : Vehicle, IRefuelable, IDriveable
        {
            public Car(double vehicleWeight, string color, double fuelCapacity, string fuelType, double maxSpeed, int sitCount)
            {
                VehicleWeight = vehicleWeight;
                Color = color;
                FuelCapacity = fuelCapacity;
                FuelType = fuelType;
                MaxSpeed = maxSpeed;
                SitCount = sitCount;
            }


            public double FuelCapacity { get; set; }
            public double FuelStorage { get; set; }
            public string FuelType { get; set; }
            public double MaxSpeed { get; set; }
            public double CurrentSpeed { get; set; }

            public override void Accelerate()
            {
                Console.WriteLine($"speed before accelerting = {CurrentSpeed}");
                Console.WriteLine("###ACCELERATING###");
                if (CurrentSpeed + 5 < MaxSpeed)
                {
                    CurrentSpeed += 5;
                }
                else
                {
                    Console.WriteLine("May be you don't care about other people's or your life, or breaking the law but at least\n" +
                        "think about your car you're going too fast and it's bad for the car :(");
                }

                Console.WriteLine($"Current speed= {CurrentSpeed}");
            }

            public override void Brake()
            {
                Console.WriteLine($"speed before brake= {CurrentSpeed}");
                Console.WriteLine("###BRAKING###");
                if (CurrentSpeed >= 20)
                {
                    CurrentSpeed -= 5;
                }
                else
                {
                    Console.WriteLine("No more brakes, Car is going very slow if you want to stop a car use stop function !!!");
                }

                Console.WriteLine($"Current speed= {CurrentSpeed}");
            }

            public async void Drive()
            {
                Console.WriteLine("Starting speed = " + 35);
                CurrentSpeed = 25;
                while (IsOn && CurrentSpeed > 0)
                {
                    await Task.Delay(3000);
                    FuelStorage -= 2;
                    Console.WriteLine($"Driving:\nCurrentSpeed= {CurrentSpeed} fuelStorage= {FuelStorage} ");
                }
            }

            public void Refuel()
            {
                Console.WriteLine("Filling fuel to the max");
                FuelStorage = FuelCapacity;
            }

            public override void StartVehicle()
            {
                Console.WriteLine("Starting Car burns some fuel");
                if (FuelCapacity > 2)
                {
                    IsOn = true;
                    FuelStorage -= 2;
                }
                else
                {
                    Console.WriteLine("Fuel is empty");
                }

            }

            public override void StopVehicle()
            {
                Console.WriteLine("stopping car");
                CurrentSpeed = 0;
                IsOn = false;
            }
        }


        class ElectricCar : Car
        {
            public ElectricCar(double vehicleWeight, string color, double fuelCapacity, string fuelType, double maxSpeed,
                int sitCount, double maxSelfDriveSpeed)
             : base(vehicleWeight, color, fuelCapacity, fuelType, maxSpeed, sitCount)
            {
                VehicleWeight = vehicleWeight;
                Color = color;
                FuelCapacity = fuelCapacity;
                FuelType = fuelType;
                MaxSpeed = maxSpeed;
                SitCount = sitCount;
                MaxSelfDriveSpeed = maxSelfDriveSpeed;
            }
            private double _maxSelfDriveSpeed;
            bool IsSelfdriveOn { get; set; }
            double MaxSelfDriveSpeed
            {
                get { return _maxSelfDriveSpeed; }
                set
                {
                    if (value >= MaxSelfDriveSpeed - 15)
                    { _maxSelfDriveSpeed = MaxSpeed - 15; }
                }
            }

            public void SelfDriveOff()
            {
                Console.WriteLine("Turnning off the selfdrive mode....");
                IsSelfdriveOn = false;
            }
            public async void SelfDrive()
            {
                if (IsOn)
                {
                    IsSelfdriveOn = true;
                }
                Console.WriteLine("Wow car is driving by itself driver can go to sleep");
                Console.WriteLine("Enter Crousing speed write 1 if you want current speed to be it: ");
                bool isInt = int.TryParse(Console.ReadLine(), out int speed);
                if (isInt && speed != 1 && speed < 15)
                {
                    Console.WriteLine(speed + " is too slow minimum speed is 15 so it will be set to 15");
                    CurrentSpeed = 15;
                }
                else if (isInt && speed > 15 && speed <= MaxSelfDriveSpeed)
                {
                    CurrentSpeed = speed;
                    Console.WriteLine("Crusing speed on self driving mode is set to " + speed);
                }
                else if (speed > MaxSelfDriveSpeed)
                {
                    Console.WriteLine(speed + " is too much for the car so we will set it to max speed");
                }
                while (IsSelfdriveOn && IsOn && CurrentSpeed > 0)
                {
                    await Task.Delay(3000);

                    Console.WriteLine("car going by itself...");
                }
            }


        }

        class Bicycle : Vehicle, IDriveable
        {

            public Bicycle(double maxSpeed, double currentSpeed)
            {
                MaxSpeed = maxSpeed;
                CurrentSpeed = currentSpeed;
            }

            public double MaxSpeed { get; set; }
            public double CurrentSpeed { get; set; }

            public override void Accelerate()
            {
                Console.WriteLine($"speed before accelerting = {CurrentSpeed}");
                Console.WriteLine("###ACCELERATING###");
                if (CurrentSpeed + 5 < MaxSpeed)
                {
                    CurrentSpeed += 2;
                }
                else
                {
                    Console.WriteLine("you are clearly not fit enough to accelerate more :(");
                }

                Console.WriteLine($"Current speed= {CurrentSpeed}");
            }

            public override void Brake()
            {
                Console.WriteLine($"speed before brake= {CurrentSpeed}");
                Console.WriteLine("###BRAKING###");
                if (CurrentSpeed >= 5)
                {
                    CurrentSpeed -= 2;
                }
                else
                {
                    Console.WriteLine("No more brakes, Bicycle is going very slow if you want to stop a bicycle just stop it !!!");
                }
            }

            public async void Drive()
            {
                Console.WriteLine("Starting speed = " + 35);
                CurrentSpeed = 15;
                while (IsOn && CurrentSpeed > 0)
                {
                    await Task.Delay(3000);
                    Console.WriteLine($"Driving:\nCurrentSpeed= {CurrentSpeed}");
                }
            }

            public override void StartVehicle()
            {
                Console.WriteLine("შევწიოთ დასაყრდენი ჯოხი...");

                IsOn = true;
            }

            public override void StopVehicle()
            {
                Console.WriteLine("დავაყენოთ და გამოვწიოთ დასაყრდენი ჯოხი...");
                CurrentSpeed = 0;
                IsOn = false;
            }
        }


    }
}
