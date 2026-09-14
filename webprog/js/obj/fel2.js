
//1
const tanulok = [
    { nev: "Anna", pont: 92 },
    { nev: "Sanyi", pont: 54 },
    { nev: "Karcsi", pont: 73 },
    { nev: "Mariann", pont: 32 },
    { nev: "Vera", pont: 85 }
]
function ertekeles(element)
{
    if (element < 50)
    {
        return 'elegtelen';
    }
    else if (element < 59)
    {
        return 'elegseges';
    }
    else if (element < 74)
    {
        return 'kozepes';
    }
    else if (element < 90)
    {
        return 'jo';
    }
    else
    {
        return 'jeles';
    }
}

tanulok.forEach(element =>
{
    console.log(`${element.nev} : ${ertekeles(element.pont)}`);
});

//2
function kedvezmeny(ppl)
{
    switch (ppl)
    {
        case 'diák':
            return 0.9;
        case 'nyugdijas':
            return 0.8;
        case 'nincs':
            return 1
    }
}

const kosar = [1000, 500, 2000, 3500, 4200];
let i = 0;
let sum = 0;
while (i < kosar.length)
{
    sum += kosar[i];
    i++;
}
console.log(sum * kedvezmeny('diák'));

//3

function olcsoAutok(autok)
{
    const olcso = [];
    autok.forEach(element =>
    {
        if (element.ar < 5000000)
        {
            olcso.push(element);
        }
    });
    return olcso;
}
const autok = [
    { marka: "Opel", ar: 4200000 },
    { marka: "Toyota", ar: 5300000 },
    { marka: "Volkswagen", ar: 3500000 },
    { marka: "Hyundai", ar: 8600000 },
    { marka: "Ford", ar: 5700000 },
];

olcsoAutok(autok).forEach(element =>
{
    console.log(`${element.marka} : ${element.ar}`);
});

//4

function elemzes(szamok)
{
    const eredmeny = new Object();
    let paros = 0;
    let paratlan = 0;
    szamok.forEach(element =>
    {
        if (element % 2 == 0)
        {
            paros++;
        }
        else
        {
            paratlan++;
        }
    });
    eredmeny.paros = paros;
    eredmeny.paratlan = paratlan;
    return eredmeny;
}
const szamok = [5, 53, 62, 31, 12];
szamok.push(5);
console.log(szamok)
console.log(elemzes(szamok));

//5

const felhasznalo = [
    { nev: "Anna", szerep: "admin" },
    { nev: "Béla", szerep: "user" },
    { nev: "Csilla", szerep: "guest" }
];

function jogosultsag(felhasznalo)
{
    switch (felhasznalo.szerep)
    {
        case "admin":
            return 'teljes hozzaferes';
        case "user":
            return "korlatozott";
        case "guest":
            return "csak olvasas";
    }
}

felhasznalo.forEach(element =>
{
    console.log(`${element.nev}: ${jogosultsag(element)}`);
});

//6
const okosOtthon = {
    nappali: { lampak: 4, homerseklet: 23, nyitva: true },
    ebedlo: { lampak: 2, homerseklet: 20, nyitva: true },
    halo: { lampak: 1, homerseklet: 18, nyitva: false },
}

function otthonEll(okos)
{
    Object.keys(okos).forEach(element =>
    {
        if (okos[element].homerseklet > 24)
        {
            okos[element].homerseklet = 22;
            console.log("Homerseklet csokkentve 22 fokra");
        }
        else if (okos[element].homerseklet < 20)
        {
            okos[element].homerseklet = 21;
            console.log("Homerseklet novelve 21 fokra");
        }
        else
        {
            console.log("Homerseklet rendben");
        }

        switch (okos[element].nyitva)
        {
            case true:
                console.log("Ajto nyitva");
                break;
            case false:
                console.log("Ajto zarva");
                break;
        }
        if (okos[element].lampak > 2)
        {
            console.log(`Figyelem sok lampa van felkapcsolva ${okos[element].lampak}`);
        }
        else
        {
            console.log(`Lampak szama: ${okos[element].lampak}`);
        }
    });
}
otthonEll(okosOtthon);

console.log(typeof NaN)