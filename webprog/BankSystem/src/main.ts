abstract class BankAccount {
  _accountNumber: string = "";
  _balance: number = 0;
  get Balance() {
    return this._balance;
  }
  set Balance(val) {
    if (typeof val == "number") {
      this._balance = val;
    }
  }
  get AccountNumber() {
    return this._accountNumber;
  }
  set AccountNumber(s) {
    if (typeof s == "string") {
      this._accountNumber = s;
    }
  }
  deposit(amount: number) {
    if (typeof amount != "number") {
      return;
    } else if (amount <= 0) {
      throw new Error("Not a valid input");
    }
    this._balance += amount;
  }
  whitdraw(amount: number) {
    throw new Error("This is supposed to be overwritten");
  }
}

class SavingsAccount extends BankAccount {
  _interestRate;
  constructor(balance: number, interestRate: number, accountNumber: string) {
    super();
    this._interestRate = interestRate / 100;
    this._balance = balance;
    this._accountNumber = accountNumber;
  }
  whitdraw(amount: number) {
    if (amount > this._balance) {
      throw new Error("You don't have that much in your balance");
    }
    this._balance -= amount;
  }
  addInterest() {
    this._balance += this._balance * this._interestRate;
  }
  get InterestRate() {
    return this._interestRate;
  }
}

try {
  const s = new SavingsAccount(500, 7, "3128301284109");
  console.log(`${s.AccountNumber}: ${s.Balance} ${s.InterestRate}`);
  //console.log(s.whitdraw(1000));
  s.addInterest();
  console.log(`${s.AccountNumber}: ${s.Balance} ${s.InterestRate}`);
} catch (error: any) {
  console.log(`dumm ${error.message}`);
}
