class Char {
  #isAlive;
  items = [];
  static pi = 3.14;
  constructor(name, hp, attack) {
    this.name = name;
    this.hp = hp;
    this.attack = attack;
    this.#isAlive = true;
  }
  takeDamage(damage) {
    this.hp = this.hp - damage;
    if (this.hp < 0) {
      this.#isAlive = false;
      this.hp = 0;
      console.log("he dood");
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
    if ((this.items.length = 0)) {
      console.log("u have nothing");
    } else {
      this.items.splice(this.items.indexOf(item), 1);
    }
  }
  showInventory() {
    console.log(this.items);
  }
  heal(x) {
    this.hp += x;
  }
}
const c = new Char("Sharon", 1, 0.1);
const c1 = new Char("Orchid", Infinity, Infinity);

console.log(c.hp);
console.log(c.takeDamage(5));
console.log(c.items);
c.addItem("apple");
console.log(c.items);
c.removeItem("apple");
