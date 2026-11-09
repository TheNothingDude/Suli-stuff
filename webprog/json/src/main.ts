const cim = { varos: "Budapest", irszam: 1056 };
const ember = { nev: "Peter", lakhely: cim };
const { lakhely } = ember;
const {
  lakhely: { varos },
} = ember;
const colors: string[] = ["piros", "zold", "pink"];
const [, , color] = colors;
const old = [1, 3, 4, 5];
//by ref
const newlist = [...old, 6, 7]; // works with obj too
const [first, second, ...rest] = [50, 60, 70, 80];

class Felhasznalo {
  private nev: string;
  private email: string;
  private varos: string;

  constructor({
    nev,
    email,
    varos = "Budapest",
  }: {
    nev: string;
    email: string;
    varos?: string;
  }) {
    this.nev = nev;
    this.email = email;
    this.varos = varos;
  }
}

const f = new Felhasznalo({
  nev: "sharon",
  email: "helium.com",
  varos: "budapest",
});
console.log(f);
console.log(ember.lakhely.irszam);
console.log(varos);
console.log(lakhely);
console.log(color);
console.log(newlist);
