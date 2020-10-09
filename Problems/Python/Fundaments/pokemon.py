from random import randint

class Passive:
    def __init__(self, name, conditionAttr, value, operator, rewardAttr, rewardValue):
        self.name = name
        self.conditionAttr = conditionAttr
        self.value = value
        self.operator = operator
        self.rewardAttr = rewardAttr
        self.rewardValue = rewardValue
    
    def isSatisfied(self, target):
        targetValue = target.__getattribute__(self.conditionAttr.lower)
        successMessage = 'Condition for Attribute : {} is satisfied! {} {} {} == true!'
        errorMessage = 'Condition for Attribute : {} was not satisfied! {} {} {} == False!'

        if self.operator == '>':
            if self.value > targetValue:
               print(successMessage.format(self.conditionAttr, self.value, self.operator, targetValue))
            else:
                print(errorMessage.format(self.conditionAttr, self.value, self.operator, targetValue))
                return False

        if self.operator == '<':
            if self.value < targetValue:
               print(successMessage.format(self.conditionAttr, self.value, self.operator, targetValue))
            else:
                print(errorMessage.format(self.conditionAttr, self.value, self.operator, targetValue))
                return False

        if self.operator == '=':
            if self.value == targetValue:
                print(successMessage.format(self.conditionAttr, self.value, self.operator, targetValue))
            else:
                print(errorMessage.format(self.conditionAttr, self.value, self.operator, targetValue))
                return False

        target.__setattr__(self.rewardAttr, targetValue + self.rewardValue)
        return True


class EvolutionStone:
    def __init__(self, name, pokemonName, price):
        self.name = name
        self.pokemonName = pokemonName
        self.price = price

class Potion:
    def __init__(self, name, attribute, amount, price):
        self.name = name
        self.attribute = attribute
        self.amount = amount
        self.price = price

class Bike:
    def __init__(self, name, speed, price):
        self.name = name
        self.speed = speed
        self.price = price

class Food:
    def __init__(self, name, amount, price):
        self.name = name
        self.amount = amount
        self.price = price

class Drink:
    def __init__(self, name, amount, price):
        self.name = name
        self.amount = amount
        self.price = price

class Badge:
    def __init__(self, name, region):
        self.name = name
        self.region = region
        

class Player:
    def __init__(self, name, gender):
        self.name = name
        self.gender = gender
        self.badges = []
        self.pokemons = []
        self.balls = []
        self.foods = []
        self.thirst = 10
        self.hunger = 10
        self.drinks = []
        self.bike = None
        self.potions = []
        self.evolutionStones = []
        self.money = 100

    def catchPokemon(self, pokemon, ballName):
        for ball in self.balls:
            if ball.name == ballName:
                if ball.use(pokemon):
                    self.balls.remove(ball)
                    self.pokemons.append(pokemon)
                    break
    
    def browseBalls(self):
        for ball in self.balls:
            print(ball.name)

    def takeBadge(self, badge):
        for invBadge in self.badges:
            if invBadge.name == badge.name:
                return
        
        self.badges.append(badge)

    def drink(self, drinkName):
        message = ''
        for drink in self.drinks:
            if drink.name == drinkName:
                message = '{} has drank {} liers of {}!'
                print(message.format(self.name, drink.amount, drinkName))
                self.thirst -= drink.amount
                if self.thirst < 0 : self.thirst = 0
                return
        message = 'Drink with name : {} was not found!'
        print(message.format(drinkName))

    def eat(self, foodName):
        message = ''
        for food in self.foods:
            if food.name == foodName:
                message = '{} has ate {} kilograms of {}!'
                print(message.format(self.name, food.amount, foodName))
                self.hunger -= food.amount
                if self.hunger < 0: self.hunger = 0
                return
        message = 'Food with name : {} was not found!'
        print(message.format(foodName))
        
    def travel(self):
        if self.bike == None:
            print('Cannot travel without Bike!')
            return
        message = '{} has travelled {} km!'
        print(message.format(self.name, self.bike.speed))

    def usePotion(self, pokemonName, potionName):
        message = ''
        targetPokemon = None
        for pokemon in self.pokemons:
            if pokemon.name == pokemonName:
                targetPokemon = pokemon
                
        if targetPokemon == None:
            message = 'Pokemon with name {} does not exist in your current arsenal!'
            print(message.format(pokemonName))
            return
        
        for potion in self.potions:
            if potion.name == potionName:
                targetPokemon.__setattr__(potion.attribute.lower(), potion.amount)
                message = '{} replenished {} points of {}'
                print(message.format(pokemonName, potion.amount, potion.attribute))
                return
        
        message = 'Potion with name : {} does not exist in your current arsenal!'
        print(message.format(potionName))

    def evolvePokemon(self, pokemonName, stoneName):
        message = ''
        targetPokemon = None

        for pokemon in self.pokemons:
            if pokemon.name == pokemonName:
               targetPokemon = pokemon
        
        if targetPokemon == None:
            message = 'Pokemon with name {} does not exist in your current arsenal!'
            print(message.format(pokemonName))
            return

        for stone in self.evolutionStones:
            if stone.name == stoneName:
                targetPokemon.evolve()
                return

        message = 'Evolution Stone with name : {} does not exist in your current arsenal!'
        print(message.format(stoneName))

    def freePokemon(self, pokemonName):
        message = ''
        for pokemon in self.pokemons:
            if pokemon.name == pokemonName:
                self.pokemons.remove(pokemon)
                message = 'Pokemon : {} was removed from your arsenal!'
                print(message.format(pokemonName))
                return

        message = 'Pokemon with name : {} does not exist in your current arsenal!'
        print(message.format(pokemonName))        

    def sellPokemon(self, pokemonName):
        message = ''
        for pokemon in self.pokemons:
            if pokemon.name == pokemonName:
                self.pokemons.remove(pokemon)
                price = pokemon.health + pokemon.attack * 3 + pokemon.critChance * 20
                self.money += price

                message = 'Pokemon : {} was sold for {}'
                print(message.format(pokemonName, price))

    def buyItem(self, item, itemType):
        message = ''

        if item.price > self.money:
            message = 'Your current balance is insufficient in order to buy Item with name : {}'
            print(message.format(item.name))
            return

        self.money -= item.price
        if itemType == 'Potion':
            self.potions.append(item)
        if itemType == 'Evolution Stone':
            self.evolutionStones.append(item)
        if itemType == 'Ball':
            self.balls.append(item)
        if itemType == 'Drink':
            self.balls.append(item)
        if itemType == 'Food':
            self.foods.append(item)

        message = 'Item : {} was succesfuly bought!'
        print(message.format(item.name))

