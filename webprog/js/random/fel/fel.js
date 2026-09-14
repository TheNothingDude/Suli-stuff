const randomInt = (min, max) => {
  return Math.floor(Math.random() * (max - min + 1)) + min;
};
const makeColor = () => {
  let base = "#";
  const colors = [
    `0`,
    `1`,
    `2`,
    `3`,
    `4`,
    `5`,
    `6`,
    `7`,
    `8`,
    `9`,
    `A`,
    `B`,
    `C`,
    `D`,
    `E`,
    `F`,
  ];
  for (let i = 0; i < 6; i++) {
    base += colors[randomInt(0, colors.length - 1)];
  }
  return base;
};
const p = document.getElementById("year");
const reset = document.getElementById("reset");
const ptime = document.getElementById("time");
const time = new Date();
const ar = document.getElementById("ar");
const toto = document.getElementById("toto");
const cube = document.getElementById("color");
cube.style.width = "500px";
cube.style.height = "500px";
ar.innerText = randomInt(6, 29) * 1000 + randomInt(8, 9) * 100 + 90;
p.innerText = randomInt(2000, 2100);
reset.addEventListener("click", () => {
  p.innerText = randomInt(2000, 2100);
  ar.innerText = randomInt(6, 29) * 1000 + randomInt(8, 9) * 100 + 90;
});
//toto
for (let i = 0; i < 13; i++) {
  switch (randomInt(1, 3)) {
    case 1:
      toto.textContent += "X ";
      break;
    case 2:
      toto.textContent += "1 ";
      break;
    case 3:
      toto.textContent += "2 ";
      break;
  }
}
//timer
ptime.textContent = `${time.getHours().toString().padStart(2, "0")}:${time.getMinutes().toString().padStart(2, "0")}`;
setInterval(() => {
  ptime.textContent = `${time.getHours().toString().padStart(2, "0")} ${time.getMinutes().toString().padStart(2, "0")}`;
}, 1000);
setInterval(() => {
  ptime.textContent = `${time.getHours().toString().padStart(2, "0")}:${time.getMinutes().toString().padStart(2, "0")}`;
}, 2000);

//cube
let color = makeColor();
cube.style.backgroundColor = color;
document.getElementById("colorcode").innerText = color;
cubeTime = setInterval(() => {
  color = makeColor();
  cube.style.backgroundColor = color;
  document.getElementById("colorcode").innerText = color;
}, 1000);
