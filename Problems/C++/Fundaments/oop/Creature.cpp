#pragma once

using namespace std;
#include <iostream>
#include <string>
#include <cstdlib>
#include "./headers/Creature.h"

Creature::Creature(string name, int age, int weight)
{
    this->name = name;
    this->age = age;
    this->weight = weight;
    this->happiness = 10;
    this->isAlive = true;
    this->hunger = 10;
    this->thirst = 10;
    this->stamina = 1;
    this->staminaProgress = 0;
    this->stressFree = 0;
    this->stressFreeProgress = 0;
    this->stress = 0;
};

Creature::~Creature(){

};

string Creature::getName() { return this->name; }

int Creature::getWeight() { return this->weight; }

int Creature::getHealth() { return this->health; }

double Creature::getEnergy() { return this->energy; }

int Creature::getStamina() { return this->stamina; }

int Creature::getStaminaProgress() { return this->staminaProgress; }

int Creature::getStressFree() { return this->stressFree; }

int Creature::getStressFreeProgress() { return this->stressFreeProgress; }

int Creature::getHappiness() { return this->happiness; }

int Creature::getStress() { return this->stress; }

int Creature::getAge() { return this->age; }

bool Creature::getIsAlive() { return this->isAlive; }

void healthCheck(Creature *creature, string cause)
{
    if (creature->getHealth() <= 50)
    {
        cout << "Warning! Your Health is realy bad! If you continue living this way you will DIE soon!" << endl;
    }
    else if (creature->getHealth() <= 0)
    {
        creature->Die(cause);
    }
}

void stressCheck(Creature *creature)
{
    if (creature->getStress() < 50)
    {
        cout << "Stress Level increased to " << creature->getStress() << endl;
    }
    else
    {
        cout << "Critical Stress Level! You have a " << creature->getStress() - 50
             << "% chance of committing SUICIDE while performing tasks that decrease your Happiness Level such as Study, Work etc." << endl;
    }
}

void suicideRisk(Creature *creature)
{
    if (creature->getStress() >= 50)
    {
        int rng = rand() % 50;
        if (rng <= creature->getStress() - 50)
        {
            creature->Die("suicide");
        }
    }
}

void Creature::Obese()
{
    if (this->weight >= 100)
    {
        cout << "You are obese! Your current weight is " << this->weight << ". If you reach a weight of 120 kg you will DIE!" << endl;
    }
    else if (this->weight >= 120)
    {
        this->Die("obesity");
    }
}

void Creature::Starve()
{
    if (this->hunger < 0)
    {
        int damage = abs(this->hunger) * 8;

        this->hunger = 0;

        this->health -= damage;

        cout << this->name << " lost " << damage << " Health Points due to stomach ache." << endl;

        healthCheck(this, "starvation");
    }
}

void Creature::Dehydrate()
{
    if (this->thirst < 0)
    {
        int damage = abs(this->thirst) * 10;

        this->thirst = 0;

        this->health -= damage;

        cout << this->name << " lost " << damage << " Health Points due to dehydration." << endl;

        healthCheck(this, "dehydration");
    }
}

void Creature::Depress()
{
    suicideRisk(this);

    if (this->happiness < 0)
    {
        int damage = abs(this->happiness) * 10;

        this->happiness = 0;

        this->health -= damage;
        this->stress += damage / this->stressFree;

        cout << this->name << " lost " << damage << " Health Points due to depression." << endl;

        healthCheck(this, "depression");
        stressCheck(this);
    }
}

void Creature::Exhaust()
{
    if (this->energy == 0)
    {
        this->health -= 5;

        cout << this->name << " lost " << 5 << " Health Points due to exhaustion." << endl;

        healthCheck(this, "body failure");
    }
}

