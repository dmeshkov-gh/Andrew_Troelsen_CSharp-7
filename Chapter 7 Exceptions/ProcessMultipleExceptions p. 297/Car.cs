using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProcessMultipleExceptions_p._297
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
                if (delta < 0)
                    throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero!");
                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    _carIsDead = true;
                    CarIsDeadException ex = new CarIsDeadException($"{PetName} has overheated!", "You have a lead foot", DateTime.Now);
                    throw ex;
                }
                else
                    Console.WriteLine("Current speed = {0}", CurrentSpeed);
            }
        }
    }
}