class Ball:
    def __init__(self, name, rarity, catchPercentage):
        self.name = name
        self.rarity = rarity
        self.catchPercentage = catchPercentage
        self.pokemon = {}

    def use(self, pokemon):
        if randint(0, 100) <= self.catchPercentage:
            self.pokemon = pokemon
            message = '{} was catched!'
            print(message.format(pokemon.name))
            return True
        else:
            message = '{} was not catched!'
            print(message.format(pokemon.name))
            return False    

class Ability:
    def __init__(self, name, aType, element, power, operator, energy, scale, passives):
        self.name = name
        self.aType = aType
        self.element = element
        self.power = power
        self.operator = operator
        self.energy = energy
        self.level = 0
        self.scale = scale
        self.passives = passives
    
    def use(self, pokemon):
        self.energy -= 1
        value = pokemon.__getattribute__(self.aType.lower())
        bonus = self.level * self.scale

        for passive in self.passives:
            passive.isSatisfied(pokemon)

        if self.operator == '+':
            pokemon.__setattr__(self.aType.lower(), value + bonus)
        else:
            pokemon.__setattr__(self.aType.lower(), value - bonus)
        
        message = '{} was used on {}'
        print(message.format(self.name, pokemon.name))
    
    def levelUp(self):
        self.level += 1
        message = 'Ability : {} was leveled up to level : {}'
        print(message.format(self.name, self.level))

