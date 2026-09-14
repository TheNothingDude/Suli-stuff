/*console.log("heo");
alert("szia bia");*/

//var

var knev = "Sanyi";
console.log(knev);

/*
number
string
bool
undefiend nincs értéke
null nem lét
*/


var kor = 32;
console.log(kor);

var _nagykoru=true;
console.log(_nagykoru);

var $magassag;
console.log($magassag);

kor = "harminc";
console.log(kor)

var s = 'Jani' +' '+ kor +' éves';
console.log(s);

var osszeg = 10+30;
console.log(osszeg)

var szam1 = 160;
var szam2 = 150;

if(szam1>szam2)
{
    console.log(szam1+' '+'nagyobb');
}
else{
    console.log(szam2 +" " + "nagyobb");
}

console.log(typeof(szam1));

//var global
var nev = "Géza";

function teszt()
{
    var x = 10;
    console.log(nev);
}
teszt();

//fuggvény szintű láthatóság (funcion scoop)


//ES6 szabvany
//2015 utan var & const
//blokk szintu valt:{}


{
    let y=21;
    console.log(y);
}

//ciklus

let i=1;
console.log(i);
for(let i =0; i<8;i++)
{
    console.log(i);
}
console.log(i);

//const

const ERTEK=20;
console.log(ERTEK);