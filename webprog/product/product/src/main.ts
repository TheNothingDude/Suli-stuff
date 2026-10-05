class Product {
  _id: number;
  _price: number;
  _stock: number;
  constructor(id: number, price: number, stock: number) {
    this._id = id;
    this._stock = stock;
    this._price = price;
  }

  get Price(): number {
    return this._price;
  }
  set Price(price: number) {
    if (price > 0) {
      this._price = price;
    }
  }

  buy(qty: number): void {
    if (qty > this._stock) {
      console.log("nincs ennyi raktaron");
      return;
    }
    this._stock -= qty;
    console.log(`vettel ${qty} db-ot`);
  }
}
class DiscountedProduct extends Product {
  private discountPercent: number = 0;
  constructor(id: number, price: number, stock: number, discount: number) {
    super(id, price, stock);
    this.discountPercent = 1 - discount / 100;
  }
  get Price(): number {
    return this._price * this.discountPercent;
  }
}

const p = new Product(1, 1500, 10);
p.buy(5);
p.buy(10);
