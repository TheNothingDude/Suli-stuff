function getRandomInt(max) {
  return Math.floor(Math.random() * max);
}
function getRandomColor()
{
    let chars = "0123456789ABCDEF";
    let color = "#";
    for(let i = 0; i<6; i++)
    {
        color += chars[getRandomColor(chars.length)];
    }
    return color;
}
let cim = document.getElementById("cim");
cim.textContent = "alma";

let szoveg = document.getElementById("szoveg");
let but = document.getElementById("gomb");

but.onclick = function ()
{
    szoveg.textContent = "woahh";
}

let div = document.getElementById("doboz");
div.style.backgroundColor = "purple";
div.style.width = "300px";

const list = document.getElementById("lista");
for (let i = 1; i <= 10; i++)
{
    let li = document.createElement("li");
    li.textContent = `${i}. elem`;
    list.appendChild(li);
}

//szinezd ki a p-t
/*
const ps = document.querySelectorAll("p");
ps.forEach( p =>{
        p.style.backgroundColor = `#db1db8`;
    }
)
*/

const newBut = document.getElementById("ujgomb");
const newText = document.getElementById("ujszoveg");
newBut.onclick = function()
{
    newText.classList.add("kiemelt");
}

const colors = ["#FF0000", "#FFA500", "#FFFF00", "#008000", "#0000FF", "#4B0082", "#EE82EE"]
const div1 = document.getElementById("cont");
for(let i = 1; i <=10; i++)
{
    let newDiv = document.createElement("div");
    newDiv.style.backgroundColor = colors[getRandomInt(colors.length)];
    newDiv.textContent = i;
    newDiv.style.display = "inline-block";
    newDiv.style.border = `1px solid ${colors[getRandomInt(colors.length)]}`;
    newDiv.style.padding = `5px`;
    newDiv.width = '20%';
    div1.appendChild(newDiv);
}

const ul = document.getElementById("event");
for (let i = 1; i <= 5; i++)
{
    let li = document.createElement("li");
    li.textContent = `${i}. elem`;
    li.addEventListener("click" , function()
        {
            li.style.backgroundColor = colors[getRandomInt(colors.length)];
        }
    );
    ul.appendChild(li);
}