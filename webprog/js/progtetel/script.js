const genInt = (min, max) => {
  return Math.floor(Math.random() * (max - min + 1)) + min;
};
const Find = (array, val) => {
  let num = 0;
  array.forEach((e) => {
    if (e == val) {
      num++;
    }
  });
  return num;
};

const A = [];
const B = [];
const C = [];
const dobasok = [A, B, C];

dobasok.forEach((element) => {
  for (let j = 0; j < 20; j++) {
    element.push(genInt(1, 6));
  }
});
console.log(A);
console.log(B);
console.log(C);

let sum = 0;
let avg;

dobasok.forEach((i) => {
  i.forEach((j) => {
    sum += j;
  });
});
avg = sum / (A.length + B.length + C.length);
console.log(sum);
console.log(avg);

let max = 0;
for (let i = 0; i < A.length; i++) {
  if (A[i] + B[i] + C[i] > max) {
    max = A[i] + B[i] + C[i];
  }
}
console.log(max);
let six_count_per = 0;
three_six = false;
for (let i = 0; i < A.length; i++) {
  if (A[i] == 6 || B[i] == 6 || C[i] == 6) {
    six_count_per++;
    if (A[i] == 6 && B[i] == 6 && C[i] == 6) {
      three_six = true;
    }
  }
}
console.log(six_count_per);

let six_count = 0;
dobasok.forEach((e) => {
  e.forEach((i) => {
    if (i == 6) {
      six_count++;
    }
  });
});
console.log(six_count);
console.log(three_six);

let all_three = 0;

for (let i = 0; i < A.length; i++) {
  if (A[i] == B[i] && B[i] == C[i] && A[i] == C[i]) {
    all_three++;
  }
}
console.log(all_three);

let all_diff_index;
for (let i = 0; i < A.length; i++) {
  if (A[i] != B[i] && A[i] != C[i] && B[i] != C[i]) {
    all_diff_index = i;
  }
}
console.log(all_diff_index + 1);

let even = () => {
  let r = 0;
  dobasok.forEach((e) => {
    r += Find(e, 2);
    r += Find(e, 4);
    r += Find(e, 6);
  });
  return r;
};

console.log((even() / (A.length + B.length + C.length)) * 100);

for (let i = 0; i < A.length; i++) {
  if (A[i] == B[i] + C[i]) {
    console.log(`${A[i]} = ${B[i]} + ${C[i]}`);
  }
  if (B[i] == C[i] + A[i]) {
    console.log(`${B[i]} = ${C[i]} + ${A[i]}`);
  }
  if (C[i] == A[i] + B[i]) {
    console.log(`${C[i]} = ${A[i]} + ${B[i]}`);
  }
}

const stats = [0, 0, 0, 0, 0, 0];
for (let i = 1; i <= 6; i++) {
  dobasok.forEach((e) => {
    stats[i - 1] += Find(e, i);
  });
}
