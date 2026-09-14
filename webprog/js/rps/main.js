const randomInt = (min, max) => {
  return Math.floor(Math.random() * (max - min + 1)) + min;
};

const start = document.getElementById("start");
const userField = document.getElementById("userfield");
const opponentField = document.getElementById("opponent");
const rock = document.getElementById("rock");
const paper = document.getElementById("paper");
const scissors = document.getElementById("scissors");
const op_rock = document.getElementById("opponent-rock");
const op_paper = document.getElementById("opponent-paper");
const op_scissors = document.getElementById("opponent-scissors");
const confirm = document.getElementById("confirm");

let selected = -1;
let opponent_selected = randomInt(1, 3);
confirm.classList.remove("inv");
for (const e of document.getElementById("choices").children) {
  e.classList.remove("inv");
  e.addEventListener("click", () => {
    selected = e.value;
  });
}
confirm.addEventListener("click", () => {
  for (const e of document.getElementById("choices").children) {
    if (selected === -1) return;
    for (const e of document.getElementById("choices").children) {
      e.classList.add("inv");
    }
    confirm.classList.add("inv");
  }
});
console.log(selected);
