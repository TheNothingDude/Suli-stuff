//1
const dolgozok = [
    { nev: "Kiss Anna", oraber: 3200, orak: 160, beosztas: "vezető" },
    { nev: "Nagy Mariann", oraber: 1200, orak: 90, beosztas: "alkalmazott" },
    { nev: "Nagy Márton", oraber: 8000, orak: 70, beosztas: "vezető" },
    { nev: "Kovacs Péter", oraber: 2000, orak: 100, beosztas: "alkalmazott" },
    { nev: "Kecske Sándor", oraber: 200, orak: 80, beosztas: "gyakornok" },
];

function berszamfejtes(dolgozo)
{
    let bonus;
    switch (dolgozo.beosztas)
    {
        case "vezető":
            bonus = 1.2;
            break;
        case "alkalmazott":
            bonus = 1.1;
            break;
        case "gyakornok":
            bonus = 1;
            break;
    }

    return dolgozo.oraber * dolgozo.oraber * bonus;
}

dolgozok.forEach(element =>
{
    if (berszamfejtes(element) > 500000)
    {
        console.log(`Kiemelt fizetés: ${element.nev} ${berszamfejtes(element)}`);
    }
    else
    {
        console.log(`${element.nev} ${berszamfejtes(element)}`);
    }
});

//2
const pontszamok = [73, 33, 53, 21, 65, 87];
pontszamok.length
function vizsgaElemzes(pontok)
{
    let sum = 0;
    let avg;
    let max = pontok[0];

    pontok.forEach(element =>
    {
        sum += element;
        if (element > max)
        {
            max = element;
        }
    });
    avg = sum / pontok.length;
    let eredmeny;
    if (avg < 60)
    {
        eredmeny = "gyenge";
    }
    else if (avg < 80)
    {
        eredmeny = "megfelelő";
    }
    else
    {
        eredmeny = "kiváló";
    }
    return { atlag: avg, legmagasabb: max, eredmény: eredmeny };
}
console.log(vizsgaElemzes(pontszamok));

//3
const raktar = [
    { nev: "tej", mennyiseg: 6, kategoria: "élelmiszer" },
    { nev: "laptop", mennyiseg: 2, kategoria: "műszaki" },
    { nev: "papír", mennyiseg: 11, kategoria: "egyeb" },
    { nev: "sajt", mennyiseg: 12, kategoria: "élelmiszer" },
];

function raktarEllenorzes(raktar)
{
    raktar.forEach(element =>
    {
        if (element.mennyiseg < 10)
        {
            switch (element.kategoria)
            {
                case "élelmiszer":
                    console.log(`${element.nev}: Sűrgős utánpótlás`);
                    break;
                case "műszaki":
                    console.log(`${element.nev}: Rendelés szükséges`);
                    break;
                case "egyeb":
                    console.log(`${element.nev}: Figyelni kell!`);
                    break;
            }
        }
    });
}

raktarEllenorzes(raktar);

//4
const bejelentkezes = [
    { nev: "Anna", sikeres_e: true },
    { nev: "Bálint", sikeres_e: false },
    { nev: "Gergő", sikeres_e: false },
    { nev: "Sándor", sikeres_e: false },
    { nev: "Péter", sikeres_e: false },
];

function bejelentkezesElemzes(bejelentkezes)
{
    let siker = 0;
    let sikertelen = 0;
    bejelentkezes.forEach(element =>
    {
        if (element.sikeres_e)
        {
            siker++;
        }
        else
        {
            sikertelen++;
        }
    });
    if (sikertelen > 3)
    {
        console.log("Biztonsági kockázat");
    }
}
bejelentkezesElemzes(bejelentkezes);

//5
const megrendelesek = [
    { vevo: "Kiss Anna", osszeg: 100001, fizetes: "kártya" },
    { vevo: "Gizda Gellért", osszeg: 32000, fizetes: "utánvét" },
    { vevo: "Hatalmas Ferenc", osszeg: 20000, fizetes: "átutalás" },
    { vevo: "Karácsony Károly", osszeg: 36000, fizetes: "utánvét" },
    { vevo: "Nemes Anna", osszeg: 8000, fizetes: "kártya" },
];

function rendelesek(arr)
{
    let dij;
    let sum = 0;
    arr.forEach(element =>
    {
        switch (element.fizetes)
        {
            case "kártya":
                dij = 1;
                break;
            case "átutalás":
                dij = 0.98;
                break;
            case "utánvét":
                dij = 1.05;
                break;
        }
        sum += element.osszeg * dij;
        if (element.osszeg > 100000)
        {
            console.log("nagy értékű rendelés");
        }
    });

}
rendelesek(megrendelesek);