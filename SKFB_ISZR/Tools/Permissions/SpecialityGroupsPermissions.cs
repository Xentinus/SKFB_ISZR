namespace SKFB_ISZR
{
    // Csoportok alap jogosultságaik
    internal class SpecialityGroupsPermissions
    {
        // Ha az adott csoportnak nincs semmi egyedi jogosultsága
        private const string noPermissions = " ";

        // Biztonsági osztály csoportjainak jogosultságai
        private static string GetBiztPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Biztonsági felügyelők":
                    {
                        return "SKFB-Bizt-Bfe; SKFB-FN-SKFB-EGYEDI7";
                    }
                case "Biztonsági főfelügyelők":
                    {
                        return "SKFB-BIT; SKFB-Bizt-Bit; SKFB-Bizt-Bit-Iszak; SKFB-Bizt-Bit-IIszak; SKFB-Bizt-Bit-IIIszak; SKFB-Bizt-Bit-IVszak; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-befbiz; SKFB-FN-biom-adatmegtek; SKFB-FN-bunnyilv; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-ejfeli-adatszolgaltatas; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-nevelok; SKFB-KiemeltFogvatartottR; SKFB-Letszamjelentes-biztpub; SKFB-MarathonTerra3; SKFB-Nexon; SKFB-NexonHRpersOnline; SKFB-NX-ISZM; SKFB-OptenOptijus";
                    }
                case "Biztonsági tisztek":
                    {
                        return "SKFB-BIT; SKFB-Bizt-Bit; SKFB-Bizt-Bit-Iszak; SKFB-Bizt-Bit-IIszak; SKFB-Bizt-Bit-IIIszak; SKFB-Bizt-Bit-IVszak; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-befbiz; SKFB-FN-biom-adatmegtek; SKFB-FN-bunnyilv; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-ejfeli-adatszolgaltatas; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-nevelok; SKFB-KiemeltFogvatartottR; SKFB-Letszamjelentes-biztpub; SKFB-MarathonTerra3; SKFB-Nexon; SKFB-NexonHRpersOnline; SKFB-NX-ISZM; SKFB-OptenOptijus; SKFB-FN-TELEFON-ugyintezo";
                    }
                case "Biztonsági osztályvezető":
                    {
                        return "SKFB-Bizt-Biztov; SKFB-FN-bizt-ov; SKFB-BIT-JELENTES; SKFB-BIZTOV; SKFB-FN-biom-adatmegtek; SKFB-FN-int-vedett; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-jovahagyo; SKFB-FN-Navigator-bitnaplo-osztalyvezeto; SKFB-FN-Navigator-ejfeli-adatszolgaltatas; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-FTPUsers; SKFB-FTPVedelem; SKFB-IKKB; SKFB-IrfanView; SKFB-KiemeltFogvatartottR; SKFB-Kozossegi-oldalak-infopub-olvas; SKFB-Letszamjelentes-biztpub; SKFB-MarathonTerra3; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-ISZM; SKFB-NYDR; SKFB-NYDR-Bizt; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-Ter; SKFB-VezetoiSzignalas; SKFB-Vezetok; SKFB-Vir; SKFB-VIR-Munkaltatas-User";
                    }
                case "Biztonsági osztályvezető helyettes":
                    {
                        return "SKFB-Bizt-Biztov; SKFB-FN-bizt-ov; SKFB-BIT-JELENTES; SKFB-BIZTOV; SKFB-FN-biom-adatmegtek; SKFB-FN-int-vedett; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-jovahagyo; SKFB-FN-Navigator-bitnaplo-osztalyvezeto; SKFB-FN-Navigator-ejfeli-adatszolgaltatas; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-FTPUsers; SKFB-FTPVedelem; SKFB-IKKB; SKFB-IrfanView; SKFB-KiemeltFogvatartottR; SKFB-Kozossegi-oldalak-infopub-olvas; SKFB-Letszamjelentes-biztpub; SKFB-MarathonTerra3; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-ISZM; SKFB-NYDR; SKFB-NYDR-Bizt; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-Ter; SKFB-VezetoiSzignalas; SKFB-Vezetok; SKFB-Vir; SKFB-VIR-Munkaltatas-User";
                    }
                case "Fegyveres biztonsági őr":
                    {
                        return noPermissions;
                    }
                case "Kutyavezetők":
                    {
                        return "SKFB-Bizt-Kutyavezeto; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-fogugykez; SKFB-FN-karbejelento; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-Nexon; SKFB-NX-ISZM; SKFB-NX-SZAB";
                    }
                case "Kutyatelep-vezető":
                    {
                        return "SKFB-Bizt-Kutyavezeto; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-fogugykez; SKFB-FN-karbejelento; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-Nexon; SKFB-NX-ISZM; SKFB-NX-SZAB";
                    }
                case "Műveleti csoport":
                    {
                        return "SKFB-Bizt-MuveletiCsoport; SKFB-FN-befbiz; SKFB-FN-fogugykez; SKFB-FN-karbejelento; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo";
                    }
                case "Fegyvermester":
                    {
                        return "SKFB-NexonHRpersONLINE";
                    }
                case "Szállításvezető":
                    {
                        return "SKFB-Bizt-Szallitasvezeto; SKFB-Szallitasvez";
                    }
                case "Titkárság":
                    {
                        return "SKFB-FN-biom-adatmegtek; SKFB-FN-karbejelento; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FTPUsers; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-NX-ISZM; SKFB-NX-SZAB; SKFB-VezetoiSzignalas";
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // BV osztály csoportjainak jogosultságai
        private static string GetBVPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Büntetés-végrehajtási osztályvezető":
                    {
                        return "SKFB-Bv-Bvov; SKFB-Bfb; SKFB-BIT-JELENTES; SKFB-Bv-Reintegracio; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-eSzigno; SKFB-FN-befbiz; SKFB-FN-BFB-ugyintezo; SKFB-FN-biom-adatmegtek; SKFB-FN-csomagkezelo-atado; SKFB-FN-csomagkezelo-atado-szerk; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-FN-int-vedett; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-kart-adatszolgaltato; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-kart-ugyintezo; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-bitnaplo-korletfofelugyelo; SKFB-FN-Navigator-bitnaplo-osztalyvezeto; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-megtekinto; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-FN-PME-reintegracio; SKFB-FN-PME-ugyintezo; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FTPUsers; SKFB-FTPVedelem; SKFB-IKKB; SKFB-IrfanView; SKFB-KiemeltFogvatartottR; SKFB-Kozossegi-oldalak-infopub-olvas; SKFB-Letszamjelentes-biztpub; SKFB-MarathonTerra3; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-ISZA; SKFB-NX-ISZM; SKFB-NX-SZAB; SKFB-NYDR; SKFB-NYDR-Reint; SKFB-OptenOptijusPlussz; SKFB-Ter; SKFB-VezetoiSzignalas; SKFB-Vezetok; SKFB-Vir; SKFB-VIR-Munkaltatas-User";
                    }
                case "Körlet felügyelők":
                    {
                        return "SKFB-Bv-Kfe; SKFB-FN-korl-felugy";
                    }
                case "Körlet főfelügyelők":
                    {
                        return "SKFB-Bv-Kffe; SKFB-Bv-Kffe-KBK; SKFB-FN-Navigator-bitnaplo-korletfofelugyelo; SKFB-FN-korl-fofelugy; SKFB-FN-Fegyelmi-fofelugyelo; SKFB-Bv-Kffe-Iszak; SKFB-Bv-Kffe-IIszak; SKFB-Bv-Kffe-IIIszak; SKFB-Bv-Kffe-IVszak; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-befbiz; SKFB-FN-biom-adatmegtek; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-karbejelento; SKFB-FN-korl-fofelugy; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-korletfofelugyelo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-kffenaplo; SKFB-FN-Navigator-megtekinto; SKFB-FN-SKFB-EGYEDI8; SKFB-Letszamjelentes-biztpub; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-ISZM; SKFB-VezetoiSzignalas";
                    }
                case "Bűnügyi nyilvántartók":
                    {
                        return "SKFB-Bv-Nyilvantarto; SKFB-FN-bunnyilv; SKFB-Abevjava; SKFB-Bfb; SKFB-eSzigno; SKFB-FN-befbiz; SKFB-FN-biom-adatmegtek; SKFB-FN-bunnyilv; SKFB-FN-bunnyilv-ov; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-FN-fogugykez; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-kart-ugyintezo; SKFB-FN-PME-nyilvantartas; SKFB-FN-PME-nyilvantartas-megt; SKFB-FN-PME-ugyintezo; SKFB-FTPUsers; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-SzabStat; SKFB-Tavtargyalas adatszolgaltato";
                    }
                case "Nyilvántartási osztályvezető-helyettes":
                    {
                        return "SKFB-Bv-Nyilvantartovez; SKFB-FN-bunnyilv-ov; SKFB-Abevjava; SKFB-Bfb; SKFB-Bv-Bvov; SKFB-Bv-Nyilvantarto; SKFB-Bv-Nyilvantartovez; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-eSzigno; SKFB-FN-befbiz; SKFB-FN-biom-adatmegtek; SKFB-FN-bunnyilv; SKFB-FN-bunnyilv-ov; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogugykez; SKFB-FN-fogugykez-ov; SKFB-FN-int-vedett; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-kart-ugyintezo; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo; SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo-jovahagyo; SKFB-FN-Navigator-megtekinto; SKFB-FN-PME-nyilvantartas; SKFB-FN-PME-nyilvantartas-megt; SKFB-FN-PME-ugyintezo; SKFB-FTPUsers; SKFB-IKKB; SKFB-IrfanView; SKFB-KiemeltFogvatartottR; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-ISZM; SKFB-OptenOptijusPlussz; SKFB-SzabStat; SKFB-Tavtargyalas adatszolgaltato; SKFB-Ter; SKFB-VezetoiSzignalas; SKFB-Vezetok";
                    }
                case "Körlet ellátó főfelügyelő (Anyagi)":
                    {
                        return "SKFB-Bv-Anyagi; SKFB-FN-befog-elsolet; SKFB-FN-csomagkezelo-atado; SKFB-FN-csomagkezelo-atado-szerk; SKFB-FN-csomagoszto; SKFB-FN-Fegyelmi-fofelugyelo; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogugykez; SKFB-FN-karbejelento; SKFB-FN-korl-fofelugy; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-PME-ugyintezo; SKFB-FN-ruhazatmegtekint; SKFB-FN-ruhazatraktaros; SKFB-FN-targyraktaros; SKFB-ForrasDotNet; SKFB-ForrasUsers; SKFB-NexonHRpersONLINE";
                    }
                case "Körlet ellátó segédelőadó (Anyagi)":
                    {
                        return "SKFB-Bv-Anyagi; SKFB-FN-befog-elsolet; SKFB-FN-csomagkezelo-atado; SKFB-FN-csomagkezelo-atado-szerk; SKFB-FN-csomagoszto; SKFB-FN-Fegyelmi-fofelugyelo; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogugykez; SKFB-FN-karbejelento; SKFB-FN-korl-fofelugy; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-PME-ugyintezo; SKFB-FN-ruhazatmegtekint; SKFB-FN-ruhazatraktaros; SKFB-FN-targyraktaros; SKFB-ForrasDotNet; SKFB-ForrasUsers; SKFB-NexonHRpersONLINE";
                    }
                case "Reintegraciós tisztek":
                    {
                        return "SKFB-Bv-Reintegracio; SKFB-FN-nevelok; SKFB-Bfb; SKFB-FlashEnabled; SKFB-FN-befbiz; SKFB-FN-BFB-ugyintezo; SKFB-FN-biom-nevelo; SKFB-FN-bunnyilv; SKFB-FN-bvbank-megtekinto; SKFB-FN-csomagkezelo-atado; SKFB-FN-csomagoszto; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-FN-fegyugykez; SKFB-FN-hivasnaplo-megtekinto; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-karbejelento; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-Navigator-megtekinto; SKFB-FN-PME-reintegracio; SKFB-FN-PME-ugyintezo; SKFB-FN-SKFB-EGYEDI2; SKFB-FN-TELEFON-ugyintezo; SKFB-FTPUsers; SKFB-HER-Behallgatok; SKFB-NexonHRpersONLINE";
                    }
                case "Vezető Reintegrációs tiszt":
                    {
                        return "SKFB-Bfb; SKFB-Bv-Reintegracio; SKFB-FlashEnabled; SKFB-FN-befbiz; SKFB-FN-BFB-ugyintezo; SKFB-FN-biom-nevelo; SKFB-FN-bunnyilv; SKFB-FN-bvbank-megtekinto; SKFB-FN-csomagkezelo-atado; SKFB-FN-csomagoszto; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-FN-fegyugykez; SKFB-FN-fogugykez; SKFB-FN-hivasnaplo-megtekinto; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-karbejelento; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-megtekinto; SKFB-FN-nevelok; SKFB-FN-PME-reintegracio; SKFB-FN-PME-ugyintezo; SKFB-FN-SKFB-EGYEDI2; SKFB-FN-TELEFON-ugyintezo; SKFB-FTPUsers; SKFB-HER-Behallgatok; SKFB-NexonHRpersONLINE; SKFB-Ter";
                    }
                case "Szociális előadók":
                    {
                        return "SKFB-Bv-Szoceloado; SKFB-FN-admin; SKFB-FN-befbiz; SKFB-FN-BFB-ugyintezo; SKFB-FN-bunnyilv; SKFB-FN-bvbank-megtekinto; SKFB-FN-fegyugykez; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogugykez; SKFB-FN-karbejelento; SKFB-FN-korl-felugy; SKFB-FN-Navigator-bitnaplo-korletfofelugyelo; SKFB-FN-nevelok; SKFB-FN-PME-ugyintezo; SKFB-FN-SKFB-EGYEDI7; SKFB-Letszamjelentes-biztpub; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-ISZM; SKFB-NX-SZAB";
                    }
                case "Pártfogó felügyelők":
                    {
                        return "SKFB-PARTFOGO; SKFB-Scan-Pf; SKFB-Abevjava; SKFB-eSzigno; SKFB-FN-bunnyilv; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-FN-Navigator-megtekinto; SKFB-FN-nevelok; SKFB-FN-PTTR-Ugyintezo; SKFB-VezetoiSzignalas";
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // EFOP csoportjainak jogosultságai
        private static string GetEFOPPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Csoportvezető":
                    {
                        return "SKFB-Bfb; SKFB-BIT-JELENTES; SKFB-BV; SKFB-Bv-Bvov; SKFB-Bv-Reintegracio; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-eSzigno; SKFB-FlashEnabled; SKFB-FN-befbiz; SKFB-FN-BFB-ugyintezo; SKFB-FN-biom-adatmegtek; SKFB-FN-biom-nevelo; SKFB-FN-bunnyilv; SKFB-FN-bvbank-megtekinto; SKFB-FN-csomagkezelo-atado; SKFB-FN-csomagkezelo-atado-szerk; SKFB-FN-csomagoszto; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-FN-fegyugykez; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogugykez-ov; SKFB-FN-hivasnaplo-megtekinto; SKFB-FN-int-vedett; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-karbejelento; SKFB-FN-kart-adatszolgaltato; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-kart-ugyintezo; SKFB-FN-korl-fofelugy; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-jovahagyo; SKFB-FN-Navigator-bitnaplo-korletfofelugyelo; SKFB-FN-Navigator-bitnaplo-osztalyvezeto; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-megtekinto; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-FN-PME-bizottsag; SKFB-FN-PME-reintegracio; SKFB-FN-PME-ugyintezo; SKFB-FN-RIN-EFOPESETMENEDZSER; SKFB-FN-SKFB-EGYEDI2; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-TELEFON-megtekinto; SKFB-FTPUsers; SKFB-FTPVedelem; SKFB-HER-Behallgatok; SKFB-IKKB; SKFB-IrfanView; SKFB-KiemeltFogvatartottR; SKFB-Kozossegi-oldalak-infopub-olvas; SKFB-Letszamjelentes-biztpub; SKFB-MarathonTerra3; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-NX-ISZA; SKFB-NX-ISZM; SKFB-NX-SZAB; SKFB-NYDR; SKFB-NYDR-Reint; SKFB-OptenOptijus; SKFB-OptenOptijusPlussz; SKFB-Pictures; SKFB-Ter; SKFB-VezetoiSzignalas";
                    }
                case "Pályázati tanácsadók":
                    {
                        return "SKFB-FN-bunnyilv; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-nevelok; SKFB-FN-RIN-EFOPESETMENEDZSER; SKFB-FTPUsers; SKFB-Pictures; SKFB-TAMOP";
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // Egészségügyi osztály csoportjainak jogosultságai
        private static string GetEUPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Előadók":
                    {
                        return "SKFB-Eu-Apolo; SKFB-FN-EU-AlapellatasAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasFogv-Orvos; SKFB-FN-EU-Befogado-Orvos; SKFB-FN-EU-FogaszatAll-Orvos; SKFB-FN-EU-FogaszatFogv-Orvos; SKFB-FN-EU-FoglalkEUAll-Orvos; SKFB-FN-EU-FoglalkozasEuAll-Orvos; SKFB-FN-EU-FoglalkozasEuFogv-Orvos; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-FN-EU-Sebeszet-Orvos; SKFB-FN-EU-Szemeszet-Orvos; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-PME-egeszsegugy; SKFB-FN-PME-egeszsegugy-megt; SKFB-FN-PME-pszichologia-megt; SKFB-FTPUsers; SKFB-GyogyszerNyilvantartas; SKFB-NoemiHelpDesk; SKFB-NX-SZAB; SKFB-Pictures; SKFB-ProDoki; SKFB-VisualIxdoki";
                    }
                case "Szakápolók":
                    {
                        return "SKFB-Eu-Apolo; SKFB-FN-EU-AlapellatasAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasFogv-Orvos; SKFB-FN-EU-Befogado-Orvos; SKFB-FN-EU-FogaszatAll-Orvos; SKFB-FN-EU-FogaszatFogv-Orvos; SKFB-FN-EU-FoglalkEUAll-Orvos; SKFB-FN-EU-FoglalkozasEuAll-Orvos; SKFB-FN-EU-FoglalkozasEuFogv-Orvos; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-FN-EU-Sebeszet-Orvos; SKFB-FN-EU-Szemeszet-Orvos; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-PME-egeszsegugy; SKFB-FN-PME-egeszsegugy-megt; SKFB-FN-PME-pszichologia-megt; SKFB-FTPUsers; SKFB-GyogyszerNyilvantartas; SKFB-NoemiHelpDesk; SKFB-NX-SZAB; SKFB-Pictures; SKFB-ProDoki; SKFB-VisualIxdoki";
                    }
                case "Főápolók":
                    {
                        return "SKFB-Bfb; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-Eu-Apolo; SKFB-FlashEnabled; SKFB-FN-EU-AlapellatasAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasFogv-Orvos; SKFB-FN-EU-Befogado-Orvos; SKFB-FN-EU-FogaszatAll-Orvos; SKFB-FN-EU-FogaszatBefogado-Orvos; SKFB-FN-EU-FogaszatFogv-Orvos; SKFB-FN-EU-FoglalkEUAll-Orvos; SKFB-FN-EU-FoglalkozasEuAll-Orvos; SKFB-FN-EU-FoglalkozasEuFogv-Orvos; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-FN-EU-Sebeszet-Orvos; SKFB-FN-EU-Szemeszet-Orvos; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-kart-ugyintezo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-megtekinto; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-FN-PME-egeszsegugy; SKFB-FN-PME-egeszsegugy-megt; SKFB-FN-PME-pszichologia-megt; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-ForrasDotNet; SKFB-ForrasUsers; SKFB-FTPUsers; SKFB-GyogyszerNyilvantartas; SKFB-IKKB; SKFB-Letszamjelentes-biztpub; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-NX-ISZM; SKFB-NX-SZAB; SKFB-NYDR; SKFB-NYDR-Eu; SKFB-Pictures; SKFB-ProDoki; SKFB-Ter; SKFB-VezetoiSzignalas; SKFB-Vezetok; SKFB-VisualIxdoki";
                    }
                case "Egészségügyi osztályvezető":
                    {
                        return "SKFB-Bfb; SKFB-BIT-JELENTES; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-Eu-Egeszsegugyvez; SKFB-FlashEnabled; SKFB-FN-BvOrvos; SKFB-FN-EU-AlapellatasAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasFogv-Orvos; SKFB-FN-EU-Befogado-Orvos; SKFB-FN-EU-FoglalkEUAll-Orvos; SKFB-FN-EU-FoglalkozasEuAll-Orvos; SKFB-FN-EU-FoglalkozasEuFogv-Orvos; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-FN-EU-Sebeszet-Orvos; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-megtekinto; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-PME-egeszsegugy; SKFB-FN-PME-egeszsegugy-megt; SKFB-FN-PME-pszichologia-megt; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-ForrasDotNet; SKFB-ForrasUsers; SKFB-Letszamjelentes-biztpub; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-ISZM; SKFB-NX-SZAB; SKFB-NYDR; SKFB-NYDR-Eu; SKFB-OptenOptijusPlussz; SKFB-Pictures; SKFB-ProDoki; SKFB-Ter; SKFB-VezetoiSzignalas; SKFB-Vezetok; SKFB-VisualIxdoki";
                    }
                case "Orvosok":
                    {
                        return "SKFB-Eu-Egeszsegugyvez; SKFB-FN-BvOrvos; SKFB-FN-EU-AlapellatasAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasFogv-Orvos; SKFB-FN-EU-Befogado-Orvos; SKFB-FN-EU-FoglalkEUAll-Orvos; SKFB-FN-EU-FoglalkozasEuAll-Orvos; SKFB-FN-EU-FoglalkozasEuFogv-Orvos; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-FN-EU-Sebeszet-Orvos; ";
                    }
                case "Fogszakorvos":
                    {
                        return "SKFB-FN-EU-FogaszatAll-Orvos; SKFB-FN-EU-FogaszatBefogado-Orvos; SKFB-FN-EU-FogaszatFogv-Orvos";
                    }
                case "Fogszakorvos asszisztens":
                    {
                        return "SKFB-FN-EU-FogaszatAll-Orvos; SKFB-FN-EU-FogaszatBefogado-Orvos; SKFB-FN-EU-FogaszatFogv-Orvos";
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // Gazdasági osztály csoportjainak jogosultságai
        private static string GetGazdosztPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Anyaggazdálkodási főelőadó":
                    {
                        return "SKFB-Gazd-Anyaggazdvez; SKFB-ForrasUsers; SKFB-Gazd-Raktar; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-csomagoszto; SKFB-FN-penzugy; SKFB-FN-targyraktaros; SKFB-Pictures; SKFB-FN-befog-elsolet; SKFB-FN-masodlet; SKFB-FN-okmanykezelo; SKFB-FN-biom-adatmegtek; SKFB-FN-ruhazatmegtekint; SKFB-FN-ruhazatraktaros; SKFB-FTPUsers; SKFB-FTPIlletmeny; SKFB-FN-SKFB-EGYEDI3; SKFB-FN-SKFB-EGYEDI6; SKFB-NexonHRpersONLINE; SKFB-FN-talalttargy; SKFB-MobilKapcsolat; SKFB-NoemiHelpDesk; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-ForrasDotNet; SKFB-FN-karbejelento; SKFB-FN-TELEFON-ugyintezo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; ";
                    }
                case "Gazdasági vezető":
                    {
                        return "SKFB-ForrasUsers; SKFB-CafeteriaAdmin; SKFB-Gazd-Szamvitel; SKFB-Gazd-Gazdvez; SKFB-Vezetok; SKFB-IrfanView; SKFB-Abevjava;; SKFB-GyogyszerNyilvantartas; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-ELELEM-gazdvez; SKFB-Gazd-Muszaki; SKFB-OptenOptijusPlussz; SKFB-FN-gazdasagi-ov; SKFB-FN-biom-adatmegtek; SKFB-FTPUsers; SKFB-NexonHRpersONLINE ; SKFB-FN-hivasnaplo-megtekinto; SKFB-VEZKOZV; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Vir; SKFB-VIR-Munkaltatas-User; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-ForrasDotNet; SKFB-Szolgjegy-gazdpub-olvas; SKFB-FN-bvbank-megtekinto; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-Tulora; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-Bizttechfejlesztes; SKFB-BIT-JELENTES; SKFB-FN-Navigator-megtekinto; SKFB-FN-Navigator-ellenorzesinaplo-jova; SKFB-JKR; SKFB-NYDR-Gazd; SKFB-NYDR; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-IKKB; SKFB-Adatszolgaltatasok";
                    }
                case "Gépház raktárosok":
                    {
                        return "SKFB-ForrasUsers; SKFB-NexonHRpersONLINE; SKFB-Gazd-Gephazraktar; SKFB-ForrasDotNet; SKFB-FN-Navigator-munkahelyiszolgalatinaplo";
                    }
                case "Gépház vezetők":
                    {
                        return "SKFB-ForrasUsers; SKFB-Gazd-Gephazvez; SKFB-IrfanView; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-fogugykez; SKFB-FN-befbiz; SKFB-FN-biom-adatmegtek; SKFB-FTPUsers; SKFB-FN-SKFB-EGYEDI6; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-PME-nyilvantartas-megt; SKFB-ForrasDotNet; SKFB-Letszamjelentes-biztpub; SKFB-Bizttechfejlesztes; SKFB-FN-Navigator-munkahelyiszolgalatinaplo";
                    }
                case "Gépjárművezetők":
                    {
                        return "SKFB-Gazd-Gepjarmu; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Carreg-Users; SKFB-Carreg-Readers; SKFB-FTPUsers; SKFB-Optiproba; SKFB-NexonHRpersONLINE; SKFB-Carreg; SKFB-JKR-BMadmin";
                    }
                case "Műszaki csoport":
                    {
                        return "SKFB-Gazd-Muszaki; SKFB-FlashEnabled; SKFB-OptenOptijus; SKFB-Pictures; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-VezetoiSzignalas; SKFB-Vir; SKFB-VIR-Munkaltatas-User; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-Szolgjegy-gazdpub-iras; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-JKR; SKFB-JKR-BMadmin; SKFB-Adatszolgaltatasok; SKFB-FN-SKFB-EGYEDI5";
                    }
                case "Pénzügyi csoport":
                    {
                        return "SKFB-Gazd-Penzugy; SKFB-GyogyszerNyilvantartas; SKFB-FN-csomagoszto; SKFB-FN-penzugy; SKFB-FN-targyraktaros; SKFB-FN-ertekkezelo; SKFB-Pictures; SKFB-FN-befog-elsolet; SKFB-FN-masodlet; SKFB-FN-okmanykezelo; SKFB-FN-konyvelo; SKFB-FN-karteriteskezelo; SKFB-FN-penzugyparamkez; SKFB-NexonHRpersONLINE; SKFB-FN-talalttargy; SKFB-FN-hivasnaplo-megtekinto; SKFB-NoemiHelpDesk; SKFB-FN-TELEFON-megtekinto; SKFB-FN-Rebeka-felhasznalo; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-Navigator-megtekinto; SKFB-Abevjava; SKFB-NX-ISZM; SKFB-Nexon; SKFB-OptenOptijus; SKFB-NX-SZAB; SKFB-Letszamjelentes-biztpub";
                    }
                case "Raktárosok":
                    {
                        return "SKFB-ForrasUsers; SKFB-Gazd-Raktar; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-csomagoszto; SKFB-FN-penzugy; SKFB-FN-targyraktaros; SKFB-FN-ertekkezelo; SKFB-FN-fogugykez; SKFB-FN-befog-elsolet; SKFB-FN-masodlet; SKFB-FN-okmanykezelo; SKFB-FN-biom-adatmegtek; SKFB-FN-ruhazatmegtekint; SKFB-FN-ruhazatraktaros; SKFB-FTPUsers; SKFB-FTPIlletmeny; SKFB-FN-SKFB-EGYEDI3; SKFB-FN-SKFB-EGYEDI6; SKFB-NexonHRpersONLINE; SKFB-FN-talalttargy; SKFB-MobilKapcsolat; SKFB-NoemiHelpDesk; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-ForrasDotNet; SKFB-Szolgjegy-gazdpub-olvas; SKFB-FN-TELEFON-ugyintezo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-Navigator-megtekinto; SKFB-FN-befbiz; SKFB-FN-bunnyilv; SKFB-Munkaltatas";
                    }
                case "Pénztárosok":
                    {
                        return "SKFB-ForrasUsers; SKFB-CafeteriaAdmin; SKFB-Gazd-Szamvitel; SKFB-Abevjava; SKFB-FN-penzugy; SKFB-FN-ertekkezelo; SKFB-FN-befog-elsolet; SKFB-FTPIlletmeny; SKFB-FN-konyvelo; SKFB-FN-karteriteskezelo; SKFB-FN-penzugyparamkez; SKFB-NexonHRpersONLINE; SKFB-KIRAcopy; SKFB-ForrasDotNet; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-Abevupdate; SKFB-Letszamjelentes-biztpub; SKFB-FTPSzamfejtes";
                    }
                case "Számviteli csoport":
                    {
                        return "SKFB-Abevjava; SKFB-Abevupdate; SKFB-FN-karbejelento; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-ForrasDotNet; SKFB-ForrasUsers; SKFB-FTPIlletmeny; SKFB-FTPSzamfejtes; SKFB-FTPSzamfejtes; SKFB-FTPUsers; SKFB-Gazd-Szamvitel; SKFB-Intranet; SKFB-KVKUsers; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-NX-IFEM; SKFB-OptenOptijus; SKFB-Pictures; SKFB-Szolgjegy-gazdpub-olvas";
                    }
                case "Élelmezési csoport":
                    {
                        return "SKFB-Elelmezes; SKFB-FN-ELELEM-elelmezv; SKFB-FN-ELELEM-konyhav; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogugykez; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-SKFB-EGYEDI3; SKFB-FN-SKFB-EGYEDI6; SKFB-ForrasDotNet; SKFB-ForrasUsers; SKFB-Gazd-Elelmezes; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-NX-ISZM";
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // Gazdasági társaság csoportjainak jogosultságai
        private static string GetGazdtarsPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Biztonsági vezető":
                    {
                        return "SKFB-Adatszolgaltatasok; SKFB-BIT-JELENTES; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-befbiz; SKFB-FN-biom-adatmegtek; SKFB-FN-bizt; SKFB-FN-bizt-ov; SKFB-FN-bunnyilv; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-ejfeli-adatszolgaltatas; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-megtekinto; SKFB-FN-nevelok; SKFB-FN-SKFB-EGYEDI3; SKFB-FN-SKFB-EGYEDI4; SKFB-FN-TELEFON-ugyintezo; SKFB-FTPUsers; SKFB-Gt-Biztvez; SKFB-KiemeltFogvatartottR; SKFB-MarathonTerra3; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-ISZM; SKFB-OptenOptijus; SKFB-Ter; SKFB-VezetoiSzignalas; SKFB-Vezetok; SKFB-Vir; SKFB-VIR-Munkaltatas-User";
                    }
                case "Munkaügyi csoport":
                    {
                        return "SKFB-Adatszolgaltatasok; SKFB-FN-befbiz; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-param-szerk; ; SKFB-FN-SKFB-EGYEDI3; SKFB-FN-SKFB-EGYEDI4; SKFB-FN-SKFB-EGYEDI6; SKFB-Gt-Munkaugy; SKFB-Kozfoglalkprog; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-NX-ISZM; SKFB-NX-SZAB; SKFB-Vezetoi-elfoglaltsag";
                    }
                case "Titkárság":
                    {
                        return "SKFB-Adatszolgaltatasok; SKFB-Gt-Titkarsag; SKFB-VezetoiJelenletGT";
                    }
                case "Igazgatóság":
                    {
                        return "SKFB-Adatszolgaltatasok; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-BVSHOP-ALLOMANYIBOLT; SKFB-FN-BVSHOP-KIETKEZOBOLT; SKFB-FN-cikktorzskezelo-megtekinto; SKFB-FN-csomagkezelo-megtekinto; SKFB-FN-csomagkezelo-szerkeszto; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-param-szerk; SKFB-FN-KESZLETNYILVANTARTO-MEGTEKINTO; SKFB-FN-KESZLETNYILVANTARTO-SZERKESZTO; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FTPUsers; SKFB-Gt-Titkarsag; SKFB-NexonHRpersONLINE; SKFB-Ter; SKFB-Tulora; SKFB-Vezetoi-elfoglaltsag; SKFB-VezetoiJelenletGT; SKFB-VezetoiSzignalas; SKFB-Vezetok; SKFB-Vir; SKFB-VIR-Munkaltatas-User";
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // Informatikai osztály csoportjainak jogosultságai
        private static string GetInfoPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Hír-biztonságtechnika":
                    {
                        return "SKFB-Bizt-Bizttech; SKFB-NexonHRpersONLINE; SKFB-Info-Biztonsagtechnika; SKFB-FN-fogl-munkahelyvezeto; SKFB-Bizttechfejlesztes; SKFB-FN-Navigator-munkahelyiszolgalatinaplo";
                    }
                case "Informatikai előadók":
                    {
                        return "SKFB-Adatszolgaltatasok; SKFB-Bizttechfejlesztes; SKFB-EDR-megtekinto; SKFB-EDR-rogzito; SKFB-FN3-Mentor; SKFB-FN-admin; SKFB-FN-biom-adatmegtek; SKFB-FN-fenykepezo; SKFB-FN-hivasnaplo-megtekinto; SKFB-FN-kartyakeszito; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-megtekinto; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-Safe-admin; SKFB-FN-TELEFON-megtekinto; SKFB-FN-TELEFON-ugyintezo; SKFB-ForrasDotNet; SKFB-ForrasUsers; SKFB-FTPUsers; SKFB-Info-Informatika; SKFB-IrfanView; SKFB-ISZR; SKFB-JKR; SKFB-Letszamjelentes-biztpub; SKFB-Napijelentes; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-NX-ISZM; SKFB-NX-SZAB; SKFB-NYDR; SKFB-NYDR-Inf; SKFB-OptenOptijus; SKFB-Pictures; SKFB-Reintegracio";
                    }
                case "Informatikai osztályvezető":
                    {
                        return "SKFB-Adatszolgaltatasok; SKFB-BIT-JELENTES; SKFB-Bizttechfejlesztes; SKFB-EDR-megtekinto; SKFB-EDR-rogzito; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-eSzigno; SKFB-Firefox; SKFB-FN3-Mentor; SKFB-FN-admin; SKFB-FN-biom-adatmegtek; SKFB-FN-csomagkezelo-atado; SKFB-FN-csomagkezelo-atado-szerk; SKFB-FN-csomagoszto; SKFB-FN-ELELEM-rendsz; SKFB-FN-fenykepezo; SKFB-FN-hivasnaplo-megtekinto; SKFB-FN-Idorend-megtekinto; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-kart-ugyintezo; SKFB-FN-kartyakeszito; SKFB-FN-konyvelo; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo; SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo-jovahagyo; SKFB-FN-Navigator-megtekinto; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-FN-TELEFON-megtekinto; SKFB-FN-TELEFON-ugyintezo; SKFB-ForrasDotNet; SKFB-FTPIlletmeny; SKFB-FTPSzamfejtes; SKFB-FTPUsers; SKFB-FTPVedelem; SKFB-GAZD; SKFB-IKKB; SKFB-Info-Informatika; SKFB-Info-Infovez; SKFB-IrfanView; SKFB-Letszamjelentes-biztpub; SKFB-MarathonTerra3; SKFB-MobilKapcsolat; SKFB-Napijelentes; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-NYDR; SKFB-NYDR-Inf; SKFB-OptenOptijus; SKFB-Pictures; SKFB-Reintegracio; SKFB-RobotZsaruNEO; SKFB-RobotZsaruNOVA; SKFB-VezetoiSzignalas; SKFB-Vezetok";
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // Személyügy csoportjainak jogosultságai
        private static string GetSzemPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Személyügyi előadók":
                    {
                        return "SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-FTPIlletmeny; SKFB-Futar; SKFB-Napijelentes; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-IHRM; SKFB-NX-IHRV; SKFB-NX-ISZM; SKFB-Szem-Szemelyugy; SKFB-FN3-Mobil; SKFB-Szenyor; SKFB-Ugyfelkapu; SKFB-IrfanView; SKFB-Toborzas; SKFB-IKKB";
                    }
                case "Személyügyi és szervezési osztályvezető":
                    {
                        return "SKFB-Adatszolgaltatasok; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN3-Mobil; SKFB-FN-karbejelento; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-megtekinto; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-FTPUsers; SKFB-IKKB; SKFB-IrfanView; SKFB-Kozfoglalkprog; SKFB-Letszamjelentes-biztpub; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-IHRV; SKFB-NX-IITA; SKFB-NX-ISZM; SKFB-NX-SZAB; SKFB-NYDR; SKFB-NYDR-Human; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-Pictures; SKFB-Szem-Szemelyugy; SKFB-Szem-Szemvez; SKFB-Szenyor; SKFB-Ter; SKFB-Toborzas; SKFB-Ugyfelkapu; SKFB-VezetoiSzignalas; SKFB-Vezetok";
                    }
                case "Ügykezelők":
                    {
                        return "SKFB-eSzigno; SKFB-FTPUsers; SKFB-Futar; SKFB-Letszamjelentes-biztpub; SKFB-Napijelentes; SKFB-NexonHRpersONLINE; SKFB-RobotZsaruNEO; SKFB-Szem-Ugykezelo";
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // Ügyészség csoportjainak jogosultságai
        private static string GetUgyeszPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Katonai ügyészek":
                    {
                        return noPermissions;
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // NVSZ csoportjainak jogosultságai
        private static string GetNVSZPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Operatív csoport":
                    {
                        return noPermissions;
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // Vezetők csoportjainak jogosultságai
        private static string GetVezetokPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Parancsnok":
                    {
                        return "SKFB-Adatszolgaltatasok; SKFB-BIT-JELENTES; SKFB-FN-bizt-ov; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-FN-Fegyelmi-fofelugyelo; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-param-szerk; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-kart-ugyintezo; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-jovahagyo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-kffenaplo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo; SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo-jovahagyo; SKFB-FN-Navigator-megtekinto; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-FN-parancsnok; SKFB-IKKB; SKFB-IrfanView; SKFB-Kozossegi-oldalak-infopub-olvas; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-IBVV; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-Parancsnok; SKFB-Ter; SKFB-Tulora; SKFB-Vezetoi-elfoglaltsag; SKFB-VezetoiJelenlet; SKFB-VezetoiSzignalas; SKFB-VEZKOZV; SKFB-Vir; SKFB-VIR-Munkaltatas-User";
                    }
                case "Parancsnok helyettes":
                    {
                        return "SKFB-Adatszolgaltatasok; SKFB-Bfb; SKFB-BIT-JELENTES; SKFB-Bizt-Biztov; SKFB-Bizttechfejlesztes; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FlashEnabled; SKFB-FN-befbiz; SKFB-FN-biom-adatmegtek; SKFB-FN-bizt; SKFB-FN-bizt-ov; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-FN-Fegyelmi-fofelugyelo; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-FN-int-vedett; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-karbejelento; SKFB-FN-kart-adatszolgaltato; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-kart-ugyintezo; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-jovahagyo; SKFB-FN-Navigator-ejfeli-adatszolgaltatas; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-kffenaplo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo; SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo-jovahagyo; SKFB-FN-Navigator-megtekinto; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-FTPVedelem; SKFB-IKKB; SKFB-IrfanView; SKFB-KiemeltFogvatartottR; SKFB-Kozossegi-oldalak-infopub-olvas; SKFB-Letszamjelentes-biztpub; SKFB-MarathonTerra3; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-ISZA; SKFB-NX-ISZM; SKFB-NX-SZAB; SKFB-OptenOptijusPlussz; SKFB-Parancsnokhelyettes; SKFB-Ter; SKFB-Tulora; SKFB-Vezetoi-elfoglaltsag; SKFB-VezetoiJelenlet; SKFB-VezetoiSzignalas; SKFB-Vezetok; SKFB-VEZKOZV";
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // Vezetői közvetlen csoportjainak jogosultságai
        private static string GetVezkozvPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Belső ellenőrők":
                    {
                        return "SKFB-Abevjava; SKFB-Adatszolgaltatasok; SKFB-Asz; SKFB-BelsoellenorTudastar; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-param-szerk; SKFB-ForrasDotNet; SKFB-ForrasUsers; SKFB-FTPUsers; SKFB-IKKB; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-ISZM; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-VezetoiSzignalas; SKFB-Vezkozv-Belsoellenor; SKFB-Vir";
                    }
                case "Előadók":
                    {
                        return "SKFB-FN-fegyugykez; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-karbejelento; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-megtekinto; SKFB-FTPUsers; SKFB-IrfanView; SKFB-Letszamjelentes-biztpub; SKFB-Napijelentes; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-IFEM; SKFB-NX-ISZM; SKFB-NX-SZAB; SKFB-OptenOptijus; SKFB-Parancsnok; SKFB-Scan-Pk; SKFB-Szenyor; SKFB-Vezetoi-elfoglaltsag; SKFB-VezetoiJelenlet; SKFB-Vezkozv-Eloado";
                    }
                case "Nyomozó és fegyelmi tiszt":
                    {
                        return "SKFB_NapijelentesekEnabled; SKFB-BIT-JELENTES; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-biom-adatmegtek; SKFB-FN-fegyugykez; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-osztalyvezeto; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FTPUsers; SKFB-IKKB; SKFB-IrfanView; SKFB-Kommunikacios; SKFB-Napijelentes; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NX-IFEM; SKFB-OptenOptijus; SKFB-Pictures; SKFB-SajtoRZS; SKFB-Szenyor; SKFB-Vezetok; SKFB-Vezkozv-Eloado; SKFB-Vezkozv-Fegyelmi";
                    }
                case "Jogtanácsosok":
                    {
                        return "SKFB-Abevjava; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-bunnyilv; SKFB-FN-nevelok; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-VezetoiSzignalas; SKFB-Vezkozv-Jogtanacsos";
                    }
                case "Kártalantási előadók":
                    {
                        return "SKFB-Abevjava; SKFB-FN-bunnyilv; SKFB-FN-fogugykez; SKFB-FN-kart-adatszolgaltato; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-kart-ugyintezo; SKFB-FN-nevelok; SKFB-FN-SKFB-EGYEDI2; SKFB-Vezkozv-Kartalanitas";
                    }
                case "Lelkészek":
                    {
                        return "SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-nevelok; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-Vezkozv-Lelkesz";
                    }
                case "Munkavédelmi vezető":
                    {
                        return "SKFB-Adatszolgaltatasok; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-megtekinto; SKFB-FN-SKFB-EGYEDI4; SKFB-FTPUsers; SKFB-IKKB; SKFB-NexonHRpersONLINE; SKFB-OptenOptijus; SKFB-VezetoiSzignalas; SKFB-Vezkozv-Munkavedelem";
                    }
                case "Pszichológusok":
                    {
                        return "SKFB-Animula; SKFB-Bfb; SKFB-Bortonadaptacio; SKFB-FN-befbiz; SKFB-FN-bunnyilv; SKFB-FN-EU-AltPszichologiaFogv-Orvos; SKFB-FN-EU-Psychoterapi-Orvos; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-FN-EU-PszichologiaBefogadoFogv-Orvos; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-nevelok; SKFB-FN-PME-egeszsegugy-megt; SKFB-FN-PME-nyilvantartas-megt; SKFB-FN-PME-pszichologia; SKFB-FN-PME-pszichologia-megt; SKFB-FN-PME-reintegracio-megt; SKFB-FN-PME-ugyintezo; SKFB-IrfanView; SKFB-Nexon; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-NX-ISZM; SKFB-NX-SZAB; SKFB-PszichoProgramok; SKFB-Scpi; SKFB-Temperamentum; SKFB-VezetoiSzignalas; SKFB-Vezkozv-Pszichologus";
                    }
                case "Titkárságvezető":
                    {
                        return "SKFB-Adatszolgaltatasok; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-bvbank-megtekinto; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-kart-ugyintezo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-nevelok; SKFB-FN-penzugy; SKFB-FN-TELEFON-megtekinto; SKFB-FTPUsers; SKFB-IrfanView; SKFB-KulsoEllenorzes; SKFB-OptenOptijusPlussz; SKFB-VezetoiSzignalas; SKFB-Vezetok; SKFB-Vezkozv-Titkarsagvezeto";
                    }
                case "Tűzvédelmi vezető":
                    {
                        return "SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FlashEnabled; SKFB-FN-fogugykez; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-IKKB; SKFB-NexonHRpersONLINE; SKFB-OptenOptijus; SKFB-VezetoiSzignalas; SKFB-Vezkozv-Tuzvedelem";
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // Kért osztály csoportjának a jogosultságát lekérdezi
        public static string GetPermissions(string specialityName, string groupName)
        {
            switch (specialityName)
            {
                case "Biztonsági osztály":
                    {
                        return SpecialityGroupsPermissions.GetBiztPermissions(groupName);
                    }
                case "Büntetés - végrehajtási osztály":
                    {
                        return SpecialityGroupsPermissions.GetBVPermissions(groupName);
                    }
                case "EFOP":
                    {
                        return SpecialityGroupsPermissions.GetEFOPPermissions(groupName);
                    }
                case "Egészségügyi osztály":
                    {
                        return SpecialityGroupsPermissions.GetEUPermissions(groupName);
                    }
                case "Gazdasági osztály":
                    {
                        return SpecialityGroupsPermissions.GetGazdosztPermissions(groupName);
                    }
                case "Gazdatási társaság":
                    {
                        return SpecialityGroupsPermissions.GetGazdtarsPermissions(groupName);
                    }
                case "Informatikai osztály":
                    {
                        return SpecialityGroupsPermissions.GetInfoPermissions(groupName);
                    }
                case "Nemzeti Védelmi Szolgálat":
                    {
                        return SpecialityGroupsPermissions.GetNVSZPermissions(groupName);
                    }
                case "Személyügyi és szociális osztály":
                    {
                        return SpecialityGroupsPermissions.GetSzemPermissions(groupName);
                    }
                case "Ügyészség":
                    {
                        return SpecialityGroupsPermissions.GetUgyeszPermissions(groupName);
                    }
                case "Vezetői közvetlen":
                    {
                        return SpecialityGroupsPermissions.GetVezkozvPermissions(groupName);
                    }
                case "Vezetőség":
                    {
                        return SpecialityGroupsPermissions.GetVezetokPermissions(groupName);
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }
    }
}