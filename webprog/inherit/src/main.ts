class Car {
  _brand: string;
  _speed: number;
  _doors: number;
  _renCost: number;
  constructor(renCost: number, brand: string, speed: number, doors: number) {
    this._brand = brand;
    if (speed > 0 && doors > 0 && renCost > 0) {
      this._doors = doors;
      this._speed = speed;
      this._renCost = renCost;
    } else {
      throw new Error("nem valid input");
    }
  }
}

class ElectricCar extends Car {
  _battery: number = 1;

  constructor(
    renCost: number,
    brand: string,
    speed: number,
    doors: number,
    battery: number,
  ) {
    super(renCost, brand, speed, doors);
    if (battery <= 100 && battery >= 0) this._battery = battery / 100;
  }

  charge(amount: number): void {
    amount = amount / 100;
    if (this._battery + amount > 1) {
      throw new Error("nem valid ertek");
    }
    this._battery += amount;
  }

  getDetails(): number[] {
    return [this._doors, this._battery];
  }
}

class GasCar extends Car {
  tank: number = 1;
  constructor(
    renCost: number,
    brand: string,
    speed: number,
    doors: number,
    tank: number,
  ) {
    super(renCost, brand, speed, doors);
    if (tank <= 100 && tank >= 0) this.tank / 100;
    else {
      throw new Error("nem valid ertek");
    }
  }
}
class Fleet {
  vehicles: Car[] = [];

  addVehicle(car: Car): void {
    this.vehicles.push(car);
  }
  buggetInfo() {
    try {
      this.vehicles.forEach((e) => {
        console.log(`${e._brand}, napi ${e._renCost}, havi ${e._renCost * 30}`);
      });
    } catch (error: any) {
      throw new Error(`${error.message}`);
    }
  }
}
const E = new ElectricCar(5, "Skoda", 50, 4, 70);
E.charge(30);
console.log(E.getDetails());
const f: Fleet = new Fleet();
f.addVehicle(E);
f.addVehicle(new GasCar(10, "Audi", 70, 4, 50));
f.buggetInfo();
