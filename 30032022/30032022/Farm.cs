using _30032022.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal class Farm
    {
        public int SheepLimit { get; set; }
        public int HorseLimit { get; set; }

        Animal[] _animals = new Animal[0];
        public Animal[] Animals { get => _animals; }
        int _sheepCount;
        int _horseCount;


        public void AddAnimal(Animal animal)
        {
            if (_animals.Length < SheepLimit + HorseLimit)
            {
                if (animal is Horse)
                {
                    if (_horseCount < HorseLimit)
                    {
                        Array.Resize(ref _animals, _animals.Length + 1);
                        _animals[_animals.Length - 1] = animal;
                        _horseCount++;
                    }
                    else
                        throw new HorseCountOutOfRangeException("Atlarin limiti dolub!");
                }
                else if(animal is Sheep)
                {
                    if (_sheepCount < SheepLimit)
                    {
                        Array.Resize(ref _animals, _animals.Length + 1);
                        _animals[_animals.Length - 1] = animal;
                        _sheepCount++;
                    }
                    else
                        throw new SheepCountOutOfRangeException("Qoyun limiti dolub!");
                }
                else 
                    throw new AnimalIsNotAllowedException("Bu heyvan novu qebul edilmir!");
            }
            else
            {
                throw new AnimalLimitOutOfRangeException("Ferma dolub!");
            }

        }
    }
}
