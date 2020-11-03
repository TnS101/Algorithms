class Client {
    constructor(name, money) {
        this.name = name;
        this.money = money;
        this.products = [];
    }

    buyProduct(product) {
        if (this.money >= product.price) {
            this.money -= product.price;
            console.log(`You have bought ${product.name}! Current balance : ${this.money}`);
            this.products.push(product);
            return;
        }

        console.log(`Not enough money to buy product ${product.name}! Need ${product.price - this.money} more!`);
        return;
    }

    repairProduct(productName) {
        const product = this.getProduct(productName);
        const repairFee = (product.price / product.durability) / 2;

        if (this.money >= repairFee) {
            product.durability = product.maxDurability;
            console.log(`${product.name} has been repaired to its full durability (${product.maxDurability}) for ${repairFee} leva!`);
            this.money -= repairFee;
            return;
        }

        console.log(`Not enough money to repair ${product.name}! Needed : ${repairFee} leva!`);
    }

    useProduct(productName, commandName, times) {
        const product = this.getProduct(productName);
        product.use(commandName, times);
    }

    getProductInfo(productName) {
        const product = this.getProduct(productName);
        product.info();
    }

    getProduct(productName) {
        return this.products.find(p => p.name == productName);
    }
}

class Machine {
    constructor(name, manufacturer, price, durability, commands) {
        this.name = name;
        this.manufacturer = manufacturer;
        this.price = price;
        this.durability = durability;
        this.commands = commands;
        this.maxDurability = durability;
    }

    use(commandName, times) {
        const durabilityLoss = this.commands.find(c => c.name == commandName).cost * times;
        this.durability -= durabilityLoss;

        if (this.durability < 0) {
            console.log(`${this.name} broke and needs to be repaired! ${this.durability * -1} work has not been done!`);
            this.durability = 0;
            return;
        }

        console.log(`${this.name} current durability : ${this.durability}! Work done : ${durabilityLoss} (${commandName} done ${times} times)`);
    }

    info() {
        let commands = 'Commands : ';

        this.commands.reduce(function(acc, curr) {
            commands += `\nCommand Name : ${curr.name}; Cost : ${curr.cost}`
        }, 0);

        console.log(`Info for machine : ${this.name} \nManufacturer : ${this.manufacturer}\nPrice : ${this.price}\nDurability : ${this.durability} / ${this.maxDurability}\n ${commands}`);
    }
}

class CoffeeMaker extends Machine {
    constructor(name, manufacturer, price, durability, commands, beans, water) {
        super(name, manufacturer, price, durability, commands);
        this.water = water;
        this.beans = beans;
    }

    use(commandName, times) {
        const command = this.commands.find(c => c.name == commandName);

        if (command.materials !== undefined) {
            command.materials.reduce(function(acc, mat) {
                if (this[mat.name] < mat.val) {
                    console.log(`Not enough ${mat.name}!`)
                    return;
                }
                this[mat.name] -= mat.val;
            }, 0);
        }

        super.use(commandName, times);
    }
}

const client = new Client('Pesho', 500);
const kafeMashina = new CoffeeMaker('Kafe', 'Az', 100, 10, [{ name: 'pravi Kafe', cost: 1, materials: [{ name: 'beans', val: 2 }, { name: 'water', val: 1 }] }], 5, 5);

client.buyProduct(kafeMashina);

client.useProduct('Kafe', 'pravi Kafe', 3);
client.repairProduct('Kafe');