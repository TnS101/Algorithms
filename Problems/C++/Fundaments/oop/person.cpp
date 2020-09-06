using namespace std;
#include <iostream>
#include <string>
#include  <cstdlib>

class Person
{
    private:
        string name;
        int age;
        string gender;
        int weight;
        int health;
        int energy;
        int money;
        int happiness;
    public:
        Person(string name, int age, string gender, int weight)
        {
            this->name = name;
            this->age = age;
            this->gender = gender;
            this->weight = weight;
            this->health = 100;
            this->energy = 10;
            this->happiness = 10;
            this->money = 1000;
        }

        string getName() {return this->name;}

        int getAge() {return this->age;}

        string getGender() {return this->gender;}

        int getWeight() {return this->weight;}

        int getHealth() {return this->health;}

        int getEnergy() {return this->energy;}

        int getMoney() {return this->money;}

        int getHappiness() {return this->happiness;}

        void Eat(int amount)
        {
            cout << this->name << " has ate " << amount << " food" << endl;
            this->weight += amount;
            this->energy++; 
        }

        void Sleep(int hours)
        {
            if (hours == 8)
            {
                this->energy = 10;
                this->happiness++;
            }
            else
            {
                this->energy = 10 - abs(hours - 8);
            }
        }
};


int main()
{
    Person person("Pe6o", 36, "Male", 59);

    return 0;
}