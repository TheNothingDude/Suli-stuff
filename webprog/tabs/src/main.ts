class Tabs {
  static buttons: HTMLButtonElement[] = Array.from(
    document.querySelectorAll("button"),
  );
  static tabs: HTMLButtonElement[] = Array.from(
    document.querySelectorAll(".tabs div"),
  );

  static addEventListeners(): void {
    this.buttons.forEach((e) => {
      e.addEventListener("click", () => {
        this.buttons.forEach((e) => {
          e.classList.remove("active");
          this.tabs[this.buttons.indexOf(e)].classList.remove("active");
        });
        if (!e.classList.contains("active")) {
          e.classList.add("active");
          this.tabs[this.buttons.indexOf(e)].classList.add("active");
        } else {
          e.classList.remove("active");
          this.tabs[this.buttons.indexOf(e)].classList.remove("active");
        }
      });
    });
  }
}

Tabs.addEventListeners();
