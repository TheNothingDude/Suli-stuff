"use strict"; // Szigorú mód: megszünteti a csendes hibákat, tiltja a deklarálatlan változókat

// 1. Absztrakt ősosztály minta (JS-ben nincs 'abstract' kulcsszó, így kézzel dobunk hibát!)
class Shape {
  color: string;
  constructor(color: string = "transparent") {
    this.color = color;
  }

  // Polimorf metódus: A szülőben defináljuk, de a gyerekekben kötelező felülírni!
  getArea(): number {
    throw new Error(
      "A getArea() metódust kötelező felülírni a származtatott osztályban!",
    );
  }

  getPerimeter(): number {
    throw new Error("Not implemented");
  }

  getInfo() {
    return `Alakzat színe: ${this.color}, területe: ${this.getArea()}, kerulete: ${this.getPerimeter()}`;
  }
}

// 2. Circle osztály (Metódus felülírás + Kivételkezelés)
class Circle extends Shape {
  #radius; // Modern privát mező

  constructor(radius: number, color: string) {
    super(color); // Szülő konstruktorának hívása

    // Típus- és értékvalidáció (Defensive programming)
    if (typeof radius !== "number" || radius <= 0) {
      throw new Error("A kör sugara csak pozitív szám lehet!");
    }
    this.#radius = radius;
  }

  // Metódus felülírás (Method Overriding)
  getArea() {
    return Math.PI * this.#radius * this.#radius;
  }
  getPerimeter(): number {
    return this.#radius * 2 * Math.PI;
  }
}

// 3. Rectangle osztály
class Rectangle extends Shape {
  #width: number = 1;
  #height: number = 1;

  constructor(width: number, height: number, color: string) {
    super(color);
    if (width <= 0 || height <= 0) {
      throw new Error("A téglalap oldalai csak pozitív számok lehetnek!");
    }
    if (width > 0 && height > 0) {
      this.#width = width;
      this.#height = height;
    }
  }

  getArea() {
    return this.#width * this.#height;
  }
  getPerimeter(): number {
    return 2 * (this.#width + this.#height);
  }
}
class Parallelogram extends Shape {
  #width: number = 1;
  #height: number = 1;
  #base: number = 1;

  constructor(width: number, height: number, base: number, color: string) {
    super(color);
    if (width > 0 || height > 0 || base > 0) {
      this.#base = base;
      this.#height = height;
      this.#width = width;
    } else {
      throw new Error("not valid values");
    }
  }
  getArea(): number {
    return this.#base * this.#height;
  }

  getPerimeter(): number {
    return 2 * (this.#width + this.#base);
  }
}

class Decagon extends Shape {
  #a: number = 1;
  constructor(a: number, color: string) {
    super(color);
    if (a > 0) {
      this.#a = a;
    } else {
      throw new Error("not a valid val");
    }
    return;
  }
  getArea(): number {
    return 7.6942 * Math.pow(this.#a, 2);
  }
  getPerimeter(): number {
    return 10 * this.#a;
  }
}
// --- DEMÓ ÉS POLIMORFIZMUS MŰKÖDÉSBEN ---
try {
  // Polimorfizmus: Különböző objektumokat kezelünk egyforma módon!
  const shapes: Shape[] = [
    new Circle(5, "piros"),
    new Rectangle(4, 6, "kék"),
    new Parallelogram(5, 2, 10, "gold"),
    new Decagon(5, "pink"),
  ];

  shapes.forEach((shape) => {
    // Mindegyiknek van getInfo()-ja, de a háttérben a saját getArea()-juk fut le!
    console.log(shape.getInfo());
  });

  // Hiba tesztelése:
  console.log("Hibás kör létrehozása...");
  const rosszKor: Circle = new Circle(-3, "zöld"); // Kivételt fog dobni!
} catch (error: any) {
  console.error("⚠️ Elkapott hiba:", error.message);
}
