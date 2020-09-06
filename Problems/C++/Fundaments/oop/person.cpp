using namespace std;
#include <iostream>
#include <string>
#include <cstdlib>
#include "./headers/Person.h"
#include "Creature.cpp"

Person::Person(string name, int age, string gender, int weight) : Creature(name, age, weight)
{
    this->gender = gender;
    this->health = 100;
    this->energy = 10;
    this->money = 0;
}

Person::~Person()
{
    
};

string Person::getGender() { return this->gender; }

int Person::getMoney() { return this->money; }

void Person::Die()
{
    cout << this->name << " has died..." << endl;
    this->isAlive = false;

    double ageScore = this->age * 36;
    double moneyScore = this->money / 200;
    double happinessScore = this->happiness * 20;
    double weightScore = (60 - this->weight) + 100;
    double healthScore = this->age / 60 * this->health;
    double staminaScore = this->stamina * 50;
    double stressFreeScore = this->stressFree * 20;
    double stressScore = -this->stress * 15;

    double totalScore = ageScore + moneyScore + happinessScore + weightScore + healthScore + staminaScore + stressFreeScore + stressScore;

    cout << "Age : 36 x age = " << ageScore << "\nMoney : 200 / money = " << moneyScore << "\nHappiness : 20 x happines = " << happinessScore
         << "\nWeight : (60 - weight) + 100 = " << weightScore << "\nHealth : age / 60 x health = " << healthScore << "\nStamina : 50 x stamina = "
         << staminaScore << "\nStress Free : 20 x stress free = " << stressFreeScore << "\nStress : -15 * stress = " << stressScore << endl;

    cout << "Total Score : " << totalScore << endl;
}