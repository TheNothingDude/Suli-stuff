class Char {
  #isAlive;
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
}
const c = new Char("Sharon", 1, 0.1);
const c1 = new Char("Orchid", Infinity, Infinity);

console.log(c.hp);
console.log(c.takeDamage(5));
console.log(Char.pi);
