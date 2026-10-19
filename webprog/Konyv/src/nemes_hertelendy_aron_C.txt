class Konyv {
  _pageNum;
  get PageNum() {
    return this._pageNum;
  }
  set PageNum(val) {
    if (typeof val != "number") {
      throw new Error("PageNum can only be a numer");
    }
    if (val <= 0) {
      throw new Error("The book must have at least 1 page");
    }
    this._pageNum = val;
  }
}

try {
  const k = new Konyv();
  k.PageNum = 50;
  console.log(k.PageNum);
  k.PageNum = "alma";
  console.log(k.PageNum);
} catch (error) {
  console.log(error.message);
}
