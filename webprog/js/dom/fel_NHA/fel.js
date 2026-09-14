const cont = document.getElementById("cont");
const psum = document.getElementById("sum");
const select = document.getElementById("select");
const reset = document.getElementById("reset");
let sum = 0;
let count = 0;
select.innerText = `Kiválasztott elemek száma: ${count}`;
psum.innerText = `Kiválsztott elemek összege: ${sum}`;
for (let i = 1; i <= 10; i++) {
  const div = document.createElement("div");
  div.innerText = i;
  div.addEventListener("click", () => {
    if (div.classList.contains("selected")) {
      div.classList.remove("selected");
      count--;
      sum -= Number(div.innerText);
      select.innerText = `Kiválasztott elemek száma: ${count}`;
      psum.innerText = `Kiválsztott elemek összege: ${sum}`;
    } else {
      div.classList.add("selected");
      count++;
      sum += Number(div.innerText);
      select.innerText = `Kiválasztott elemek száma: ${count}`;
      psum.innerText = `Kiválsztott elemek összege: ${sum}`;
    }
  });
  cont.appendChild(div);
}
reset.addEventListener("click", () => {
  document.querySelectorAll(".selected").forEach((element) => {
    element.classList.remove("selected");
  });
  sum = 0;
  count = 0;
  select.innerText = `Kiválasztott elemek száma: ${count}`;
  psum.innerText = `Kiválsztott elemek összege: ${sum}`;
});

document.querySelectorAll("#cont div:nth-child(even)").forEach((element) => {
  element.style.backgroundColor = "green";
});
document.querySelectorAll("#cont div:nth-child(odd)").forEach((element) => {
  element.style.backgroundColor = "blue";
});
