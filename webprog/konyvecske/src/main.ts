class Book {
  #pagesRead: number = 0;
  #isRead: boolean;
  #title: string;
  #author: string;
  #page: number;

  constructor(title: string, author: string, page: number, isRead: boolean) {
    this.#title = title;
    this.#author = author;
    this.#page = 1;
    if (page > 0) {
      this.#page = page;
    } else {
      console.log("Not a valid num");
    }
    this.#isRead = isRead;
  }

  get page(): number {
    return this.#page;
  }
  get title(): string {
    return this.#title;
  }
  get isRead(): boolean {
    return this.#isRead;
  }

  read(): void {
    this.#isRead = true;
    console.log(`You have read the book ${this.#title}`);
  }

  getInfo(): void {
    console.log(
      `${this.#author}: ${this.#title} ${this.#page} oldal (olvasott: ${this.#isRead}) progress: ${this.#pagesRead}/${this.#page}`,
    );
  }

  pageTurn(x: number): void {
    if (!this.#isRead) {
      if (x > 0) {
        this.#pagesRead += x;
        console.log(`Page turned! You're now on page ${this.#pagesRead}`);

        if (this.#pagesRead === this.#page) {
          this.#isRead = true;
        }
        return;
      }
    }
    console.log("book already read");
  }
}

class Library {
  #books: Book[];
  constructor() {
    this.#books = [];
  }
  addBook(book: Book): void {
    this.#books.push(book);
  }
  removeBook(title): void {
    this.#books.splice(this.#books.map((e) => e.title).indexOf(title, 1));
  }
  getUnreadBooks(): Book[] {
    let unRead: Book[] = [];
    this.#books.forEach((e) => {
      if (e.isRead == false) {
        unRead.push(e);
      }
    });
    return unRead;
  }
  get Books(): Book[] {
    return this.#books;
  }
}

const b = new Book("The legend of the kittydom", "Helium", 67, false);
const b2 = new Book("Appe", "The Apple Man", 10, false);
const b3 = new Book("smth", "alma", 15, false);
const l = new Library();

b.getInfo();
b.pageTurn(1);
console.log(b.page);

l.addBook(b);
l.addBook(b2);
l.removeBook("Appe");
console.log(l.Books);
console.log(l.getUnreadBooks());
