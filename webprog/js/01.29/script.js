//1

let alma =18;
let korte =12;

alma>korte ? console.log("Több alma fogyott el") : console.log();

//2

function nagyKoru(kor)
{
    return kor>=18 ? "Nagykoru" : "Kiskoru";  
}

console.log(nagyKoru(16));

//3

function pont(pontszam)
{
    return pontszam>50 ? "Sikeres vizsga" : "Sikertelen vizsga";
}
console.log(pont(72));


//4

function magick(szam)
{
    let felt =0;
    if(szam>0)
    {
        felt++;
    }
    if(szam%3==0)
    {
        felt++;
    }
    if(szam%2==0)
    {
        felt++;
    }
    if(szam>50)
    {
        felt++;
    }

    switch(felt)
    {
        case 3:
            return "Majdnem mágikus szám";
        case 4:
            return "Mágikus szám";
        default:
            return "Nem mágikus szám";
        
    }

}
console.log(magick(66));

//5

function haromszog(a ,b ,c)
{
    return a+b>c && a+c>b&& b+c>a ? "Szerkeszthető" : "Nem Szerkeszthető";
}

console.log(haromszog(5,7,10));

//6

function szam(x)
{
    if(x<0)
    {
        if(x%2==0)
        {
            console.log("Negatív páros");
        }
        else
        {
            console.log("Negatív páratlan");
        }
    }
    else if(x>0)
    {
        if(x%2==0)
        {
            console.log("Pozitív páros");
        }
        else
        {
            console.log("Pozitív páratlan");
        }
    }
    else
    {
        console.log("Nulla");
    }
}
szam(-4);

//7
function szinhaz(kor)
{
    return kor==12 ? "Nem léphet be" : "beléphet"; 
}
console.log(szinhaz(12));

//8


function ho(calc)
{
    switch(true)
    {
        case calc>10:
            return "meleg van";
        case calc>=3 && calc <=9:
            return "hűvös van";
        case calc>=0 && calc<=2:
            return "hideg van";
        default:
            return "fagy";
    }
}

console.log(ho(2));