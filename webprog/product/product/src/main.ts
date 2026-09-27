import "./style.css";

class Product {
  #id: number;
  #price: number;
  #stock: number;
  constructor(id: number, price: number, stock: number) {
    this.#id = id;
    this.#stock = stock;
    this.#price = price;
  }

  get Price(): number {
    return this.#price;
  }
  set Price(price: number) {
    if (price > 0) {
      this.#price = price;
    }
  }

  buy(qty: number): void {
    if (qty > this.#stock) {
      console.log("nincs ennyi raktaron");
      return;
    }
    this.#stock -= qty;
    console.log(`vettel ${qty} db-ot`);
  }
}

const p = new Product(1, 1500, 10);
p.buy(5);
p.buy(10);
