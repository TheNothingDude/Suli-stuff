const randomInt = (min, max) => {
  return Math.floor(Math.random() * (max - min + 1)) + min;
};
const getPswd = () => {
  chars = [
    "A",
    "B",
    "C",
    "D",
    "E",
    "F",
    "G",
    "H",
    "I",
    "J",
    "K",
    "L",
    "M",
    "N",
    "O",
    "P",
    "Q",
    "R",
    "S",
    "T",
    "U",
    "V",
    "W",
    "X",
    "Y",
    "Z",
  ];
  const nums = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
  let pswd = "";
  let NumCount = randomInt(1, 6);
  let CharCount = 6 - NumCount;
  for (let i = 0; i < NumCount; i++) {
    pswd += nums[randomInt(0, nums.length - 1)];
  }
  for (let i = 0; i < CharCount; i++) {
    pswd += chars[randomInt(0, chars.length - 1)];
  }
  return pswd;
};
// vars
const luckynum = document.getElementById("lucky");
const LuckyReset = document.getElementById("luckyReset");
const clock = document.getElementById("clock");
const pswd = document.getElementById("pswd");
const NewPswd = document.getElementById("newpswd");
const cont = document.getElementById("cont");
const area = document.getElementById("area");
//5. fel
const pont = document.createElement("div");
pont.classList.add("target");
area.appendChild(pont);
pont.addEventListener("click", () => {
  pont.style.top = `${randomInt(0, 93)}`;
  pont.style.left = `${randomInt(0, 93)}%`;
});
//4. fel
for (let i = 0; i < 10; i++) {
  let div = document.createElement("div");
  div.classList.add("izzo");
  cont.appendChild(div);
}
let count = 0;
const izzok = document.querySelectorAll(".izzo");
setInterval(() => {
  if (count < izzok.length) {
    izzok[count].classList.add("light");
  } else {
    count = -1;
    izzok[izzok.length - 1].classList.remove("light");
  }
  if (count > 0) {
    izzok[count - 1].classList.remove("light");
  }
  count++;
}, 500);
//3 fel
pswd.textContent = getPswd();
NewPswd.addEventListener("click", () => {
  pswd.textContent = getPswd();
});
//2. fel
setInterval(() => {
  const date = new Date();
  if (date.getSeconds() % 2 == 0) {
    clock.textContent = `${String(date.getHours()).padStart(2, "0")}:${String(date.getMinutes()).padStart(2, "0")}`;
  } else {
    clock.textContent = `${String(date.getHours()).padStart(2, "0")} ${String(date.getMinutes()).padStart(2, "0")}`;
  }
}, 1000);
//1. fel
luckynum.textContent = randomInt(1, 20) * 5;
LuckyReset.addEventListener("click", () => {
  luckynum.textContent = randomInt(1, 20) * 5;
});
