const red = document.getElementById("red-range");
const blue = document.getElementById("blue-range");
const green = document.getElementById("green-range");
const box = document.getElementById("cube");
const red_val = document.getElementById("red-range-val");
const blue_val = document.getElementById("blue-range-val");
const green_val = document.getElementById("green-range-val");
const opacity = document.getElementById("opacity-range");
const opacity_val = document.getElementById("opacity-range-val");
const changeColor = () => {
  box.style.backgroundColor = `rgba(${red.value},${green.value}, ${blue.value}, ${opacity.value})`;
  red_val.value = red.value;
  green_val.value = green.value;
  blue_val.value = blue.value;
};

const changeNum = () => {
  red.value = red_val.value;
  green.value = green_val.value;
  blue.value = blue_val.value;
};

red.addEventListener("input", changeColor);
blue.addEventListener("input", changeColor);
green.addEventListener("input", changeColor);

red_val.addEventListener("input", changeNum);
blue_val.addEventListener("input", changeNum);
green_val.addEventListener("input", changeNum);