class Pokemon:
    def __init__(self, name, element, hunger, thirst, attack, health, abilities, critChance, attackEvo, healthEvo, critEvo, attackScale, healthScale, critScale, evolveName, passives):
        self.name = name
        self.element = element
        self.hunger = hunger
        self.thirst = thirst
        self.energy = 10
        self.attack = attack
        self.health = health
        self.abilities = abilities
        self.critChance = critChance
        self.xp = 0
        self.xpCap = 100
        self.level = 1
        self.abilityPoints = 1
        self.statPoints = 0
        self.happiness = 10
        self.passives = passives

        self.evolveName = evolveName
        self.attackEvo = attackEvo      
        self.healthEvo = healthEvo
        self.critEvo = critEvo

        self.attackScale = attackScale
        self.healthScale = healthScale
        self.critScale = critScale

    def feed(self, amount):
        if self.hunger == 0:
            message = '{} is not Hungry at the moment!'
            print(message.format(self.name))
            return

        self.hunger -= amount
        message = ''
        if self.hunger > 0:
            message = '{} was fed but its still Hungry! Needs {} more food to feel well!'
            print(message.format(self.name, self.hunger))
        else:
            message = '{} was fully fed!'
            print(message.format(self.name))
        self.energy += 1

        if self.energy > 10:
            self.energy = 10

    def evolve(self):
        self.attackScale = self.attackEvo
        self.healthScale = self.healthEvo
        self.critScale = self.critScale

        self.attack += 10 * self.attackScale
        self.health += 10 * self.healthScale
        self.critChance += 10 * self.critChance

        message = '{} has Evolved into : {}'
        print(message.format(self.name, self.evolveName))

    def info(self):
        message = '\n-----------\n Name : {}\n Element : {}\n Hunger : {}\n Thirst : {}\n Energy : {}\n Attack : {}\n Health : {}\n-----------\n'
        print(message.format(self.name, self.element, self.hunger, self.thirst, self.energy, self.attack, self.health))   

    def irrigate(self, amount):
        if self.thirst == 0:
            message = '{} is not Thristy at the moment!'
            print(message.format(self.name))
            return

        self.thirst -= amount
        message = ''
        if self.thirst > 0:
            message = '{} was irrigated but its still Thirsty! Needs {} more liquids to feel well!'
            print(message.format(self.name, self.thirst))
        else:
            message = '{} was fully irrigated!'
            print(message.format(self.name))
        self.energy += 1

        if self.energy > 10:
            self.energy = 10


    def basicAttack(self, pokemon):
        if self.energy == 0:
            message = '{} has not enough Energy to perform a Basic Attack!'
            print(message.format(self.name))
            return
        if self.hunger > 5:
            message = '{} is Hungry and cannot perform a Basic Attack!'
            print(message.format(self.name))
            return
        if self.thirst > 5:
            message = '{} is Thristy and cannot perfrom a Basic Attack!'
            print(message.format(self.name))
            return

        damageAmplifier = 1

        for passive in self.passives:
            passive.isSatisfied(pokemon)

        message = '{} was hit by {} for {} Damage!'
        
        if self.critChance > 10:    
            damageAmplifier *= 2
            message = '{} was critically hit by {} for {} Damage!'

        pokemon.health -= self.attack * damageAmplifier
        self.energy -= 1
        self.hunger -= 1
        self.thirst -= 1
        
        print(message.format(pokemon.name, self.name, self.attack))

    def useAbility(self, pokemon, abilityName):
        if self.energy == 0:
            message = '{} has not enough Energy to perform : {}'
            print(message.format(self.name, abilityName))
            return

        ability = {}
        for ab in self.abilities:
            if ab.name == abilityName:
                ability = ab
                break
            else:
                message = 'Ability with name {} was not found!'
                raise Exception(message.format(abilityName))
        self.energy -= 1        
        ability.use(pokemon)

    def winBattle(self, pokemon):
        self.xp += pokemon.health / 5 + pokemon.attack / 2 + pokemon.level * self.happiness / 8
        self.happinessDec()

        if self.xp > self.xpCap:
            self.xp -= self.xpCap
            self.xpCap += 0.15 * self.xpCap
            self.level += 1
            self.abilityPoints += 1
            self.statPoints += 1

            self.attack += self.attackScale
            self.health += self.healthScale
            self.critChance += self.critScale

            message = '{} has leveled up to level : {}'
            print(message.format(self.name, self.level))

    def loseBattle(self, pokemonName):
        self.health = 0
        self.happinessDec()

        message = '{} has lost a Battle against : {}'
        print(message.format(self.name, pokemonName))

    def happinessDec(self):
        self.happiness -= 1

        if self.happiness < 0:
            self.happiness = 0

    def upgradeAbility(self, abilityName):
        if self.abilityPoints < 1:
            self.abilityPoints = 0
            print('Not enough Ability Points!')
            return
        
        for ability in self.abilities:
            if abilityName == ability.name:
                ability.levelUp()
                self.abilityPoints -= 1
                return
        
        message = 'Ability with name : {} was not found!'
        print(message.format(abilityName))
    
    def upgradeStats(self, statName):
        if self.statPoints < 1:
            self.statPoints = 0
            print('Not enough Stat Points!')
            return

        attr = self.__getattribute__(statName)
        amplifier = {'Health' : 2, 'Crit' : 0.15 , 'Attack' : 0.5}

        self.statPoints -= 1
        self.__setattr__(statName, attr + 1 * amplifier.__getattribute__(statName))

        message = '{} Stat was chosen! New {} : {}'
        print(message.format(statName, statName, self.__getattribute__(statName)))

player = Player('Ash', 'Male')
superBall = Ball('SuperBall', 1, 100)

player.balls.append(superBall)

bubblegunPassive = Passive('Bubbgle Gun Passive', 'Health', 10, '>', 'Attack', 2)
thunderBoltPassive = Passive('Thunderbolt Passive', 'Health', 5, '<', 'CritChance', 5)

pikachuPassive = Passive('Pikachu Passive', 'Attack', 5, '<', 'CritChance', 5)
peeplupPassive = Passive('Peeplup Passive', 'Health', 6, '<', 'Attack', 2)

bubblegun = Ability('Bubble Gun', 'Health', 'Water', 6, '-', 8, 3, [bubblegunPassive])
thunderBolt = Ability('Thunder Bolt', 'Health', 'Thunder', 5, '-', 10, 2, [thunderBoltPassive])

pikachu = Pokemon('Pikachu', 'Thunder', 10, 10, 5, 20, [thunderBolt], 10, 2, 3, 0.1, 2, 5, 0.02, 'Raichu', [pikachuPassive])
peeplup = Pokemon('Peeplup', 'Water', 8, 10, 6, 10, [bubblegun], 12, 1, 20, 0.08, 1, 2, 0.06, 'Empoleon', [peeplupPassive])

player.catchPokemon(pikachu, 'SuperBall')
