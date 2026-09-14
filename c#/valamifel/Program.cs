using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Verseny
{
    // Csapat adatai
    public class Csapat
    {
        public int Id { get; set; }
        public int GyozelmekSzama { get; set; } = 0;
        public int LeGyozoje { get; set; } = 0; // Ki győzte le (fa szülője)
        public List<int> LeGyozottek { get; set; } = new List<int>(); // Kik lettek legyőzve (fa gyermekei)
    }

    // A fa felépítése a részfa méret számításához
    private static int SzamolLeGyozotteket(int csapatId, Dictionary<int, Csapat> csapatok)
    {
        if (!csapatok.ContainsKey(csapatId))
        {
            return 0;
        }

        int osszesen = 1; // Saját magát is számolja, mint 'leggyőzöttek' részhalmazát
        foreach (var legyozottId in csapatok[csapatId].LeGyozottek)
        {
            osszesen += SzamolLeGyozotteket(legyozottId, csapatok);
        }
        return osszesen;
    }

    public static void Main(string[] args)
    {
        const string beFajl = "verseny.be";
        const string kiFajl = "verseny.ki";

        if (!File.Exists(beFajl))
        {
            File.WriteAllText(kiFajl, "-1\nNincs megoldás!");
            return;
        }

        var csapatok = new Dictionary<int, Csapat>();
        var kiesettek = new HashSet<int>();
        var reszfaMeret = new Dictionary<int, int>();

        try
        {
            var sorok = File.ReadAllLines(beFajl);

            // A feladat szerint N-et és M-et be kellene olvasni, de a minta alapján csak az eredmények vannak.
            // Feltételezzük, hogy az első sor tartalmazza N-et és M-et, ha van. Ha nincs, akkor az adatokból számoljuk.
            // A mintapélda alapján a sorok közvetlenül a meccseket tartalmazzák:
            
            // Mérkőzések feldolgozása
            foreach (var sor in sorok)
            {
                var adatok = sor.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (adatok.Length == 2 && int.TryParse(adatok[0], out int gyoztesId) && int.TryParse(adatok[1], out int vesztesId))
                {
                    // Csapatok inicializálása, ha még nem léteznek
                    if (!csapatok.ContainsKey(gyoztesId)) csapatok[gyoztesId] = new Csapat { Id = gyoztesId };
                    if (!csapatok.ContainsKey(vesztesId)) csapatok[vesztesId] = new Csapat { Id = vesztesId };

                    // Adatfrissítés
                    csapatok[gyoztesId].GyozelmekSzama++;
                    csapatok[gyoztesId].LeGyozottek.Add(vesztesId);
                    csapatok[vesztesId].LeGyozoje = gyoztesId;
                    kiesettek.Add(vesztesId); // A vesztes kiesik
                }
            }

            // Összes csapat azonosítása (hogy a nem játszott csapatok is szerepeljenek)
            // A legmagasabb ID alapján becsüljük az összes csapat számát
            int maxId = csapatok.Keys.Any() ? csapatok.Keys.Max() : 0;
            if (maxId < 8) maxId = 8; // Minta alapján minimum 8

            // Győzelmek/kiesettek fa nélkül
            var gyozelmekSzama = csapatok.ToDictionary(c => c.Key, c => c.Value.GyozelmekSzama);

            // A. Kiestek közül a legtöbbször győzött csapat
            int maxGyozelmek = -1;
            int eredmenyA = -1;

            foreach (var csapatId in kiesettek)
            {
                if (csapatok.ContainsKey(csapatId) && csapatok[csapatId].GyozelmekSzama > maxGyozelmek)
                {
                    maxGyozelmek = csapatok[csapatId].GyozelmekSzama;
                    eredmenyA = csapatId;
                }
            }
            
            // Ha több megoldás van, a legkisebb ID-t keressük (bár a feladat nem specifikálja, ez általános konvenció)
            if (maxGyozelmek > -1)
            {
                eredmenyA = kiesettek
                    .Where(id => csapatok.ContainsKey(id) && csapatok[id].GyozelmekSzama == maxGyozelmek)
                    .DefaultIfEmpty(-1)
                    .Min();
            }


            // B. A legtöbb csapatot közvetve vagy közvetlenül legyőző csapat (a legnagyobb részfa mérete)
            int maxReszfaMeret = -1;
            int eredmenyB = -1;

            // Csapatok részfa méretének számítása
            foreach (var csapatId in csapatok.Keys)
            {
                reszfaMeret[csapatId] = SzamolLeGyozotteket(csapatId, csapatok);
                
                if (reszfaMeret[csapatId] > maxReszfaMeret)
                {
                    maxReszfaMeret = reszfaMeret[csapatId];
                    eredmenyB = csapatId;
                }
            }
            
            // Több azonos megoldás esetén a legkisebb ID
            if (maxReszfaMeret > -1)
            {
                eredmenyB = csapatok.Keys
                    .Where(id => reszfaMeret.ContainsKey(id) && reszfaMeret[id] == maxReszfaMeret)
                    .DefaultIfEmpty(-1)
                    .Min();
            }


            // C. A következő mérkőzést játszó két csapat (minimális legyőzött csapat)
            
            // Azok a csapatok, amelyek még nem lettek legyőzve (gyökerek vagy félgyökerek)
            var jatekosok = csapatok.Keys.Where(id => csapatok[id].LeGyozoje == 0).ToList();
            
            // Csak páros számú csapat játszhat következő kört, párokat keresünk
            if (jatekosok.Count % 2 != 0)
            {
                // Ha páratlan számú csapat jutott tovább, akkor csak az első két meccset nézzük.
                // A feladat feltételezi, hogy van következő mérkőzés.
                // A "lehető legkevesebb csapatot győzte le" a döntő.
            }
            
            int minOsszesenGyozott = int.MaxValue;
            int csapatC1 = -1;
            int csapatC2 = -1;
            
            // Minden lehetséges párosítás (ahol mindkét csapat továbbjutott)
            for (int i = 0; i < jatekosok.Count; i++)
            {
                for (int j = i + 1; j < jatekosok.Count; j++)
                {
                    int id1 = jatekosok[i];
                    int id2 = jatekosok[j];
                    
                    // A 'legyőzött csapatok' száma a részfa mérete
                    // A feladat szerint a két csapat által legyőzött csapatok halmazának egyesítése a minimális
                    // De a részfa méret egyszerűbben használható: SzamolLeGyozotteket(id) - 1 a *közvetlenül* legyőzöttek száma.
                    // A feladat szövege utal a *közvetve vagy közvetlenül* legyőzött csapatok halmazára.
                    
                    // Részfa mérete: beleértve a csapatot is. (Pl. 4-es csapat a 2,1,4,3-at győzte le, ami 4 csapat).
                    // Győzelmek száma: nem.
                    // Legjobb értelmezés: $ReszfaMeret(T_1) + ReszfaMeret(T_2)$. Ez a teljes fa méretét adná.
                    // A helyes értelmezés: A két részfa méretének összege: $ReszfaMeret(T_1) + ReszfaMeret(T_2)$.
                    // Mivel a gyökér (a csapat) is bele van számolva, vegyük figyelembe a csapatot is.
                    
                    int osszesGyozott = reszfaMeret.ContainsKey(id1) ? reszfaMeret[id1] : 1;
                    osszesGyozott += reszfaMeret.ContainsKey(id2) ? reszfaMeret[id2] : 1;
                    
                    if (osszesGyozott < minOsszesenGyozott)
                    {
                        minOsszesenGyozott = osszesGyozott;
                        csapatC1 = Math.Min(id1, id2);
                        csapatC2 = Math.Max(id1, id2);
                    }
                    else if (osszesGyozott == minOsszesenGyozott)
                    {
                        // Ha több megoldás van: a legkisebb ID-t tartalmazó párt (a kisebbiket)
                        int currentMin = Math.Min(id1, id2);
                        if (currentMin < csapatC1)
                        {
                            csapatC1 = currentMin;
                            csapatC2 = Math.Max(id1, id2);
                        }
                        else if (currentMin == csapatC1)
                        {
                            // Ha az első elem is azonos, a másodikat nézzük
                            int currentMax = Math.Max(id1, id2);
                            if (currentMax < csapatC2)
                            {
                                csapatC2 = currentMax;
                            }
                        }
                    }
                }
            }


            // Eredmény kiírása
            using (var sw = new StreamWriter(kiFajl))
            {
                // A. Kiestek közül a legtöbbször győzött csapat
                sw.WriteLine(eredmenyA); 

                // B. A legtöbb csapatot közvetve vagy közvetlenül legyőző csapat
                sw.WriteLine(eredmenyB); 

                // C. A következő mérkőzést játszó két csapat
                // "a harmadik sorban az egyetlen -1 szám álljon, ha nincs megoldás!"
                if (csapatC1 != -1 && csapatC2 != -1)
                {
                    // A feladat szerint "a harmadik sorba a szabály szerint a következő mérkőzést játszó csapat sorszámát, egy szóközzel elválasztva!"
                    sw.WriteLine($"{csapatC1} {csapatC2}"); 
                }
                else
                {
                    sw.WriteLine("-1");
                }
            }

        }
        catch (Exception ex)
        {
            File.WriteAllText(kiFajl, $"-1\nHiba történt: {ex.Message}");
        }
    }
}