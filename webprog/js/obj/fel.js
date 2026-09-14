const diak = {
    nev: "Sanyi",
    jegyek: [5, 2, 3, 4, 5, 3],
    atlag: function ()
    {
        let sum = 0;
        this.jegyek.forEach(element =>
        {
            sum += element;
        });
        return sum / this.jegyek.length;
    }
}

const szemely = {
    nev: "Albert",
    kor: 12,

    szuletesiEvSzamitas: function ()
    {
        //return 2026-this.kor;
        this.szuletesiEv = 2026 - this.kor;
    }
}
//1
console.log(diak.atlag());
//2
szemely.szuletesiEvSzamitas();
console.log(szemely.szuletesiEv);




const emberek = [
    { nev: "Kata", kor: 23 },
    { nev: "Gabor", kor: 34 },
    { nev: "Anna", kor: 42 },
];

function idosebbek(emberek)
{
    const harmincTobb = [];
    emberek.forEach(element =>
    {
        if (element.kor > 30)
        {
            harmincTobb.push(element);
        }
    });
    return harmincTobb;
}

console.log(idosebbek(emberek));

const tomb = ['Almos', 20, 'vezer', true, 1990];


for (let i = 0; i < tomb.length; i++)
{
    if (typeof (tomb[i]) != 'string')
    {
        continue;
    }
    console.log(tomb[i]);
}