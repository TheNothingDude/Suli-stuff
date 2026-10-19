class Modal {
  public box: HTMLDivElement;
  public closeBtn: HTMLButtonElement;
  public openBtn: HTMLButtonElement;
  public modal: HTMLDivElement;
  constructor(
    overlayId: string,
    boxId: string,
    openBtnId: string,
    closeBtnId: string,
  ) {
    this.openBtn = document.getElementById(openBtnId) as HTMLButtonElement;
    this.modal = document.getElementById(overlayId) as HTMLDivElement;
    this.box = document.getElementById(boxId) as HTMLDivElement;
    this.closeBtn = document.getElementById(closeBtnId) as HTMLButtonElement;
  }
  open() {
    this.modal.classList.add("open");
  }
  close() {
    this.modal.classList.remove("open");
  }
}

const modal = new Modal("my-modal", "modal-box", "open-btn", "close-btn");
modal.openBtn.addEventListener("click", () => {
  modal.open();
});

modal.closeBtn.addEventListener("click", () => {
  modal.close();
});

window.addEventListener("keyup", (e) => {
  if (e.key === "Escape") {
    modal.close();
  }
});

modal.modal.addEventListener("click", (e) => {
  if (e.target === modal.modal) {
    modal.close();
  }
});
