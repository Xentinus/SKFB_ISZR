﻿namespace SKFB_ISZR.Tools
{
    internal class FamilyFriendlyPermissionConverter
    {
        public static string[][] permissions = new string[][]
            {
                 new string[] { "Abevjava", "SKFB-Abevjava; SKFB-Abevupdate" },
                 new string[] { "Adatszolgáltatások", "SKFB-Adatszolgaltatasok" },
                 new string[] { "IP hálózat scannelése", "SKFB-Advanced-IP-Scanner" },
                 new string[] { "Animula", "SKFB-Animula" },
                 new string[] { "ÁSZ ellenőrzés feltöltő", "SKFB-Asz" },
                 new string[] { "Biztonsági mentések megtekintése", "SKFB-Backups"},
                 new string[] { "Informatikai eszköznyíltántartás", "SKFB-BarniPro"},
                 new string[] { "Befogadó első letétező", "SKFB-FN-befog-elsolet" },
                 new string[] { "Belsőellenőr tudástár", "SKFB-BelsoellenorTudastar" },
                 new string[] { "BFB", "SKFB-Bfb" },
                 new string[] { "Bit jelentés", "SKFB-BIT-JELENTES" },
                 new string[] { "Biztonsági osztály Belső mappa", "SKFB-BIZT"},
                 new string[] { "Biztonsági osztály Osztályvezetői mappa", "SKFB-BIZTOV"},
                 new string[] { "Biztonsági vezetők", "SKFB-BIZTOV" },
                 new string[] { "Biztonságtechnikai fejlesztés", "SKFB-Bizttechfejlesztes" },
                 new string[] { "Bolt", "SKFB-BOLT; SKFB-FN-BOLT-BOLT1; SKFB-FN-BOLT-BOLTPARAMKEZ; SKFB-FN-BOLT-CIKKTORZSKEZELO; SKFB-FN-BVSHOP-ALLOMANYIBOLT; SKFB-FN-BVSHOP-KIETKEZOBOLT" },
                 new string[] { "Börtönadaptáció kérdőiv", "SKFB-Bortonadaptacio" },
                 new string[] { "BV BANK megtekintő", "SKFB-FN-bvbank-megtekinto" },
                 new string[] { "BV osztály Belső mappa", "SKFB-BV"},
                 new string[] { "BV osztály Osztályvezetői mappa", "SKFB-Bv-Bvov"},
                 new string[] { "BVORG Adatszolgáltatások", "SKFB-FTPUsers" },
                 new string[] { "BVORG Illetmény", "SKFB-FTPIlletmeny" },
                 new string[] { "BVORG Kommunikációs mappa", "SKFB-Kommunikacios" },
                 new string[] { "BVORG külső ellenőrzések", "SKFB-KulsoEllenorzes" },
                 new string[] { "BVORG Számfejtés", "SKFB-FTPSzamfejtes" },
                 new string[] { "BVORG A_BEF", "SKFB-BVORG-A"},
                 new string[] { "BVORG B_BIZT SZOLG", "SKFB-BVORG-B"},
                 new string[] { "BVORG C_EFOP", "SKFB-BVORG-C"},
                 new string[] { "BVORG D_ELL SZOLG", "SKFB-BVORG-D"},
                 new string[] { "BVORG E_EU FO", "SKFB-BVORG-E"},
                 new string[] { "BVORG F_FELD FO", "SKFB-BVORG-F"},
                 new string[] { "BVORG G_FOGV UGY SZOLG", "SKFB-BVORG-G"},
                 new string[] { "BVORG H_GAZD TARS FO", "SKFB-BVORG-H"},
                 new string[] { "BVORG I_HIVATAL", "SKFB-BVORG-I"},
                 new string[] { "BVORG J_HUMAN SZOLG", "SKFB-BVORG-J"},
                 new string[] { "BVORG J_HUMAN SZOLG FEGYELMI", "SKFB-BVORG-J-2"},
                 new string[] { "BVORG K_INFORMATIKAI FO", "SKFB-BVORG-K"},
                 new string[] { "BVORG KSZNYFO", "SKFB-BVORG-KSZNYFO"},
                 new string[] { "BVORG L_KFT", "SKFB-BVORG-L"},
                 new string[] { "BVORG M_KKMI", "SKFB-BVORG-M"},
                 new string[] { "BVORG N_KOMMUNIKACIOS FO", "SKFB-BVORG-N"},
                 new string[] { "BVORG O_KOZBESZ ES PROJECT FO", "SKFB-BVORG-O"},
                 new string[] { "BVORG P_KOZGAZD FO", "SKFB-BVORG-P"},
                 new string[] { "BVORG Q_KOZP ELL FO", "SKFB-BVORG-Q"},
                 new string[] { "BVORG R_MEF", "SKFB-BVORG-S"},
                 new string[] { "Cafeteria", "SKFB-Cafeteria" },
                 new string[] { "Cafeteria adminisztrátor", "SKFB-CafeteriaAdmin" },
                 new string[] { "CARREG", "SKFB-Carreg; SKFB-Carreg-Readers; SKFB-Carreg-Users" },
                 new string[] { "Cíkktörzskezelő megtekintő", "SKFB-FN-cikktorzskezelo-megtekinto" },
                 new string[] { "Csomagkezelő átadó", "SKFB-FN-csomagkezelo-atado" },
                 new string[] { "Csomagkezelő átadó szerkesztő", "SKFB-FN-csomagkezelo-atado-szerk" },
                 new string[] { "Csomagkezelő megtekintő", "SKFB-FN-csomagkezelo-megtekinto" },
                 new string[] { "Csomagkezelő szerkesztő", "SKFB-FN-csomagkezelo-szerkeszto" },
                 new string[] { "Csomagosztó", "SKFB-FN-csomagoszto" },
                 new string[] { "Díjszámláló", "SKFB-Dijszamlalo" },
                 new string[] { "EDR hibajegy rőgzítő", "SKFB-EDR-rogzito" },
                 new string[] { "EDR megtekintő", "SKFB-EDR-megtekinto" },
                 new string[] { "Egyéb szakterületek fegyelmi modulja", "SKFB-FN-Fegyelmi-egyeb-szakterulet" },
                 new string[] { "Ellenőrzési napló írása", "SKFB-Ellenorzesinaplo-biztpub-iras" },
                 new string[] { "Ellenőrzési napló olvasása", "SKFB-Ellenorzesinaplo-biztpub-olvasas" },
                 new string[] { "Értékkezelő", "SKFB-FN-ertekkezelo" },
                 new string[] { "eSzigno", "SKFB-eSzigno" },
                 new string[] { "Fegyelmi modul jogkör gyakorló", "SKFB-FN-Fegyelmi-jogkor-gyakorloja" },
                 new string[] { "Fényképek", "SKFB-Pictures" },
                 new string[] { "Fogvatartotti mobiltelefon behallgatók", "SKFB-HER-Behallgatok" },
                 new string[] { "Fogvatartotti mobiltelefon megtekintő", "SKFB-FN-TELEFON-megtekinto" },
                 new string[] { "Fogvatartotti mobiltelefon ügyintéző", "SKFB-FN-TELEFON-ugyintezo" },
                 new string[] { "Főnix 2 - Elérhető előjegyzések és ütközések", "SKFB-FN-Idorend-megtekinto" },
                 new string[] { "Főnix 2 - Ideiglenes intézet-elhagyás esetén a távozás és visszaérkezés rögzítéséhez", "SKFB-FN-Idorend-tavozas-kezelo" },
                 new string[] { "Főnix 3", "SKFB-FN3-F2020" },
                 new string[] { "Főnix 3 Mentor", "SKFB-FN3-FONIX3" },
                 new string[] { "Főnix 3 Adminisztrátor", "SKFB-FN-admin" },
                 new string[] { "Főnix 3 Mobil alkalmazások", "SKFB-FN3-Mobil" },
                 new string[] { "Főnix 3 Mobil alkalmazások adminisztrátor", "SKFB-FN3-Mentor" },
                 new string[] { "Főnix Foglalkoztatás - BFB ügyintéző", "SKFB-FN-fogl-bfb-ugyintezo" },
                 new string[] { "Főnix Foglalkoztatás - Kulturális reintegrációs tiszt", "SKFB-FN-fogl-kult-reint-tiszt" },
                 new string[] { "Főnix Foglalkoztatás - Munkaerő-gazdálkodó", "SKFB-FN-fogl-munkaerogazdalkodo" },
                 new string[] { "Főnix Foglalkoztatás - Munkahelyvezető", "SKFB-FN-fogl-munkahelyvezeto" },
                 new string[] { "Főnix Foglalkoztatás - Paraméter szerkesztő", "SKFB-FN-fogl-param-szerk" },
                 new string[] { "Főnix hívásnapló", "SKFB-FN-hivasnaplo-megtekinto" },
                 new string[] { "Főnix könyvelő", "SKFB-FN-konyvelo" },
                 new string[] { "ForrasDotNet", "SKFB-ForrasDotNet; SKFB-ForrasUsers" },
                 new string[] { "Fogvatartotti lista mappa szerkesztő", "SKFB-FogvatartottiLista-szerkesztok"},
                 new string[] { "Futárjegyzék készítő", "SKFB-Futar" },
                 new string[] { "Gazdasági osztály Belső mappa", "SKFB-GAZD"},
                 new string[] { "gazdasági osztály Gazdasági vezető mappa", "SKFB-Gazd-Gazdvez"},
                 new string[] { "Gazdasági osztály szolgálati jegy olvasása", "SKFB-Szolgjegy-gazdpub-olvas" },
                 new string[] { "Gazdasági osztály szolgálati jegy olvasása és írása", "SKFB-Szolgjegy-gazdpub-iras" },
                 new string[] { "Gyógyszer nyilvántartó", "SKFB-GyogyszerNyilvantartas" },
                 new string[] { "IKKB", "SKFB-IKKB" },
                 new string[] { "Informatikai osztály Belső mappa", "SKFB-INFO"},
                 new string[] { "Informatikai osztály Osztályvezetői mappa", "SKFB-Info-Infovez"},
                 new string[] { "Internet", "SKFB-Internet-Enabled" },
                 new string[] { "Intranet", "SKFB-Intranet" },
                 new string[] { "IrfanView", "SKFB-IrfanView" },
                 new string[] { "JFK", "SKFB-FN-JFK-FEGYJUTMEGTEKINTO" },
                 new string[] { "JKR", "SKFB-JKR; SKFB-JKR-Dashboard" },
                 new string[] { "JKR adminisztrátor", "SKFB-JKR; SKFB-JKR-Dashboard; SKFB-JKR-BMadmin" },
                 new string[] { "Kárbejelentő", "SKFB-FN-karbejelento" },
                 new string[] { "Kártalanítási adatszolgálató", "SKFB-FN-kart-adatszolgaltato" },
                 new string[] { "Kártalanítási eljárásokba betekintő", "SKFB-FN-kart-megtekinto" },
                 new string[] { "Kártalanítási ügyintéző", "SKFB-FN-kart-ugyintezo" },
                 new string[] { "Kártérítés egyéb panasz kivízsgáló", "SKFB-FN-kart-egyeb-panasz-kivizsgalo" },
                 new string[] { "Kártérítés kezelő", "SKFB-FN-karteriteskezelo" },
                 new string[] { "Készletnyilvántartó megtekintő", "SKFB-FN-KESZLETNYILVANTARTO-MEGTEKINTO" },
                 new string[] { "Készletnyilvántartó szerkesztő", "SKFB-FN-KESZLETNYILVANTARTO-SZERKESZTO" },
                 new string[] { "Kiemelt fogvatartottak táblázata", "SKFB-KiemeltFogvatartottR" },
                 new string[] { "KIRA", "SKFB-KIRAcopy" },
                 new string[] { "Közfoglalkoztatási lap", "SKFB-Kozfoglalkprog" },
                 new string[] { "Közösségi oldalak ellenőrzése", "SKFB-Kozossegi-oldalak-infopub-olvas" },
                 new string[] { "KSZF Továbbképzési portál", "SKFB-KSZFtovabbkepzes" },
                 new string[] { "KVK", "SKFB-KVKUsers" },
                 new string[] { "Létszámjelentés", "SKFB-Letszamjelentes-biztpub" },
                 new string[] { "Limitált internet", "SKFB-Internet-Limited" },
                 new string[] { "Marathon Terra", "SKFB-MarathonTerra3; SKFB-MarathonTerra" },
                 new string[] { "Másodletét kezelő", "SKFB-FN-masodlet" },
                 new string[] { "Mobil Kapcsolat", "SKFB-MobilKapcsolat" },
                 new string[] { "MOBIL készlet leltározó", "SKFB-FN-MOBIL-KESZLETNYILV-LELTAROZO" },
                 new string[] { "MOBIL készlet megtekintő", "SKFB-FN-MOBIL-KESZLETNYILV-MEGTEKINTO" },
                 new string[] { "MOBIL készlet szerkesztő", "SKFB-FN-MOBIL-KESZLETNYILV-SZERKESZTO" },
                 new string[] { "Munkáltatás", "SKFB-Munkaltatas" },
                 new string[] { "Napi jelentések", "SKFB_NapijelentesekEnabled; SKFB-Napijelentes" },
                 new string[] { "Navigator", "SKFB-FN-Navigator-megtekinto" },
                 new string[] { "Navigator belépési napló", "SKFB-FN-Navigator-belepesinaplo" },
                 new string[] { "Navigator BIT napló", "SKFB-FN-Navigator-bitnaplo" },
                 new string[] { "Navigator BIT napló jóváhagyó", "SKFB-FN-Navigator-bitnaplo-osztalyvezeto" },
                 new string[] { "Navigator éjféli adatszolgálatás", "SKFB-FN-Navigator-ejfeli-adatszolgaltatas" },
                 new string[] { "Navigator ellenőrzési napló", "SKFB-FN-Navigator-ellenorzesinaplo" },
                 new string[] { "Navigator ellenőrzési napló jóváhagyó", "SKFB-FN-Navigator-bitnaplo-jovahagyo" },
                 new string[] { "Navigator előállítási napló", "SKFB-FN-Navigator-eloallitasnaplo" },
                 new string[] { "Navigator jelentésre köteles napló", "SKFB-FN-Navigator-jelentesrekotnaplo" },
                 new string[] { "Navigator KFE napló", "SKFB-FN-Navigator-kfenaplo" },
                 new string[] { "Navigator KFFE napló", "SKFB-FN-Navigator-kffenaplo" },
                 new string[] { "Navigator körletfelügyelői ellenőrzési napló", "SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo" },
                 new string[] { "Navigator körletfelügyelői ellenőrzési napló jóváhagyó", "SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo-jovahagyo" },
                 new string[] { "Navigator körletfőfelügyelői napló jóváhagyó", "SKFB-FN-Navigator-kffenaplo-jovahagyo" },
                 new string[] { "Navigator munkahelyi szolgálati napló", "SKFB-FN-Navigator-munkahelyiszolgalatinaplo" },
                 new string[] { "Navigator munkahelyi szolgálati napló jóváhagyó", "SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo" },
                 new string[] { "Navigator eseményjelentő - agglomerációs", "SKFB-FN-Navigator-Jelento-agglomeracio"},
                 new string[] { "Navigator eseményjelentő - intézeti rögzítő", "SKFB-FN-Navigator-Jelento-rogzito"},
                 new string[] { "NEXON", "SKFB-Nexon; SKFB-NexonHRpersONLINE" },
                 new string[] { "NEXON - Intézeti Bv. vezető", "SKFB-NXN; SKFB-NX-IBVV" },
                 new string[] { "NEXON - Intézeti fegyelmi vizsgáló", "SKFB-NXN; SKFB-NX-IFEM" },
                 new string[] { "NEXON - Intézeti HR munkatárs", "SKFB-NXN; SKFB-NX-IHRM" },
                 new string[] { "NEXON - Intézeti HR vezető", "SKFB-NXN; SKFB-NX-IHRV" },
                 new string[] { "NEXON - Intézeti IT adminisztrátor", "SKFB-NXN; SKFB-NX-IITA" },
                 new string[] { "NEXON - Intézeti szabadság nyilvántartók", "SKFB-NXN; SKFB-NX-SZAB" },
                 new string[] { "NEXON - Intézeti szolgálat adminisztrátor", "SKFB-NXN; SKFB-NX-ISZA" },
                 new string[] { "NEXON - Intézeti szolgálattervező", "SKFB-NXN; SKFB-NX-ISZM" },
                 new string[] { "Noemi HelpDesk", "SKFB-NoemiHelpDesk" },
                 new string[] { "NYDR Biztonsági osztály", "SKFB-NYDR; SKFB-NYDR-Bizt" },
                 new string[] { "NYDR BV osztály", "SKFB-NYDR; SKFB-NYDR-Human" },
                 new string[] { "NYDR Egészségügyi osztály", "SKFB-NYDR; SKFB-NYDR-Eu" },
                 new string[] { "NYDR Gazdasági osztály", "SKFB-NYDR; SKFB-NYDR-Gazd" },
                 new string[] { "NYDR Informatikai osztály", "SKFB-NYDR; SKFB-NYDR-Inf" },
                 new string[] { "NYDR Pszichológusok", "SKFB-NYDR; SKFB-NYDR-Pszich" },
                 new string[] { "NYDR Reintegrációs tisztek", "SKFB-NYDR; SKFB-NYDR-Reint" },
                 new string[] { "Okmánykezelő", "SKFB-FN-okmanykezelo" },
                 new string[] { "Opten Céginfo", "SKFB-OptenCeginfo" },
                 new string[] { "Opten Iratminta", "SKFB-OptenIratminta" },
                 new string[] { "Opten Optijus", "SKFB-OptenOptijus" },
                 new string[] { "Opten Optijus Plussz", "SKFB-OptenOptijusPlussz" },
                 new string[] { "Optiproba", "SKFB-Optiproba" },
                 new string[] { "PME Bizottság", "SKFB-FN-PME-bizottsag" },
                 new string[] { "PME Egészségügy", "SKFB-FN-PME-egeszsegugy" },
                 new string[] { "PME Egészségügy megtekintő", "SKFB-FN-PME-egeszsegugy-megt" },
                 new string[] { "PME Nyilvántartás", "SKFB-FN-PME-nyilvantartas" },
                 new string[] { "PME Nyilvántartás megtekintő", "SKFB-FN-PME-nyilvantartas-megt" },
                 new string[] { "PME Pszichológia", "SKFB-FN-PME-pszichologia" },
                 new string[] { "PME Pszichológia megtekintő", "SKFB-FN-PME-pszichologia-megt" },
                 new string[] { "PME Reintegráció", "SKFB-FN-PME-reintegracio" },
                 new string[] { "PME Reintegráció megtekintő", "SKFB-FN-PME-reintegracio-megt" },
                 new string[] { "PME Ügyintéző", "SKFB-FN-PME-ugyintezo" },
                 new string[] { "ProDoki", "SKFB-ProDoki" },
                 new string[] { "Pszichológiai programok", "SKFB-PszichoProgramok" },
                 new string[] { "Putty SSH kliens", "SKFB-Putty"},
                 new string[] { "PTTR megtekintő", "SKFB-FN-PTTR-Megtekinto" },
                 new string[] { "PTTR ügyintéző", "SKFB-FN-PTTR-Ugyintezo" },
                 new string[] { "QB-Élelem - Élelmezésvezető", "SKFB-FN-ELELEM-elelmezv" },
                 new string[] { "QB-Élelem - Gazdasági vezető", "SKFB-FN-ELELEM-gazdvez" },
                 new string[] { "QB-Élelem - Konyhavezető", "SKFB-FN-ELELEM-konyhav" },
                 new string[] { "QB-Élelem - Rendszergazda", "SKFB-FN-ELELEM-rendsz" },
                 new string[] { "Reintegrációs őrízet", "SKFB-Reintegracio" },
                 new string[] { "Reintegrációs tiszti fegyelmi modul", "SKFB-FN-Fegyelmi-reintegracios-tiszt" },
                 new string[] { "RobotZsaru NEO", "SKFB-RobotZsaruNEO" },
                 new string[] { "RobotZsaru NOVA", "SKFB-RobotZsaruNOVA" },
                 new string[] { "RobotZsaru Sajtó", "SKFB-SajtoRZS" },
                 new string[] { "SAFE", "SKFB-FN-Rebeka-felhasznalo" },
                 new string[] { "SAFE adminisztrátor", "SKFB-FN-Safe-admin" },
                 new string[] { "Scan - Biztonsági osztály", "SKFB-Scan-Bizt"},
                 new string[] { "Scan - BV osztály", "SKFB-Scan-Bv"},
                 new string[] { "Scan - EFOP", "SKFB-Scan-Efop"},
                 new string[] { "Scan - Egészségügyi osztály", "SKFB-Scan-Eu"},
                 new string[] { "Scan - Gazdasági osztály", "SKFB-Scan-Gazd"},
                 new string[] { "Scan - Gazdasági társaság", "SKFB-Scan-Gt"},
                 new string[] { "Scan - Informatikai osztály", "SKFB-Scan-Info"},
                 new string[] { "Scan - Párfogó", "SKFB-Scan-Pf"},
                 new string[] { "Scan - Parancsnoki titkárság", "SKFB-Scan-Pk"},
                 new string[] { "Scan - Személyügyi osztály", "SKFB-Scan-Szem"},
                 new string[] { "Scan - Vezetői követlen osztály", "SKFB-Scan-Vezkozv"},
                 new string[] { "SCPI", "SKFB-Scpi" },
                 new string[] { "Szabálysértési adatszolgáltatás", "SKFB-SzabStat" },
                 new string[] { "Számlamegtekintő", "SKFB-FN-szamlamegtekinto" },
                 new string[] { "Szenyor", "SKFB-Szenyor" },
                 new string[] { "Szolgálat szervező csoport", "SKFB-SzolgalatSzervezes"},
                 new string[] { "Szerződés nyilvántartó megtekintő", "SKFB-FN-SZERZODES-MEGTEKINTO" },
                 new string[] { "Szerződés nyilvántartó szerkesztő", "SKFB-FN-SZERZODES-SZERKESZTO" },
                 new string[] { "Szinteslista olvasása", "SKFB-Szinteslista-bvpub-olvas" },
                 new string[] { "Szinteslista olvasása és írása", "SKFB-Szinteslista-bvpub-iras" },
                 new string[] { "Talált tárgyak", "SKFB-FN-talalttargy" },
                 new string[] { "TAMOP", "SKFB-TAMOP" },
                 new string[] { "Tárgy raktáros", "SKFB-FN-targyraktaros" },
                 new string[] { "Távtárgyalás adatszolgáltató", "SKFB-Tavtargyalas adatszolgaltato" },
                 new string[] { "Temperamentum", "SKFB-Temperamentum" },
                 new string[] { "TÉR", "SKFB-Ter" },
                 new string[] { "Toborzási csoport", "SKFB-Toborzas" },
                 new string[] { "Túlóra jelentést készítő", "SKFB-Tulora" },
                 new string[] { "Ügyfélkapu", "SKFB-Ugyfelkapu" },
                 new string[] { "Vezetői elfoglaltság táblázat", "SKFB-Vezetoi-elfoglaltsag" },
                 new string[] { "Vezetői jelenlét", "SKFB-VezetoiJelenlet" },
                 new string[] { "Vezetői jelenlét GT", "SKFB-VezetoiJelenletGT" },
                 new string[] { "Vezetői szignáló", "SKFB-VezetoiSzignalas" },
                 new string[] { "VIR Egészségügy", "SKFB-Vir; SKFB-VIR-Egeszsegugy-User" },
                 new string[] { "VIR FTTR", "SKFB-VIR-FTTR-User" },
                 new string[] { "VIR Létszám", "SKFB-VIR-Letszam-User" },
                 new string[] { "VIR Munkáltatás", "SKFB-VIR-Munkaltatas-User; SKFB-FN-VIR-MUNKALTATAS" },
                 new string[] { "VIR Pénzügy", "SKFB-VIR-Penzugy-User" },
                 new string[] { "VIR PTTR", "SKFB-VIR-PTTR-User" },
                 new string[] { "VIR RIN", "SKFB-VIR-RIN-User" },
                 new string[] { "Visual iXdoki", "SKFB-VisualIxdoki" },
                 new string[] { "Zabbix hálózat ellenőrző", "SKFB-Zabbix"},
            };

        public static string ReturnFamilyFriendlyName(string normalPermissionName)
        {
            for (int i = 0; i < permissions.Length; i++)
            {
                if (permissions[i][1].Contains(normalPermissionName)) return permissions[i][0];
            }
            return " ";
        }

        public static string ReturnNormalPermissionName(string familyFriendlyPermissionName)
        {
            for (int i = 0; i < permissions.Length; i++)
            {
                if (permissions[i][0].Contains(familyFriendlyPermissionName)) return permissions[i][1];
            }
            return " ";
        }
    }
}