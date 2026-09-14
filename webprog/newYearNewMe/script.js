class Char {
  isAlive;
  items = [];
  static pi = 3.14;
  constructor(name, hp, attack, ac) {
    this.name = name;
    this.hp = hp;
    this.ac = ac;
    this.attack = attack;
    this.isAlive = true;
  }
  takeDamage(damage) {
    this.hp = this.hp - damage;
    if (this.hp < 0) {
      this.isAlive = false;
      this.hp = 0;
      console.log(`${this.name} dood`);
    }
    return this.hp;
  }
  addItem(item) {
    if (this.items.length <= 5) {
      this.items.push(item);
    } else {
      console.log(`ur inv is full, cant pick up ${item}`);
    }
  }
  removeItem(item) {
    if (this.items.indexOf(item) == -1) {
      console.log("no such item exists");
      return;
    } else {
      if ((this.items.length = 0)) {
        console.log("u have nothing");
        return;
      } else {
        this.items.splice(this.items.indexOf(item), 1);
      }
    }
  }
  showInventory() {
    return this.items.join(", ");
  }
  heal(x) {
    this.hp += x;
  }
}
class Arena {
  static Fight(c1, c2) {
    console.log("a");
    while (c1.isAlive && c2.isAlive) {
      let initive1 = getRandom(1, 10);
      let initive2 = getRandom(1, 10);
      let attackroll1 = getRandom(1, 20);
      let attackroll2 = getRandom(1, 20);
      let attack1 = attackroll1 + c1.attack;
      let attack2 = attackroll2 + c2.attack;
      if (initive1 > initive2) {
        if (attack1 > c2.ac) {
          console.log(`${c1.name} hits`);
          c2.takeDamage(attack1);
        } else {
          console.log(`${c1} misses`);
        }
      }
      if (initive2 > initive1) {
        if (attack2 > c1.ac) {
          console.log(`${c2.name} hits`);
          c1.takeDamage(attack1);
        } else {
          console.log(`${c2} misses`);
        }
      }
      if (initive1 == initive2) {
        initive1 = getRandom(1, 10);
        initive2 = getRandom(1, 10);
      }
    }
  }
}

function getRandom(min, max) {
  return Math.floor(Math.random() * (max - min) + min);
}
const c = new Char("Sharon", 1, 0.1, 1);
const c1 = new Char("Orchid", Infinity, Infinity, Infinity);

console.log(c.hp);
console.log(c.items);
c.addItem("apple");
c.addItem("book");
console.log(c.showInventory());
Arena.Fight(c, c1);
