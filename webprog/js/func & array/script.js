function osszead(x, y)
{
  return x + y;
}

console.log(osszead(5, 1));

function hello(name)
{
  return `Hello ${name}`;
}

let heloo = hello("Sanyi");
console.log(heloo);

function teglalap(a, b, func)
{
  if (func == "kerület")
  {
    return (a + b) * 2;
  }
  else if (func == "terület")
  {
    return a * b;
  }
  else
  {
    return "hibás func";
  }
}

console.log(teglalap(5, 2, "terület"));

let eletszakasz = function (nev, kor)
{
  switch (true)
  {
    case kor < 13:
      return `${nev} gyerek`;
    case kor >= 13 && kor < 40:
      return `${nev} felnőtt`;
    default:
      return `${nev} idős`;
  }
}



let valami = ["Huba", "alma", "kecske"];
console.log(valami);
let korok = new Array(35, 38, 38);

console.log(valami[0]);

console.log(valami.length);

valami[1] = "Huba";
valami[5] = "Vas";

valami[valami.length] = "helo";

let Huba = ["nev", 38, "vezér", true];

Huba.push(42);
Huba.unshift("ifj");


Huba.pop();
Huba.shift();
console.log(Huba);
console.log(Huba.indexOf(32));


Huba.indexOf("szakács") === -1 ? console.log("Huba nem szakács") : console.log("Szakács"); 
