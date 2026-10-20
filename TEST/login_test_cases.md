### TC_LOG_001: Sikeres bejelentkezés érvényes adatokkal
*   **Előfeltétel:** A felhasználó regisztrált fiókkal rendelkezik (`teszt@email.com` / `ValidJelszo67`). A fiók nincs zárolva.
*   **Steps to reproduce:**
    1. Navigáljon a Bejelentkezési oldalra.
    2. Adja meg az érvényes email címet: `teszt@email.com`.
    3. Adja meg az érvényes jelszót: `ValidJelszo67`.
    4. Kattintson a "Bejelentkezés" gombra.
* **Data** 
    - Password `ValidJelszo67`
    - email `teszt@email.com`
*   **Elvárt eredmény:** A felhasználó sikeresen bejelentkezik, és átirányításra kerül a főoldalra.
*   
---
### TC_LOG_002: Sikertelen bejelentkezes
*   **Előfeltétel:** A felhasználó regisztrált fiókkal rendelkezik (`teszt@email.com`). A fiók nincs zárolva.
*   **Steps to reproduce:**
    1. Navigáljon a Bejelentkezési oldalra.
    2. Adja meg az email címet (`teszt@email.com`), majd egy hibás jelszót. Kattintson a "Bejelentkezés" gombra.
* **Data** 
    - wrongPassword `alma`
    - email `teszt@email.com`
*   **Elvárt eredmény:** A rendszer elutasítja a bejelentkezési kisérletet, és ujra kéri a jelszót
---

### TC_LOG_03: 3 Bejelentkezési kísérlet után zárolt lesz a rendszer 15 percig
*   **Előfeltétel:** A felhasználó háromszor ír be helytelen adatot.
*   **Steps to reproduce:**
    1. Navigáljon a Bejelentkezési oldalra.
    2. Adja meg az email címet: `teszt@email.com`.
    3. Adja meg a **helyes** jelszót: `ValidJelszo123`.
    4. Kattintson a "Bejelentkezés" gombra.
* **Data** 
    - Password `ValidJelszo67`
    - email `teszt@email.com`
*   **Elvárt eredmény:** A bejelentkezés sikertelen. A rendszer nem engedi be a felhasználót a helyes jelszó ellenére sem, és jelzi, hogy a fiók jelenleg zárolás alatt áll még egy megadott időre.