//literal

const huba = {
    nev: "Uhab",
    kor: 18,
    fog: 'vezer',
    hazas: true,
    baratok: ['Arpad', 'Elod'],

};

console.log(huba);
console.log(huba.baratok);
console.log(huba['nev']);

let h = 'hazas';

console.log(huba[h]);

console.log(huba.kor = 24);

const tas = new Object();
tas.nev = 'Tas';
console.log(tas);



const almos = new Object(
    {
        nev: "Almos",
        kor: 18,
        fog: 'vezer',
        hazas: true,
        baratok: ['Arpad', 'Elod'],
    }
);
