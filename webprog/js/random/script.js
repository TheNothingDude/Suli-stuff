const randomInt = (min, max) => {
  return Math.round(Math.random() * (max - min)) + min;
};

console.log(randomInt(-5, 35));
console.log(Math.floor(Math.random() * 9 + 2) * 500);

const now = new Date();
console.log(now);
console.log(now.getSeconds());

let perc = "5";
perc = perc.padStart(2, "0");
console.log(perc);

const timer = setInterval(() => {
  console.log("run");
}, 1000);
clearInterval(timer);

let num = 12345678;
console.log(num.toLocaleString());
console.log(now.toLocaleString("hu-HU"));

const arr = ["a", "b", "c", "d", "e"];

console.log(arr[randomInt(0, arr.length)]);
