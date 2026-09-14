for(let i =1; i<=20; i++)
{
    document.writeln(`${i} `);
}
document.writeln(`<br>`);
for(let i=0;i<30; i+=2)
{
    document.writeln(`${i} `);
}
document.writeln(`<br>`);
for(let i =1; i<=10; i++)
{
    document.writeln(i*8);
}
document.writeln(`<br>`);
for(let i =112; i>=2;i-=11)
{
    document.writeln(`${i}`);
}
document.writeln(`<br>`);
document.writeln(`<table>`);
document.writeln(`<tr>
                <th>Szám</th> <th>Négyzet</th> <th>Köb</th> <th>4. hatvány</th> <th>5. hatvány</th>
                </tr>`);
for(let i =1; i<=10;i++)
{
    document.writeln(`<tr>
                        <td>${i}</td>  <td>${Math.pow(i,2)}</td>  <td>${Math.pow(i,3)}</td>  <td>${Math.pow(i,4)}</td> <td>${Math.pow(i,5)}</td>
                    </tr>`);
}
document.writeln(`</table>`);

document.writeln(`<br>`);
document.writeln(`<table>`);
let c = 1;
for(let i=1;i<=10;i++)
{ 
    document.writeln(`<tr>`);
    for(let j=0; j<10; j++)
    {
        document.writeln(`<td>${c}</td>`);
        c++;
    }
    document.writeln(`</tr>`);
}

document.writeln(`</table>`);
