1. Tesztekes a hibak jelenketet mutatja ki, nem a hianyukat
   - test case egymintavetel
2. Kimerito - teljes koru teszteles lehetetlen. Qualifications board
$$\left. \begin{aligned} 
    &- \text{bemeneti adatok végtelensége} \\
    &- \text{kombinációk robbanása} \\
    &- \text{különböző útvonalak a kódban} \\
    &- \text{környezeti tényezők}
\end{aligned} \right\rbrace \text{probléma}$$
#### Mit tehetunk?
- kockazat elemzes (risk analisys)
- prioritas felallitasa
- testtervezsesi elvek alkalmazasa
- - ekvivalencia partricionalas v <br> hatarertek vizsgalat

3. Korai teszteles - early testing, shift left
   -  #### fazisai
     1. lpvetelmeny fazis <br> design / specifikacio
     2. fejlesztesi fazis
     3. redszerteszt fazis
     4. Eles kornyezet
        - presztizs veztes
        - adat vesztes 
        - penzugyi veszetseg, birsag
4. Hibak csomosodasa, csoportosulasa, Pareto elv : 80/20
   - kialakulasa:
     - bonyolutsag
     - gyakori valtozasok
     - integracios pontok
     - orokolt kod (legacy source)
   - azonositas:
     - hibakoveto rendszer pl.: lira, Sentry
     - hibasuruseg
     - tapasztalat / intuicio
   - hatekonysag novelese:
     - refactorolas
     - automatizacio 
5. Rovarirto paradoxon - pesticide paradox
   - kialakulas:
     - kod valtozasa
     - fejlesztoi megszokas
   - azonositas:
     - nem talalat regresszios tesztekben
     -  "kotelezo korok"
   - kivedese:

$\left. \begin{aligned} 
    &- \text{felfedezo teszteles - exploratory testing } \\
    &- \text{ data driven testing} \\
    &- \text{egyeb: hatarertek, eqvivalencia particionalas} \\
\end{aligned} \right\rbrace \text{uj funkcio => uj teszt }$

$\begin{aligned} 
&\textbf{6. Tesztelés kontextusfüggő} \\
&\left. \begin{aligned} 
    &- \text{eltérő kockázatok} \\
    &- \text{eltérő változások} \\
    &- \text{költség és idő} \\
\end{aligned} \right\} \text{alkalmazás:} \\
& \text{1. ki fogja használni}
& \text{2. mi a legrosszabb}
& \text{3. milyen biztonsag}
\end{aligned}
$

7. a "nincs hiba tevedese" 
  - kialakitas:
    - specifikacio vaksaga
    - fulhasznalo igenyeinek figyelmen kivul hagyasa
    - rossz fokusz
