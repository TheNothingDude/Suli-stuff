const randomInt = (min, max) => {
  return Math.floor(Math.random() * (max - min + 1)) + min;
};
const start = (name) => {
  name.style.bottom = `${randomInt(0, 50)}%`;
  name.style.left = `${randomInt(0, 89)}%`;
};
const SetUp = (name) => {
  name.addEventListener("click", () => {
    point++;
    name.style.left = `${randomInt(0, 89)}%`;
    name.style.bottom = `${randomInt(0, 50)}%`;
  });
};
const move = (name, max) => {
  let currentNumber = parseInt(name.style.bottom, 10);
  name.style.bottom = currentNumber + 3 + "%";
  if (currentNumber >= max) {
    let x = randomInt(0, 89);
    name.style.left = `${randomInt(0, 89)}%`;
    name.style.bottom = `${randomInt(0, 50)}%`;
    currentNumber = parseInt(name.style.bottom, 10);
  }
};
const area = document.getElementById("area");
const lufi = document.querySelectorAll("#lufi");
const points = document.getElementById("points");
let max = 86;
let x = randomInt(0, 89);
let point = 0;
lufi.forEach((e) => {
  SetUp(e);
  start(e);
});
let movement = setInterval(() => {
  lufi.forEach((element) => {
    move(element, max);
  });
  points.textContent = `points: ${point}`;
}, 100);
