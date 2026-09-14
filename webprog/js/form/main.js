const answers = { 1: null, 2: [], 3: null };
const correct = { 1: "false", 3: "B" };
const inputs = document.querySelectorAll("input, select");
const submit = document.getElementById("submit");
inputs.forEach((e) => {
  e.addEventListener("change", () => {
    if (e.name == "q1") {
      answers[1] = e.value;
      console.log("Q1 Answer:", answers[1]);
    } else if (e.type == "checkbox") {
      if (e.checked) {
        if (!answers[2].includes(e.value)) {
          answers[2].push(e.value);
          console.log("Q2 Answer:", answers[2]);
        }
      } else if (!e.checked) {
        answers[2].pop(e.value);
      }
    } else if (e.name === "q3") {
      answers[3] = e.value;
      console.log("Q3 Answer updated:", answers[3]);
    }
    console.log("Current State of Answers:", answers);
  });
});

submit.addEventListener("click", () => {
  let point = 0;
  if (answers[1] == correct[1]) {
    point++;
  }
  if (
    answers[2].includes("var") &&
    answers[2].includes("let") &&
    answers[2].includes("const") &&
    answers[2].length === 3
  ) {
    point++;
  }
  if (answers[3] == correct[3]) {
    point++;
  }
  document.getElementById("points_display").textContent =
    `Result: ${point} point(s)`;
});
