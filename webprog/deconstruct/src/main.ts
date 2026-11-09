const termek = {
  id: 42,
  nev: "Vezeték nélküli egér",
  ar: 12990,
  kategoria: "Kiegészítők",
  raktaron: true,
  specifikacio: {
    gyarto: "LogiTech",
    dpi: 4000,
  },
};
const {
  nev,
  ar,
  specifikacio: { gyarto },
} = termek;

const newTermek = { ...termek, ar: 11990, akcios: true };

const checkOut = (...arak: number[]): number => {
  let sum: number = 0;
  arak.forEach((i: number) => {
    sum += i;
  });
  return sum;
};

console.log(ar);
console.log(gyarto);
console.log(newTermek);
console.log(checkOut(12000, 15000));

const profilValasz = {
  felhasznaloNev: "KovacsAnna99",
  aktiv: true,
  cimek: [
    { tipus: "szállítási", varos: "Debrecen", utca: "Kossuth utca 12." },
    { tipus: "számlázási", varos: "Budapest", utca: "Rákóczi út 54." },
  ],
};

const { felhasznaloNev, cimek } = profilValasz;
const { varos, utca } = cimek[1];
console.log(`${felhasznaloNev} lakik ${varos} ${utca}`);
