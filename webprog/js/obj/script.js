const huba = {
    nev: "Huba",
    kor: 18,
    foglalkozas: "vezer",
    hazas: true,
    barat: ["Almos"],
    "Csaladi allapot": "nos",
    szuletesiEvSzamitas: function(){
        //return 2026-this.kor;
        this.szuletesiEv = 2026-this.kor;
    }
}

huba.szuletesiEvSzamitas();
console.log(huba.szuletesiEv);
