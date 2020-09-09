using namespace std;
#include <string>
#include "./headers/Animal.h"
#include "Creature.cpp"
#include <memory>

Animal::Animal(string name, string animalType, int age, int weight, int buyPrice, Person *owner) : Creature(name, age, weight)
{
    this->animalType = animalType;
    this->owner = owner;
    this->buyPrice = buyPrice;
};

Animal::~Animal()
{
}

int Animal::Play()
{
    if (this->thirst < 10)
    {
        cout << this->name << " is too thirsty! Give it something to drink." << endl;
        return 0;
    }
    else if (this->hunger < 10)
    {
        cout << this->name << " is too hungry! Give it something to eat." << endl;
        return 0;
    }
    else if (this->energy - 4 / this->stamina < 0)
    {
        cout << this->name << " is exhausted! Let it rest for a little bit." << endl;
        return 0;
    }
    else
    {
        int happiness = this->happiness / 3;

        this->thirst = 0;
        this->hunger = 0;
        this->happiness = 10;
        this->energy -= 4 / this->stamina;

        cout << this->owner->getName() << " has played with " << this->name << " <3 !" << this->owner->getName() << " recieved " << happiness << " happiness." << endl;

        return happiness;
    }
}