bool Creature::Eat(int amount)
{
    if (this->hunger - amount <= 10)
    {
        cout << this->name << " ate " << amount << " food" << endl;

        this->weight += amount / this->stamina;
        this->energy++;
        this->hunger += amount;

        this->Obese();

        if (this->energy > 10)
        {
            this->energy = 10;
        }

        return true;
    }
    else
    {
        cout << this->name << " will overeat with this amount of food!" << endl;

        return false;
    }
}

bool Creature::Drink(int amount)
{
    if (this->thirst - amount <= 10)
    {
        cout << this->name << " drank " << amount << " liquids" << endl;

        this->energy++;
        this->thirst += amount;

        if (this->energy > 10)
        {
            this->energy = 10;
        }

        return true;
    }
    else
    {
        cout << this->name << " will overdrink with this amount of liquids!" << endl;

        return false;
    }
}

bool Creature::Sleep(int hours)
{
    if (hours == 8 - this->stressFree)
    {
        this->energy = 10;
        this->happiness++;
        this->stressFreeProgress += this->happiness / 5;

        if (this->happiness > 10)
        {
            this->happiness = 10;
        }

        if (this->stressFreeProgress >= 100)
        {
            this->stressFreeProgress -= 100;
            this->stressFree++;

            cout << this->name << " has Leveled Up their Stress Free Potential to level : " << this->stressFree << endl;
        }
    }
    else
    {
        this->energy = 10 - abs(hours - 8);
    }

    cout << this->name << " slept for " << hours << " hours." << endl;

    return true;
}

bool Creature::Rest(int hours)
{
    this->energy += hours;
    this->stressFreeProgress += this->happiness / 3;

    if (this->energy > 10)
    {
        this->energy = 10;
    }

    cout << this->name << " rested for " << hours << " hours." << endl;

    if (this->stressFreeProgress >= 100)
    {
        this->stressFreeProgress -= 100;
        this->stressFree++;

        cout << this->name << " has Leveled Up their Stress Free Potential to level : " << this->stressFree << endl;
    }

    return true;
}

bool Creature::Train(int hours)
{
    if (this->energy - hours / this->stamina >= 0)
    {
        int initWeight = this->weight;

        if (this->weight > 60 - hours)
        {
            this->weight -= hours;
        }

        this->energy -= hours / this->stamina;
        this->hunger--;
        this->thirst--;
        this->staminaProgress++;

        this->Starve();
        this->Dehydrate();
        this->Exhaust();

        if (this->staminaProgress >= 25)
        {
            this->staminaProgress -= 25;
            this->stamina++;

            cout << this->name << " has Leveled Up their Stamina Potential to level : " << this->stamina << endl;
        }

        cout << this->name << " has trained for " << hours << " and lost " << initWeight - this->weight << " kgs of weight." << endl;

        return true;
    }
    else
    {
        cout << this->name << " will be too exhausted from that much training!" << endl;
        return false;
    }
}

void Creature::Die(string cause)
{
    cout << this->name << " has died... Cause of Death : " << cause << endl;
    this->isAlive = false;

    if (this->creatureType == "Human")
    {
        double ageScore = this->age * 36;
        double happinessScore = this->happiness * 20;
        double weightScore = (60 - this->weight) + 100;
        double healthScore = this->age / 60 * this->health;
        double staminaScore = this->stamina * 50;
        double stressFreeScore = this->stressFree * 20;
        double stressScore = -this->stress * 15;

        double totalScore = ageScore + happinessScore + weightScore + healthScore + staminaScore + stressFreeScore + stressScore;

        cout << "\nAge : 36 x age = " << ageScore << "\nHappiness : 20 x happines = " << happinessScore
             << "\nWeight : (60 - weight) + 100 = " << weightScore << "\nHealth : age / 60 x health = " << healthScore << "\nStamina : 50 x stamina = "
             << staminaScore << "\nStress Free : 20 x stress free = " << stressFreeScore << "\nStress : -15 * stress = " << stressScore << endl;

        cout << "\n----Total Score---- : " << totalScore << endl;
    }
}