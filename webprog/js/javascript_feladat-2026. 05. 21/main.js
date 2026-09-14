const answers = [];
const elso = document.querySelectorAll(`#elso`);
const masodik = document.querySelectorAll("#ketto");
const harmad = document.querySelectorAll("#harom");
const negyed = document.querySelectorAll("#negy");
const ot = document.querySelectorAll("#ot");
const hat = document.querySelectorAll("#hat");
const het = document.querySelectorAll("#het");
const questions = [elso, masodik, harmad, negyed, ot, hat, het];
questions.forEach((e) => {
  e.forEach((j) => {
    j.addEventListener("change", () => {
      answers[j.name - 1] = j.value;
      console.log(j.name);
      console.log(j.value);
    });
  });
});
