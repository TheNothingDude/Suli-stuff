class Book {
  // Define types for private fields
  #pagesRead: number = 0;
  #isRead: boolean;
  #title: string;
  #author: string;
  #page: number;

  constructor(title: string, author: string, page: number, isRead: boolean) {
    this.#title = title;
    this.#author = author;
    this.#page = 1;

    if (Number.isInteger(page) && page > 0) {
      this.#page = page;
    }
    this.#isRead = isRead;
  }

  get page(): number {
    return this.#page;
  }

  read(): void {
    this.#isRead = true; // Fixed: added '#'
    console.log(`You have read the book ${this.#title}`);
  }

  getInfo(): void {
    console.log(
      `${this.#author}: ${this.#title} ${this.#page} oldal (olvasott: ${this.#isRead}) progress: ${this.#pagesRead}/${this.#page}`,
    );
  }

  pageTurn(): void {
    if (!this.#isRead) {
      // Fixed: added '#'
      this.#pagesRead += 1; // Fixed: added '#'
      console.log(`Page turned! You're now on page ${this.#pagesRead}`);

      if (this.#pagesRead === this.#page) {
        // Fixed: added '#' and used strict equality
        this.#isRead = true;
      }
      return;
    }
    console.log("book already read");
  }
}

const b = new Book("The legend of the kittydom", "Helium", 67, false);
b.getInfo();
b.pageTurn();
console.log(b.page);
