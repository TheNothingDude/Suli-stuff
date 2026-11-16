interface Product {
  id: number;
  name: string;
  category: string;
  price: number;
  inStock: boolean;
  rating: number;
}
interface API {
  status: string;
  timestamp: number;
  data: { shopName: string; products: Product[] };
}
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
  private products: Product[];
  constructor({ data: { products } }: API) {
    this.products = products;
  }
  public static elsoFel = ({
    data: { products },
  }: {
    status: string;
    timestamp: number;
    data: { shopName: string; products: Product[] };
  }) => {
    return products.filter((x) => x.inStock);
  };

  public static masodikFel = () => {
    return this.products
      .filter(({ rating, price }) => rating >= 4.6 && price >= 40000)
      .map(({ name }) => ({ name }));
  };
  public static harmadikFel = () 
}

const harmadikFel = () => {};

console.log(elsoFel(apiResponse));
console.log(masodikFel(apiResponse));
