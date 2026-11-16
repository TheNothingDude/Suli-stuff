const l: number[] = [1, 2, 3, 4, 5, 6, 7];

const even = l.filter((x) => x % 2 == 0);

const big = l.filter((x) => x > 5);
let sum = l.reduce((c, current) => c + current, 0);

const infaltion = l.map((x) => x * 1.23);

console.log(big);
console.log(sum);
console.log(infaltion);
