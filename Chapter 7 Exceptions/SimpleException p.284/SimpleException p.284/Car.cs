﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleException_p._284
{
    class Car
    {
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        private bool _carIsDead;
        private Radio theMusixBox = new Radio();
        public Car() {}
        public Car(string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }
        public void CrankTunes(bool state)
        {
            theMusixBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if(_carIsDead)
                Console.WriteLine("{0} is out of order!", PetName);
            else
            {
                CurrentSpeed += delta;
                if(CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    _carIsDead = true;
                    Exception ex = new Exception($"{PetName} has been overheated!")
                    {
                        HelpLink = "https://www.carsrus.com"
                    };

                    ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}");
                    ex.Data.Add("Cause", "You have a lead foot");
                    throw ex;
                }
                else
                    Console.WriteLine("Current speed = {0}", CurrentSpeed);
            }
        }
    }
}
