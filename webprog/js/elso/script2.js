/*
1. 
a) Brendan Eich
b) weboldalak interaktivisása fejlesztéséér
c) A Java egy önálló programozasi nyelv, míg a JavaScript script-nyelv.
d) Azt, hogy a böngésző futás közben futtatja a kódot.
e) Egy létrehozott változó tipusa használat közben módosítani lehet.


2.
- head
- body
- /* */
/*
- böngésző
- globális
- blokk
*/

//3
var knev = "Peti";
var kor = 17;
var nagykoru = false;
console.log(`${knev} ${kor} éves. Nagykorú? ${nagykoru}`);


//4

var a = "JavaScript";
var b = 2025;
var c = true;
var d;

console.log(`${a}: ${typeof(a)}`);
console.log(`${b}: ${typeof(b)}`);
console.log(`${c}: ${typeof(c)}`);
console.log(`${d}: ${typeof(d)}`);


//5
alert("Helló világ");

console.log(`A kód fut!`);

//6
var szam1=10;
var szam2=4;

console.log(szam1+szam2);
console.log(szam1-szam2);
console.log(szam1*szam2);
console.log(szam1/szam2);
console.log(szam1>szam2);

//7
var x = 5;
console.log(x);

{
    let x = 10;
    console.log(x);
}

console.log(x);
/*
Előszőr a var jelenik, mert az volt deklarálva, aztán meg a blokkon belüli let változó és utána ismét a var mert a let csak blokk szintű
*/

//8
function Bemut(nev, kor, szin)
{
    return `Szia! ${nev} vagyok, ${kor} éves. Kedvenc színem a ${szin}`;
}

console.log(Bemut("Sanyi", 16, "piros"));

//9
function Beker()
{
    let nev= prompt("Add meg a neved: ", "Sanyi");
    return `Szia ${nev}! Üdv a JavaScript világában`;
}
console.log(Beker());





