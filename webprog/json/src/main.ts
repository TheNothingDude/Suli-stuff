const cim = { varos: "Budapest", irszam: 1056 };
const ember = { nev: "Peter", lakhely: cim };
const { lakhely } = ember;
const {
  lakhely: { varos },
} = ember;
const colors: string[] = ["piros", "zold", "pink"];
const [elso, masodik] = colors;
console.log(ember.lakhely.irszam);
console.log(varos);
console.log(lakhely);
console.log([elso, masodik]);
