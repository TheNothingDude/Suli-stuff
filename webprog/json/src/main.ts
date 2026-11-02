const cim = { varos: "Budapest", irszam: 1056 };
const ember = { nev: "Peter", lakhely: cim };
const {
  lakhely: { varos },
} = ember;

console.log(varos);
