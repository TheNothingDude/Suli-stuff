class User {
  _username: string = "Vendeg";
  get username() {
    return this._username;
  }
  set username(val: string) {
    if (val.length < 3) {
      console.error(`felhasznalonev legalabb 3 karakter hosszunak kell lennie`);
      return;
    }
    this._username = val;
  }
}
class AdminUser extends User {
  sajat_mezo: string = "Aktivator";
  get Profile() {
    return `${super.username} (${this.sajat_mezo})`;
  }
}
const admin = new AdminUser();

console.log(admin.Profile);
