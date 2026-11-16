const apiResponse = {
  status: "success",
  timestamp: 1711982400,
  data: {
    shopName: "TechStore Budapest",
    products: [
      {
        id: 101,
        name: "Mechanikus Billentyűzet",
        category: "periféria",
        price: 35000,
        inStock: true,
        rating: 4.8,
      },
      {
        id: 102,
        name: "Vezeték nélküli Egér",
        category: "periféria",
        price: 18000,
        inStock: false,
        rating: 4.5,
      },
      {
        id: 103,
        name: "27 colos 4K Monitor",
        category: "kijelző",
        price: 145000,
        inStock: true,
        rating: 4.9,
      },
      {
        id: 104,
        name: "Type-C Elosztó Hub",
        category: "kiegészítő",
        price: 9500,
        inStock: true,
        rating: 4.2,
      },
      {
        id: 105,
        name: "Ergonomikus Szék",
        category: "bútor",
        price: 89000,
        inStock: false,
        rating: 4.6,
      },
      {
        id: 106,
        name: "Zajszűrős Fejhallgató",
        category: "audio",
        price: 55000,
        inStock: true,
        rating: 4.7,
      },
    ],
  },
};
class APIHandler {
  _product;
  _shopName;
  constructor({ data: { shopName, products } }) {
    this._product = products;
    this._shopName = shopName;
  }
  elsoFel() {
    return this._product.filter((x) => x.inStock);
  }
  masodikFel() {
    return this._product
      .filter(({ rating, price }) => rating >= 4.6 && price >= 40000)
      .map(({ name }) => ({ name }));
  }
  harmadikFel() {
    return this._product
      .map((p) => (p = p.price))
      .reduce((sum, curent) => sum + curent, 0);
  }
  negyedikFel() {
    return this._product.find((n) => n.category === "kijelző");
  }
}

const api = new APIHandler(apiResponse);
console.log(api.elsoFel());
console.log(api.masodikFel());
console.log(api.harmadikFel());
console.log(api.negyedikFel());
