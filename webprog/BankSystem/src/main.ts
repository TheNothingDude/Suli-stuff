abstract class BankAccount {
  _accountNumber: string = "";
  _balance: number = 0;
  protected _transactions: any[] = [];
  constructor(accountNumber: string, balance: number) {
    this._accountNumber = accountNumber;
    this._balance = balance;
  }
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
      this._transactions.push({
        type: "FAIL_DEPOSIT",
        amount: amount,
        date: new Date().toLocaleString(),
        balanceAfter: this._balance,
      });
      throw new Error("Not a valid input");
    }
    this._balance += amount;
    this._transactions.push({
      type: "deposit",
      amount: amount,
      date: new Date().toLocaleString(),
      balanceAfter: this._balance,
    });
  }
  withdraw(amount: number) {
    throw new Error("This is supposed to be overwritten");
  }
  TransactionHistory() {
    this._transactions.forEach((trans) => {
      console.log(
        `${trans.date} ${trans.type} ${trans.amount} ${trans.balanceAfter}`,
      );
    });
  }
}

class SavingsAccount extends BankAccount {
  _interestRate;
  constructor(balance: number, interestRate: number, accountNumber: string) {
    super(accountNumber, balance);
    this._interestRate = interestRate / 100;
    this._balance = balance;
    this._accountNumber = accountNumber;
  }
  whitdraw(amount: number) {
    if (amount > this._balance) {
      this._transactions.push({
        type: "FAIL_DEPOSIT",
        amount: amount,
        date: new Date().toLocaleString(),
        balanceAfter: this._balance,
      });
      throw new Error("You don't have that much in your balance");
    }
    this._balance -= amount;
    this._transactions.push({ type: "deposit", amount: amount });
  }
  addInterest() {
    this._balance += this._balance * this._interestRate;
  }
  get InterestRate() {
    return this._interestRate;
  }
}

class CreditAccount extends BankAccount {
  private creditLimit!: number;
  constructor(balance: number, creditLimit: number, accountNumber: string) {
    super(accountNumber, balance);
    this.creditLimit = creditLimit;
    this._balance = balance;
    this._accountNumber = accountNumber;
  }
  withdraw(amount: number) {
    if (0 - amount < this.creditLimit) {
      throw new Error("You don't have enough credit");
    }
  }
}

class Bank {
  private _accounts: BankAccount[];
  constructor() {
    this._accounts = [];
  }
  addAccount(account: BankAccount) {
    this._accounts.push(account);
  }
  transfer(from: string, to: string, amount: number) {
    this._accounts.forEach((acc) => {
      if (acc.AccountNumber == from) {
        acc.withdraw(amount);
      }
      if (acc.AccountNumber == to) {
        acc.deposit(amount);
      }
    });
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
