let fiuk= 20;
let lanyok=15;
if(fiuk>lanyok)
{
    console.log('A fiúk vannak többen');
}
else{
    console.log(`Lányok vannak többen`);
}

let kor=61;

kor>18?console.log("felnőtt"): console.log("fiatal koru");


let film= "Shrek";
let mufaj;
switch(film)
{
    case "Shrek":
        console.log("mese");
        break;
    default:
        mufaj="besorolhatatlan";
        break;
}

switch(true)
{
    case (kor>18 && kor<60):
        console.log("Nagykoru");
        break;
    case (kor<18):
        console.log("Kiskoru");
        break;
    case (kor>60):
        console.log("oreg");
        break;
}

let pont=72;
pont>50 ? console.log("Sikeres vizsga") : console.log("Sikertelen viszga");


let szam =66;
let jo=0;

if(szam>0)
{
    jo++;
}
if(szam%2==0)
{
    jo++;
}
if(szam%3==0)
{
    jo++;
}
if(szam>50)
{
    jo++;
}

switch(jo)
{
    case 4:
        console.log("mágikus szám");
        break;
    case 3:
        console.log("majdnem mágikus szám");
        break;
    default:
        console.log("nem mágikus szám")
        break;
}