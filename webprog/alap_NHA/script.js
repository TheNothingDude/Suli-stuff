const randomInt = (min, max) => {
  return Math.floor(Math.random() * (max - min + 1) + min);
};

const throws = () => {
  for (let i = 0; i < 20; i++) {
    A.push(randomInt(1, 6));
    B.push(randomInt(1, 6));
    C.push(randomInt(1, 6));
  }
};
const sum = () => {
  let count = 0;
  for (let i = 0; i < A.length; i++) {
    count += A[i] + B[i] + C[i];
  }
  return count;
};
const max = () => {
  let max = 0;
  for (let i = 0; i < A.length; i++) {
    if (max < A[i] + B[i] + C[i]) {
      max = A[i] + B[i] + C[i];
    }
    if (max == 18) {
      return max;
    }
  }
  return max;
};
const countSix = () => {
  let c = 0;
  for (let i = 0; i < A.length; i++) {
    if (A[i] == 6 || B[i] == 6 || C[i] == 6) {
      c++;
    }
  }
  return c;
};
const countAllSix = () => {
  let c = 0;
  for (let i = 0; i < A.length; i++) {
    if (A[i] == 6) {
      c++;
    }
    if (B[i] == 6) {
      c++;
    }
    if (C[i] == 6) {
      c++;
    }
  }
  return c;
};
const AllSixSame = () => {
  for (let i = 0; i < A.length; i++) {
    if (A[i] == 6 && B[i] == 6 && C[i] == 6) {
      return true;
    }
  }
  return false;
};
const countAllSame = () => {
  let c = 0;
  for (let i = 0; i < A.length; i++) {
    if (A[i] == B[i] && A[i] == C[i] && B[i] == C[i]) {
      c++;
    }
  }
  return c;
};
const allDiff = () => {
  for (let i = 0; i < A.length; i++) {
    if (A[i] != B[i] && A[i] != C[i] && B[i] != C[i]) {
      return i;
    }
  }
};
const even = () => {
  let c = 0;
  for (let i = 0; i < A.length; i++) {
    if (A[i] % 2 == 0 || B[i] % 2 == 0 || C[i] % 2 == 0) {
      c++;
    }
  }
  return c;
};

const equals = () => {
  for (let i = 0; i < A.length; i++) {
    if (A[i] == B[i] + C[i] || B[i] == A[i] + C[i] || C[i] == B[i] + A[i]) {
      return true;
    }
  }
  return false;
};
const stats = () => {
  const logs = { 1: 0, 2: 0, 3: 0, 4: 0, 5: 0, 6: 0 };
  for (let i = 0; i < A.length; i++) {
    logs[A[i]]++;
    logs[B[i]]++;
    logs[C[i]]++;
  }
  return logs;
};
const minStats = (logs) => {
  let min = Number.MAX_SAFE_INTEGER;
  let r;
  Object.keys(logs).forEach((e) => {
    if (min > logs[e]) {
      min = logs[e];
      r = e;
    }
  });
  return r;
};
const A = [];
const B = [];
const C = [];
throws();

let avg = sum() / A.length;
console.log(A.join(", "));
console.log(B.join(", "));
console.log(C.join(", "));
console.log(avg);
console.log(max());
console.log(countSix());
console.log(countAllSix());
console.log(AllSixSame());
console.log(countAllSame());
console.log(allDiff());
console.log((even() / (A.length + B.length + C.length)) * 100);
console.log(equals());
console.log(minStats(stats()));
