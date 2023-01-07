namespace SKFB_ISZR.Tools.Permissions
{
    // Csoportok alap jogosultságaik
    internal class GroupPermissions
    {
        // Ha az adott csoportnak nincs semmi egyedi jogosultsága
        private const string noPermissions = " ";

        // Biztonsági és fogvatartási ügyek osztály csoportjainak jogosultságai
        private static string GetBiztAndBVPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Osztályvezető":
                    {
                        return "SKFB-Bizt-Biztov; SKFB-Vezetok; SKFB-IrfanView; SKFB-A28G010555; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-bizt-ov; SKFB-Internet-Enabled; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-Gt-Biztvez; SKFB-PR30; SKFB-FN-int-vedett; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-FTPVedelem; SKFB-KiemeltFogvatartottR; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Vir; SKFB-VIR-Munkaltatas-User; SKFB-BIZTOV; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-BIT-JELENTES; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-MarathonTerra3; SKFB-NYDR-Bizt; SKFB-NYDR; SKFB-FN-Navigator-ejfeli-adatszolgaltatas; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-jovahagyo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-IKKB; SKFB-FN-Navigator-bitnaplo-osztalyvezeto; SKFB-IntranetAdatszolgaltatasKitolto; SKFB-BVORG-B; SKFB-BVORG-D; SKFB-BVORG-L; SKFB-Adatszolg-Kitolto-Biztonsag";
                    }
                case "Biztonsági alosztályvezető":
                    {
                        return "SKFB-Bizt-Biztov; SKFB-Vezetok; SKFB-IrfanView; SKFB-A28G010555; SKFB-PR25; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-bizt-ov; SKFB-Internet-Enabled; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-FN-int-vedett; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-FTPVedelem; SKFB-KiemeltFogvatartottR; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Vir; SKFB-VIR-Munkaltatas-User; SKFB-BIZTOV; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-BIT-JELENTES; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-MarathonTerra3; SKFB-NYDR; SKFB-FN-Navigator-ejfeli-adatszolgaltatas; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-jovahagyo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-IKKB; SKFB-FN-Navigator-bitnaplo-osztalyvezeto; SKFB-IntranetAdatszolgaltatasKitolto; SKFB-BVORG-B; SKFB-BVORG-D; SKFB-BVORG-L; SKFB-Adatszolg-Kitolto-Biztonsag";
                    }
                case "Biztonsági tiszt":
                    {
                        return "SKFB-Bizt-Bit-Iszak; SKFB-Bizt-Bit-IIszak; SKFB-Bizt-Bit-IIIszak; SKFB-Bizt-Bit-IVszak; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-nevelok; SKFB-FN-bunnyilv; SKFB-Internet-Enabled; SKFB-FlashEnabled; SKFB-OptenOptijus; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-KiemeltFogvatartottR; SKFB-Bizt-Bit; SKFB-BIT; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-FN-TELEFON-ugyintezo; SKFB-PR126; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-PR03; SKFB-MarathonTerra3; SKFB-JKR-Dashboard; SKFB-FN-Navigator-ejfeli-adatszolgaltatas; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-IntranetAdatszolgaltatasKitolto; SKFB-BVORG-B; SKFB-BVORG-D; SKFB-Adatszolg-Kitolto-Biztonsag";
                    }
                case "Biztonsági főfelügyelő":
                    {
                        return "SKFB-Bizt-Bit-Iszak; SKFB-Bizt-Bit-IIszak; SKFB-Bizt-Bit-IIIszak; SKFB-Bizt-Bit-IVszak; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-nevelok; SKFB-FN-bunnyilv; SKFB-Internet-Enabled; SKFB-OptenOptijus; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-KiemeltFogvatartottR; SKFB-Bizt-Bit; SKFB-BIT; SKFB-PR126; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-PR03; SKFB-MarathonTerra3; SKFB-JKR-Dashboard; SKFB-FN-Navigator-ejfeli-adatszolgaltatas; SKFB-FN-Navigator-bitnaplo; SKFB-IntranetAdatszolgaltatasKitolto; SKFB-Adatszolg-Kitolto-Biztonsag";
                    }
                case "Biztonsági felügyelő":
                    {
                        return "SKFB-Bizt-Bfe; SKFB-Internet-Limited; SKFB-FN-Navigator-belepesinaplo";
                    }
                case "Fegyveres biztonsági őr":
                    {
                        return "SKFB-Internet-Limited";
                    }
                case "Kutyatelep-vezető":
                    {
                        return "SKFB-Bizt-Kutyavezeto; SKFB-Internet-Enabled; SKFB-NexonHRpersONLINE; SKFB-FN-Navigator-belepesinaplo; SKFB-PR63; SKFB-PR03";
                    }
                case "Kutyavezető":
                    {
                        return "SKFB-Bizt-Kutyavezeto; SKFB-Internet-Limited; SKFB-FN-Navigator-belepesinaplo; SKFB-PR63";
                    }
                case "Fegyvermester":
                    {
                        return "SKFB-Bizt-Bfe; SKFB-Internet-Enabled; SKFB-NexonHRpersONLINE; SKFB-FN-Navigator-belepesinaplo";
                    }
                case "Biztonsági segédelőadó":
                    {
                        return "SKFB-ForrasUsers; SKFB-Bizt-Biztov; SKFB-A28G010555; SKFB-PR25; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-csomagoszto; SKFB-FN-korl-fofelugy; SKFB-FN-targyraktaros; SKFB-Internet-Enabled; SKFB-FN-fogugykez; SKFB-FN-befog-elsolet; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-VezetoiSzignalas; SKFB-FN-PME-ugyintezo; SKFB-FN-fogl-munkahelyvezeto; SKFB-ForrasDotNet; SKFB-FN-csomagkezelo-atado-szerk; SKFB-FN-csomagkezelo-atado; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Fegyelmi-fofelugyelo; SKFB-FN-Navigator-ejfeli-adatszolgaltatas; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-korletfofelugyelo; SKFB-ISZR; SKFB-BVORG-B; SKFB-BVORG-D; SKFB-BVORG-L; SKFB-Adatszolg-Kitolto-Biztonsag; SKFB-SzolgalatSzervezes";
                    }
                case "Biztonsági előadó":
                    {
                        return "SKFB-Bizt-Biztov; SKFB-A28G010555; SKFB-PR25; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-VezetoiSzignalas; SKFB-PR121; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-bitnaplo; SKFB-ISZR; SKFB-BVORG-B; SKFB-BVORG-D; SKFB-SzolgalatSzervezes";
                    }
                case "Körlet felügyelő":
                    {
                        return "SKFB-Bv-Kfe; SKFB-Internet-Limited; SKFB-BV; SKFB-PR39; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-Fegyelmi-egyeb-szakterulet";
                    }
                case "Körlet főfelügyelő":
                    {
                        return "SKFB-Bv-Kffe-Iszak; SKFB-Bv-Kffe-IIszak; SKFB-Bv-Kffe-IIIszak; SKFB-Bv-Kffe-IVszak; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-korl-fofelugy; SKFB-Internet-Enabled; SKFB-NexonHRpersONLINE; SKFB-BV; SKFB-NoemiHelpDesk; SKFB-VezetoiSzignalas; SKFB-Bv-Kffe; SKFB-PR39; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-Fegyelmi-fofelugyelo; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-korletfofelugyelo; SKFB-FN-Navigator-kffenaplo";
                    }
                case "Műveleti főfelügyelő":
                    {
                        return "SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-FN-fogugykez; SKFB-NX-SZAB; SKFB-Bizt-MuveletiCsoport; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-PR105; SKFB-PR03";
                    }
                case "Fogvatartási alosztályvezető":
                    {
                        return "SKFB-Bv-Reintegracio; SKFB-Vezetok; SKFB-IrfanView; SKFB-Bv-Bvov; SKFB-NX-ISZM; SKFB-NX-ISZA; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-OptenOptijusPlussz; SKFB-FN-int-vedett; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-FTPVedelem; SKFB-KiemeltFogvatartottR; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Vir; SKFB-VIR-Munkaltatas-User; SKFB-Bfb; SKFB-FN-PME-ugyintezo; SKFB-FN-PME-reintegracio; SKFB-FN-kart-adatszolgaltato; SKFB-FN-kart-ugyintezo; SKFB-PR61; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-csomagkezelo-atado-szerk; SKFB-FN-csomagkezelo-atado; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-eSzigno; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-BIT-JELENTES; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-MarathonTerra3; SKFB-NYDR; SKFB-NYDR-Reint; SKFB-FN-Navigator-bitnaplo-korletfofelugyelo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-IKKB; SKFB-PR148; SKFB-FN-Navigator-bitnaplo-osztalyvezeto; SKFB-BVORG-KSZNYFO; SKFB-BVORG-F; SKFB-BVORG-G; SKFB-BVORG-M";
                    }
                case "Fogvatartási alosztályvezető-helyettes":
                    {
                        return "SKFB-Bv-Reintegracio; SKFB-Vezetok; SKFB-IrfanView; SKFB-Bv-Bvov; SKFB-NX-ISZM; SKFB-NX-ISZA; SKFB-Nexon; SKFB-FN-csomagoszto; SKFB-FN-nevelok; SKFB-FN-bunnyilv; SKFB-FlashEnabled; SKFB-OptenOptijus; SKFB-OptenOptijusPlussz; SKFB-FN-int-vedett; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-FTPVedelem; SKFB-HER-Behallgatok; SKFB-FN-hivasnaplo-megtekinto; SKFB-KiemeltFogvatartottR; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Bfb; SKFB-FN-PME-ugyintezo; SKFB-FN-PME-reintegracio; SKFB-FN-kart-adatszolgaltato; SKFB-FN-kart-ugyintezo; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-bvbank-megtekinto; SKFB-FN-TELEFON-ugyintezo; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-csomagkezelo-atado-szerk; SKFB-FN-csomagkezelo-atado; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-eSzigno; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-BIT-JELENTES; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-MarathonTerra3; SKFB-NYDR; SKFB-NYDR-Reint; SKFB-FN-Navigator-bitnaplo-korletfofelugyelo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-IKKB; SKFB-FN-Navigator-bitnaplo-osztalyvezeto; SKFB-BVORG-F; SKFB-BVORG-G; SKFB-BVORG-M";
                    }
                case "Nyilvántartó főelőadó":
                    {
                        return "SKFB-Bv-Nyilvantarto; SKFB-Vezetok; SKFB-IrfanView; SKFB-Abevjava; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-bunnyilv; SKFB-FN-bunnyilv-ov; SKFB-Internet-Enabled; SKFB-FN-fogugykez; SKFB-OptenOptijusPlussz; SKFB-Pictures; SKFB-FTPUsers; SKFB-Optiproba; SKFB-NexonHRpersONLINE; SKFB-KiemeltFogvatartottR; SKFB-NoemiHelpDesk; SKFB-VezetoiSzignalas; SKFB-Vir; SKFB-VIR-Munkaltatas-User; SKFB-Bfb; SKFB-FN-PME-ugyintezo; SKFB-FN-PME-nyilvantartas; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-PME-nyilvantartas-megt; SKFB-FN-kart-adatszolgaltato; SKFB-FN-kart-ugyintezo; SKFB-SzabStat; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-eSzigno; SKFB-Tavtargyalas adatszolgaltato; SKFB-FN-Navigator-eloallitasnaplo; SKFB-PR154; SKFB-BVORG-G; SKFB-BVORG-R";
                    }
                case "Nyilvántartó előadó":
                    {
                        return "SKFB-Bv-Nyilvantarto; SKFB-Abevjava; SKFB-Nexon; SKFB-FN-bunnyilv; SKFB-FN-bunnyilv-ov; SKFB-Internet-Enabled; SKFB-FN-fogugykez; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-Bfb; SKFB-FN-PME-ugyintezo; SKFB-FN-PME-nyilvantartas; SKFB-FN-PME-nyilvantartas-megt; SKFB-FN-kart-ugyintezo; SKFB-SzabStat; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-PR43; SKFB-eSzigno; SKFB-Tavtargyalas adatszolgaltato; SKFB-FN-Fegyelmi-jogkor-gyakorloja";
                    }
                case "Nyilvántartó segédelőadó":
                    {
                        return "SKFB-Bv-Nyilvantarto; SKFB-Abevjava; SKFB-Nexon; SKFB-FN-bunnyilv; SKFB-FN-bunnyilv-ov; SKFB-Internet-Enabled; SKFB-FN-fogugykez; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-Bfb; SKFB-FN-PME-ugyintezo; SKFB-FN-PME-nyilvantartas; SKFB-FN-PME-nyilvantartas-megt; SKFB-FN-kart-ugyintezo; SKFB-SzabStat; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-PR43; SKFB-eSzigno; SKFB-Tavtargyalas adatszolgaltato; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-BVORG-G; SKFB-BVORG-R";
                    }
                case "Körlet ellátó főfelügyelő":
                    {
                        return "SKFB-ForrasUsers; SKFB-FN-csomagoszto; SKFB-FN-korl-fofelugy; SKFB-FN-targyraktaros; SKFB-Internet-Enabled; SKFB-FN-fogugykez; SKFB-FN-befog-elsolet; SKFB-NexonHRpersONLINE; SKFB-Bv-Anyagi; SKFB-PR07; SKFB-Bv-Kffe; SKFB-FN-PME-ugyintezo; SKFB-FN-fogl-munkahelyvezeto; SKFB-ForrasDotNet; SKFB-FN-csomagkezelo-atado-szerk; SKFB-FN-csomagkezelo-atado; SKFB-FN-Fegyelmi-fofelugyelo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo";
                    }
                case "Körlet ellátó segédelőadó":
                    {
                        return "SKFB-ForrasUsers; SKFB-Nexon; SKFB-FN-csomagoszto; SKFB-FN-korl-fofelugy; SKFB-FN-targyraktaros; SKFB-Internet-Enabled; SKFB-FN-fogugykez; SKFB-FN-befog-elsolet; SKFB-NexonHRpersONLINE; SKFB-Bv-Anyagi; SKFB-PR07; SKFB-FN-PME-ugyintezo; SKFB-FN-fogl-munkahelyvezeto; SKFB-ForrasDotNet; SKFB-FN-csomagkezelo-atado-szerk; SKFB-FN-csomagkezelo-atado; SKFB-FN-Fegyelmi-fofelugyelo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo";
                    }
                case "Vezető reintegrációs tiszt":
                    {
                        return "SKFB-Bv-Reintegracio; SKFB-FN-csomagoszto; SKFB-FN-nevelok; SKFB-FN-bunnyilv; SKFB-Internet-Enabled; SKFB-FlashEnabled; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-HER-Behallgatok; SKFB-FN-hivasnaplo-megtekinto; SKFB-Vir; SKFB-Bfb; SKFB-FN-PME-ugyintezo; SKFB-FN-PME-reintegracio; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-bvbank-megtekinto; SKFB-FN-TELEFON-ugyintezo; SKFB-FN-csomagkezelo-atado; SKFB-eSzigno; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-BVORG-G";
                    }
                case "Reintegraciós tiszt":
                    {
                        return "SKFB-Bv-Reintegracio; SKFB-FN-csomagoszto; SKFB-FN-nevelok; SKFB-FN-bunnyilv; SKFB-Internet-Enabled; SKFB-FlashEnabled; SKFB-FTPUsers; SKFB-HER-Behallgatok; SKFB-FN-hivasnaplo-megtekinto; SKFB-Bfb; SKFB-FN-PME-ugyintezo; SKFB-FN-PME-reintegracio; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-bvbank-megtekinto; SKFB-FN-TELEFON-ugyintezo; SKFB-FN-csomagkezelo-atado; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-FN-Fegyelmi-reintegracios-tiszt";
                    }
                case "Szociális segédelőadó":
                    {
                        return "SKFB-Bv-Szoceloado; SKFB-Abevjava; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-nevelok; SKFB-FN-bunnyilv; SKFB-FN-korl-fofelugy; SKFB-Internet-Enabled; SKFB-FN-fogugykez; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-FN-PME-ugyintezo; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-bvbank-megtekinto; SKFB-Letszamjelentes-biztpub; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-PR148; SKFB-ISZR; SKFB-BVORG-F; SKFB-BVORG-G";
                    }
                case "Pártfogó felügyelő":
                    {
                        return "SKFB-MapRoamApp; SKFB-Abevjava; SKFB-FN-nevelok; SKFB-FN-bunnyilv; SKFB-Internet-Enabled; SKFB-Scan-Pf; SKFB-VezetoiSzignalas; SKFB-PARTFOGO; SKFB-FN-PTTR-Ugyintezo; SKFB-PR96; SKFB-eSzigno; SKFB-PR148";
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
                        return "SKFB-Bv-Reintegracio; SKFB-IrfanView; SKFB-NX-ISZM; SKFB-NX-ISZA; SKFB-Nexon; SKFB-FN-csomagoszto; SKFB-FN-nevelok; SKFB-FN-bunnyilv; SKFB-FN-korl-fofelugy; SKFB-FN-fogugykez-ov; SKFB-Internet-Enabled; SKFB-FlashEnabled; SKFB-OptenOptijus; SKFB-OptenOptijusPlussz; SKFB-Pictures; SKFB-FN-int-vedett; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-FTPVedelem; SKFB-HER-Behallgatok; SKFB-FN-hivasnaplo-megtekinto; SKFB-KiemeltFogvatartottR; SKFB-NoemiHelpDesk; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Bfb; SKFB-FN-PME-ugyintezo; SKFB-FN-PME-reintegracio; SKFB-FN-PME-bizottsag; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-kart-adatszolgaltato; SKFB-FN-kart-ugyintezo; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-bvbank-megtekinto; SKFB-FN-TELEFON-megtekinto; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-csomagkezelo-atado-szerk; SKFB-FN-csomagkezelo-atado; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-eSzigno; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-BIT-JELENTES; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-PR138; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-MarathonTerra3; SKFB-PR76; SKFB-NYDR; SKFB-NYDR-Reint; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-jovahagyo; SKFB-FN-Navigator-bitnaplo-korletfofelugyelo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-IKKB; SKFB-PR148; SKFB-FN-Navigator-bitnaplo-osztalyvezeto; SKFB-BVORG-C; SKFB-BVORG-G";
                    }
                case "Pályázati tanácsadó":
                    {
                        return "SKFB-FN-nevelok; SKFB-FN-bunnyilv; SKFB-Internet-Enabled; SKFB-Pictures; SKFB-FTPUsers; BVOP-Cafeteria; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-kult-reint-tiszt; SKFB-TAMOP; SKFB-PR138; SKFB-PR76; SKFB-PR148; SKFB-BVORG-C";
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
                case "Osztályvezető":
                    {
                        return "SKFB-ForrasUsers; SKFB-Vezetok; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-FlashEnabled; SKFB-OptenOptijusPlussz; SKFB-Pictures; SKFB-NX-SZAB; SKFB-FN-EU-Sebeszet-Orvos; SKFB-FN-EU-Befogado-Orvos; SKFB-FN-EU-FoglalkozasEuFogv-Orvos; SKFB-FN-EU-AltOrvosiEllatasAll-Orvos; SKFB-FN-EU-FoglalkozasEuAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasFogv-Orvos; SKFB-NexonHRpersONLINE; SKFB-VisualIxdoki; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Eu-Egeszsegugyvez; SKFB-Bfb; SKFB-FN-PME-egeszsegugy; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-PME-pszichologia-megt; SKFB-FN-PME-egeszsegugy-megt; SKFB-ForrasDotNet; SKFB-ProDoki; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-FN-BvOrvos; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-BIT-JELENTES; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-NYDR-Eu; SKFB-NYDR; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-EU-FoglalkEUAll-Orvos; SKFB-FN-EU-AlapellatasAll-Orvos; SKFB-PR150; SKFB-PR157; SKFB-BVORG-E";
                    }
                case "Főápoló":
                    {
                        return "SKFB-Eu-Apolo; SKFB-ForrasUsers; SKFB-Vezetok; SKFB-GyogyszerNyilvantartas; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-FlashEnabled; SKFB-Pictures; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-FN-EU-Szemeszet-Orvos; SKFB-FN-EU-FogaszatAll-Orvos; SKFB-FN-EU-Sebeszet-Orvos; SKFB-FN-EU-Befogado-Orvos; SKFB-FN-EU-FoglalkozasEuFogv-Orvos; SKFB-FN-EU-FogaszatFogv-Orvos; SKFB-FN-EU-AltOrvosiEllatasAll-Orvos; SKFB-FN-EU-FoglalkozasEuAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasFogv-Orvos; SKFB-NexonHRpersONLINE; SKFB-VisualIxdoki; SKFB-NoemiHelpDesk; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-FN-EU-FogaszatBefogado-Orvos; SKFB-Bfb; SKFB-FN-PME-egeszsegugy; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-PME-pszichologia-megt; SKFB-FN-PME-egeszsegugy-megt; SKFB-FN-kart-ugyintezo; SKFB-ForrasDotNet; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-ProDoki; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-NYDR-Eu; SKFB-NYDR; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-IKKB; SKFB-FN-EU-FoglalkEUAll-Orvos; SKFB-FN-EU-AlapellatasAll-Orvos; SKFB-PR150; SKFB-BVORG-E";
                    }
                case "Orvos":
                    {
                        return "SKFB-Internet-Enabled; SKFB-FN-EU-Sebeszet-Orvos; SKFB-FN-EU-Befogado-Orvos; SKFB-FN-EU-FoglalkozasEuFogv-Orvos; SKFB-FN-EU-AltOrvosiEllatasAll-Orvos; SKFB-FN-EU-FoglalkozasEuAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasFogv-Orvos; SKFB-FN-BvOrvos; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-FN-EU-FoglalkEUAll-Orvos; SKFB-FN-EU-AlapellatasAll-Orvos";
                    }
                case "Orvos asszisztens":
                    {
                        return "SKFB-Internet-Enabled; SKFB-FN-EU-FogaszatAll-Orvos; SKFB-FN-EU-FogaszatFogv-Orvos; SKFB-PR62; SKFB-FN-EU-FogaszatBefogado-Orvos; ";
                    }
                case "Szakápoló":
                    {
                        return "SKFB-Eu-Apolo; SKFB-GyogyszerNyilvantartas; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Limited; SKFB-Pictures; SKFB-FN-EU-Szemeszet-Orvos; SKFB-FN-EU-Sebeszet-Orvos; SKFB-FN-EU-Befogado-Orvos; SKFB-FN-EU-AltOrvosiEllatasAll-Orvos; SKFB-FN-EU-FoglalkozasEuAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasFogv-Orvos; SKFB-NexonHRpersONLINE; SKFB-ProDoki; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-Letszamjelentes-biztpub; ; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-EU-AlapellatasAll-Orvos; SKFB-PR150";
                    }
                case "Előadó":
                    {
                        return "SKFB-Eu-Apolo; SKFB-ForrasUsers; SKFB-GyogyszerNyilvantartas; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-Pictures; SKFB-NX-SZAB; SKFB-FN-EU-Szemeszet-Orvos; SKFB-FN-EU-Sebeszet-Orvos; SKFB-FN-EU-Befogado-Orvos; SKFB-FN-EU-FoglalkozasEuFogv-Orvos; SKFB-FN-EU-AltOrvosiEllatasAll-Orvos; SKFB-FN-EU-FoglalkozasEuAll-Orvos; SKFB-FN-EU-AltOrvosiEllatasFogv-Orvos; SKFB-NexonHRpersONLINE; SKFB-PR28; SKFB-VisualIxdoki; SKFB-FN-PME-egeszsegugy; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-PME-pszichologia-megt; SKFB-FN-PME-egeszsegugy-megt; SKFB-ForrasDotNet; SKFB-ProDoki; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-FN-EU-FoglalkEUAll-Orvos; SKFB-FN-EU-AlapellatasAll-Orvos; SKFB-PR150; SKFB-PR157";
                    }
                case "Szakpszichológus":
                    {
                        return "SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-nevelok; SKFB-FN-bunnyilv; SKFB-Internet-Enabled; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-Vezkozv-Pszichologus; SKFB-Scpi; SKFB-Temperamentum; SKFB-Bortonadaptacio; SKFB-FN-EU-Psychoterapi-Orvos; SKFB-NexonHRpersONLINE; SKFB-RobotZsaruNOVA; SKFB-FN-EU-AltPszichologiaFogv-Orvos; SKFB-FN-EU-PszichologiaBefogadoFogv-Orvos; SKFB-Bfb; SKFB-FN-PME-pszichologia; SKFB-FN-PME-ugyintezo; SKFB-FN-PME-nyilvantartas; SKFB-FN-PME-reintegracio; SKFB-FN-PME-egeszsegugy; SKFB-FN-PME-bizottsag; SKFB-FN-PME-pszichologia-megt; SKFB-FN-PME-egeszsegugy-megt; SKFB-FN-PME-reintegracio-megt; SKFB-FN-PME-nyilvantartas-megt; SKFB-PR08; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-NYDR-Pszich; SKFB-NYDR; SKFB-IKKB; SKFB-PszichoProgramok; SKFB-FN-EU-PszihologiaAll-Orvos; SKFB-FN-EU-PszihologiaFogv-Orvos; SKFB-BVORG-E";
                    }
                case "Pszichológus":
                    {
                        return "SKFB-FN-nevelok; SKFB-FN-bunnyilv; SKFB-Internet-Enabled; SKFB-FTPUsers; SKFB-Vezkozv-Pszichologus; SKFB-Scpi; SKFB-Temperamentum; SKFB-Bortonadaptacio; SKFB-FN-EU-Psychoterapi-Orvos; SKFB-NexonHRpersONLINE; SKFB-PR46; SKFB-VezetoiSzignalas; SKFB-FN-EU-AltPszichologiaFogv-Orvos; SKFB-FN-EU-PszichologiaBefogadoFogv-Orvos; SKFB-Bfb; SKFB-FN-PME-pszichologia; SKFB-FN-PME-ugyintezo; SKFB-FN-PME-nyilvantartas; SKFB-FN-PME-reintegracio; SKFB-FN-PME-egeszsegugy; SKFB-FN-PME-bizottsag; SKFB-FN-PME-pszichologia-megt; SKFB-FN-PME-egeszsegugy-megt; SKFB-FN-PME-reintegracio-megt; SKFB-FN-PME-nyilvantartas-megt; SKFB-FN-EU-PszichiatriaFogv-Orvos; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-PszichoProgramok; SKFB-FN-EU-PszihologiaAll-Orvos; SKFB-FN-EU-PszihologiaFogv-Orvos";
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // Gazdasági Ellátó Intézet csoport jogosultságai
        private static string GetGEIPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Informatikus":
                    {
                        return "SKFB-ForrasUsers; SKFB-IrfanView; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-OptenOptijus; SKFB-Pictures; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-FN-admin; SKFB-FN-ELELEM-rendsz; SKFB-NexonHRpersONLINE; SKFB-FN-hivasnaplo-megtekinto; SKFB-Info-Informatika; SKFB-NoemiHelpDesk; SKFB-VezetoiSzignalas; SKFB-ForrasDotNet; SKFB-FN-TELEFON-megtekinto; SKFB-FN-TELEFON-ugyintezo; SKFB-Reintegracio; SKFB-Letszamjelentes-biztpub; SKFB-Bizttechfejlesztes; SKFB-FN-Safe-admin; SKFB-JKR; SKFB-EDR-rogzito; SKFB-EDR-megtekinto; SKFB-FN3-Mentor; SKFB-NYDR-Inf; SKFB-NYDR; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-ISZR; SKFB-BarniPro; SKFB-PR155; SKFB-Backups; SKFB-BVORG-K; SKFB-Adatszolg-Kitolto-Informatika";
                    }
                case "Biztonságtechnikus":
                    {
                        return "SKFB-Bizt-Bizttech; SKFB-Internet-Enabled; SKFB-NexonHRpersONLINE; SKFB-PR95; SKFB-Info-Biztonsagtechnika; SKFB-FN-fogl-munkahelyvezeto; SKFB-Bizttechfejlesztes; SKFB-FN-Navigator-munkahelyiszolgalatinaplo";
                    }
                case "Felszer":
                    {
                        return "SKFB-GEI-FELSZER; SKFB-ForrasUsers; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-csomagoszto; SKFB-FN-penzugy; SKFB-FN-targyraktaros; SKFB-Internet-Enabled; SKFB-FN-ertekkezelo; SKFB-FN-fogugykez; SKFB-FN-befog-elsolet; SKFB-FN-masodlet; SKFB-FN-okmanykezelo; SKFB-FTPUsers; SKFB-FTPIlletmeny; SKFB-NexonHRpersONLINE; SKFB-FN-talalttargy; SKFB-MobilKapcsolat; SKFB-NoemiHelpDesk; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-ForrasDotNet; SKFB-PR122; SKFB-FN-TELEFON-ugyintezo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-PR149; ";
                    }
                case "Kártérítés":
                    {
                        return "SKFB-GEI-KARTALANITAS; SKFB-ForrasUsers; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-csomagoszto; SKFB-FN-penzugy; SKFB-FN-targyraktaros; SKFB-Internet-Enabled; SKFB-FN-ertekkezelo; SKFB-FN-fogugykez; SKFB-FN-befog-elsolet; SKFB-FN-masodlet; SKFB-FN-okmanykezelo; SKFB-FTPUsers; SKFB-FTPIlletmeny; SKFB-NexonHRpersONLINE; SKFB-FN-talalttargy; SKFB-MobilKapcsolat; SKFB-NoemiHelpDesk; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-ForrasDotNet; SKFB-PR122; SKFB-FN-TELEFON-ugyintezo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-PR149; ";
                    }
                case "Letét":
                    {
                        return "SKFB-GEI-LETET; SKFB-ForrasUsers; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-csomagoszto; SKFB-FN-penzugy; SKFB-FN-targyraktaros; SKFB-Internet-Enabled; SKFB-FN-ertekkezelo; SKFB-FN-fogugykez; SKFB-FN-befog-elsolet; SKFB-FN-masodlet; SKFB-FN-okmanykezelo; SKFB-FTPUsers; SKFB-FTPIlletmeny; SKFB-NexonHRpersONLINE; SKFB-FN-talalttargy; SKFB-MobilKapcsolat; SKFB-NoemiHelpDesk; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-ForrasDotNet; SKFB-PR122; SKFB-FN-TELEFON-ugyintezo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-PR149; ";
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }

        // Műszaki ellátási osztály csoportjainak jogosultságai
        private static string GetMuszakiEllatasPermissions(string groupName)
        {
            switch (groupName)
            {
                case "Osztályvezető":
                    {
                        return "SKFB-ForrasUsers; SKFB-CafeteriaAdmin; SKFB-Gazd-Szamvitel; SKFB-Gazd-Gazdvez; SKFB-Vezetok; SKFB-IrfanView; SKFB-Abevjava; SKFB-GyogyszerNyilvantartas; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-FN-ELELEM-gazdvez; SKFB-Gazd-Muszaki; SKFB-OptenOptijusPlussz; SKFB-Pictures; SKFB-FN-gazdasagi-ov; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-FN-hivasnaplo-megtekinto; SKFB-VEZKOZV; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Vir; SKFB-VIR-Munkaltatas-User; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-ForrasDotNet; SKFB-FN-bvbank-megtekinto; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-PR29; SKFB-Tulora; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-Bizttechfejlesztes; SKFB-BIT-JELENTES; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-JKR; SKFB-JKR-Dashboard; SKFB-JKR-BMadmin; SKFB-NYDR-Gazd; SKFB-NYDR; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-IKKB; SKFB-Szallas; SKFB-BVORG-H; SKFB-BVORG-K; SKFB-BVORG-O; SKFB-BVORG-P; SKFB-BVORG-Q; SKFB-BVORG-R; SKFB-BVORG-S; SKFB-E-szamla";
                    }
                case "Gazdasági alosztályveztő":
                    {
                        return "SKFB-ForrasUsers; SKFB-CafeteriaAdmin; SKFB-Gazd-Szamvitel; SKFB-Gazd-Gazdvez; SKFB-Vezetok; SKFB-IrfanView; SKFB-Abevjava; SKFB-GyogyszerNyilvantartas; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-FN-ELELEM-gazdvez; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-FN-gazdasagi-ov; SKFB-FTPUsers; SKFB-FTPIlletmeny; SKFB-FN-penzugyparamkez; SKFB-NexonHRpersONLINE; SKFB-FN-hivasnaplo-megtekinto; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Vir; SKFB-VIR-Munkaltatas-User; SKFB-FN-fogl-munkahelyvezeto; SKFB-ForrasDotNet; SKFB-FN-bvbank-megtekinto; SKFB-Asz; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-PR16; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-KulsoEllenorzes; SKFB-BIT-JELENTES; SKFB-NYDR-Gazd; SKFB-NYDR; SKFB-IKKB; SKFB-BVORG-H; SKFB-BVORG-O; SKFB-BVORG-P; SKFB-BVORG-Q; SKFB-E-szamla";
                    }
                case "Fenntartási alosztályvezető":
                    {
                        return "SKFB-Gazd-Szamvitel; SKFB-Gazd-Gazdvez; SKFB-Vezetok; SKFB-IrfanView; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-FN-ELELEM-gazdvez; SKFB-Gazd-Muszaki; SKFB-OptenOptijusPlussz; SKFB-Pictures; SKFB-FN-gazdasagi-ov; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Vir; SKFB-VIR-Munkaltatas-User; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-kart-ugyintezo; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-bvbank-megtekinto; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-PR02; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-Bizttechfejlesztes; SKFB-BIT-JELENTES; SKFB-JKR; SKFB-JKR-Dashboard; SKFB-JKR-BMadmin; SKFB-NYDR-Gazd; SKFB-NYDR; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-IKKB; SKFB-Szallas; SKFB-BVORG-H; SKFB-BVORG-O; SKFB-BVORG-P; SKFB-BVORG-Q; SKFB-BVORG-S";
                    }
                case "Gépház műhelyvezető":
                    {
                        return "SKFB-ForrasUsers; SKFB-Gazd-Gephazvez; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-FN-fogugykez; SKFB-NexonHRpersONLINE; SKFB-FN-fogl-munkahelyvezeto; SKFB-ForrasDotNet; SKFB-Bizttechfejlesztes; SKFB-PR110; SKFB-FN-Navigator-munkahelyiszolgalatinaplo";
                    }
                case "Gépház foglalkoztatási segédelőadó":
                    {
                        return "SKFB-ForrasUsers; SKFB-Internet-Enabled; SKFB-NexonHRpersONLINE; SKFB-Gazd-Gephazraktar; SKFB-PR20; SKFB-ForrasDotNet; SKFB-FN-Navigator-munkahelyiszolgalatinaplo";
                    }
                case "Élelmezésvezető":
                    {
                        return "SKFB-ForrasUsers; SKFB-Gazd-Elelmezes; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-FN-fogugykez; SKFB-NexonHRpersONLINE; SKFB-FN-ELELEM-konyhav; SKFB-Elelmezes; SKFB-FN-ELELEM-elelmezv; SKFB-NoemiHelpDesk; SKFB-PR106; SKFB-FN-fogl-munkahelyvezeto; SKFB-ForrasDotNet";
                    }
                case "Élelmezési csoportvezető":
                    {
                        return "SKFB-ForrasUsers; SKFB-Gazd-Elelmezes; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-FN-fogugykez; SKFB-FTPUsers; SKFB-FN-ELELEM-rendsz; SKFB-NexonHRpersONLINE; SKFB-FN-ELELEM-konyhav; SKFB-Elelmezes; SKFB-FN-ELELEM-elelmezv; SKFB-NoemiHelpDesk; SKFB-VezetoiSzignalas; SKFB-PR106; SKFB-FN-fogl-munkahelyvezeto; SKFB-ForrasDotNet; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-BVORG-S";
                    }
                case "Élelmezési foglalkoztatási segédelőadó":
                    {
                        return "SKFB-Gazd-Elelmezes; SKFB-Internet-Enabled; SKFB-FN-ELELEM-konyhav; SKFB-Elelmezes; SKFB-FN-ELELEM-elelmezv; SKFB-NoemiHelpDesk; SKFB-PR106; SKFB-FN-fogl-munkahelyvezeto; SKFB-ISZR";
                    }
                case "Raktárvezető":
                    {
                        return "SKFB-ForrasUsers; SKFB-Gazd-Raktar; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-csomagoszto; SKFB-FN-penzugy; SKFB-FN-targyraktaros; SKFB-Internet-Enabled; SKFB-FN-ertekkezelo; SKFB-FN-fogugykez; SKFB-Pictures; SKFB-FN-befog-elsolet; SKFB-FN-masodlet; SKFB-FN-okmanykezelo; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-FN-talalttargy; SKFB-MobilKapcsolat; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-ForrasDotNet; SKFB-FN-TELEFON-ugyintezo; SKFB-PR74; SKFB-PR55; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-PR149";
                    }
                case "Raktáros foglalkoztatási segédelőadó":
                    {
                        return "SKFB-ForrasUsers; SKFB-Gazd-Raktar; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-csomagoszto; SKFB-FN-penzugy; SKFB-FN-targyraktaros; SKFB-Internet-Enabled; SKFB-FN-ertekkezelo; SKFB-FN-fogugykez; SKFB-FN-befog-elsolet; SKFB-FN-masodlet; SKFB-FN-okmanykezelo; SKFB-FTPUsers; SKFB-FTPIlletmeny; SKFB-NexonHRpersONLINE; SKFB-FN-talalttargy; SKFB-MobilKapcsolat; SKFB-NoemiHelpDesk; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-ForrasDotNet; SKFB-PR122; SKFB-FN-TELEFON-ugyintezo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-PR149";
                    }
                case "Raktáros foglalkoztatási előadó":
                    {
                        return "SKFB-ForrasUsers; SKFB-Gazd-Raktar; SKFB-NX-ISZM; SKFB-Nexon; SKFB-FN-csomagoszto; SKFB-FN-bunnyilv; SKFB-FN-targyraktaros; SKFB-Internet-Enabled; SKFB-FN-ertekkezelo; SKFB-FN-befog-elsolet; SKFB-FN-masodlet; SKFB-FN-okmanykezelo; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-Munkaltatas; SKFB-FN-talalttargy; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-ForrasDotNet; SKFB-PR118; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-PR149";
                    }
                case "Műszaki főelőadó":
                    {
                        return "SKFB-IrfanView; SKFB-Internet-Enabled; SKFB-Gazd-Muszaki; SKFB-FlashEnabled; SKFB-OptenOptijus; SKFB-Pictures; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-VezetoiSzignalas; SKFB-Vir; SKFB-VIR-Munkaltatas-User; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-PR02; SKFB-JKR; SKFB-JKR-Dashboard; SKFB-JKR-BMadmin; SKFB-Szallas; SKFB-BVORG-H; SKFB-BVORG-Q; SKFB-BVORG-S";
                    }
                case "Műszaki előadó":
                    {
                        return "SKFB-Internet-Enabled; SKFB-Gazd-Muszaki; SKFB-Pictures; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-Vir; SKFB-VIR-Munkaltatas-User; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-PR02; SKFB-Szallas; SKFB-BVORG-H; SKFB-BVORG-Q; SKFB-BVORG-S";
                    }
                case "Beszerző":
                    {
                        return "SKFB-Internet-Enabled; SKFB-Gazd-Muszaki";
                    }
                case "Gépjármű műhelyvezető":
                    {
                        return "SKFB-Gazd-Gepjarmu; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Carreg-Users; SKFB-Carreg-Readers; SKFB-Internet-Enabled; SKFB-FTPUsers; SKFB-Optiproba; SKFB-NexonHRpersONLINE; SKFB-Carreg; SKFB-JKR-Dashboard; SKFB-JKR-BMadmin";
                    }
                case "Gépjárművezető":
                    {
                        return "SKFB-Gazd-Gepjarmu; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Carreg-Users; SKFB-Carreg-Readers; SKFB-Internet-Enabled; SKFB-FTPUsers; SKFB-Optiproba; SKFB-NexonHRpersONLINE; SKFB-Carreg; SKFB-JKR-Dashboard; SKFB-JKR-BMadmin";
                    }
                case "Pénzügyi előadó":
                    {
                        return "SKFB-Gazd-Penzugy; SKFB-GyogyszerNyilvantartas; SKFB-FN-csomagoszto; SKFB-FN-penzugy; SKFB-FN-targyraktaros; SKFB-Internet-Enabled; SKFB-FN-ertekkezelo; SKFB-Pictures; SKFB-FN-befog-elsolet; SKFB-FN-masodlet; SKFB-FN-okmanykezelo; SKFB-FN-konyvelo; SKFB-FN-karteriteskezelo; SKFB-FN-penzugyparamkez; SKFB-NexonHRpersONLINE; SKFB-FN-talalttargy; SKFB-FN-hivasnaplo-megtekinto; SKFB-NoemiHelpDesk; SKFB-FN-TELEFON-megtekinto; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-PR156";
                    }
                case "Pénztáros":
                    {
                        return "SKFB-ForrasUsers; SKFB-CafeteriaAdmin; SKFB-Gazd-Szamvitel; SKFB-Abevjava; SKFB-FN-penzugy; SKFB-Internet-Enabled; SKFB-FN-ertekkezelo; SKFB-FN-befog-elsolet; SKFB-FTPUsers; SKFB-FTPIlletmeny; SKFB-FN-konyvelo; SKFB-FN-karteriteskezelo; SKFB-FN-penzugyparamkez; SKFB-NexonHRpersONLINE; SKFB-KIRAcopy; SKFB-ForrasDotNet; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-Abevupdate; SKFB-Letszamjelentes-biztpub; SKFB-FTPSzamfejtes; SKFB-PR143; SKFB-Szallas";
                    }
                case "Számvíteli főelőadó":
                    {
                        return "SKFB-ForrasUsers; SKFB-Gazd-Szamvitel; SKFB-Abevjava; SKFB-NX-IFEM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-KVKUsers; SKFB-OptenOptijus; SKFB-Pictures; SKFB-FTPUsers; SKFB-FTPIlletmeny; SKFB-NexonHRpersONLINE; SKFB-NoemiHelpDesk; SKFB-ForrasDotNet; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-Abevupdate; SKFB-FTPSzamfejtes; SKFB-PR146; SKFB-BVORG-P";
                    }
                case "Számviteli előadó":
                    {
                        return "SKFB-ForrasUsers; SKFB-Gazd-Szamvitel; SKFB-Abevjava; SKFB-Internet-Enabled; SKFB-KVKUsers; SKFB-FTPUsers; SKFB-FTPIlletmeny; SKFB-NexonHRpersONLINE; SKFB-ForrasDotNet; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-Abevupdate; SKFB-Bizttechfejlesztes; SKFB-FTPSzamfejtes; SKFB-PR139; SKFB-BVORG-P; SKFB-E-szamla";
                    }
                case "Gondnok":
                    {
                        return "SKFB-Gazd-Raktar; SKFB-Internet-Enabled; SKFB-NexonHRpersONLINE";
                    }
                case "Takarító":
                    {
                        return "SKFB-Internet-Enabled";
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
                case "Osztályvezető":
                    {
                        return "SKFB-Szem-Szemvez; SKFB-Szem-Szemelyugy; SKFB-Vezetok; SKFB-IrfanView; SKFB-NX-ISZM; SKFB-NX-IHRV; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-NX-IITA; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-Pictures; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-PR83; SKFB-Kozfoglalkprog; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Toborzas; SKFB-Ugyfelkapu; SKFB-Szenyor; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-NYDR-Human; SKFB-NYDR; SKFB-IKKB; SKFB-PR147; SKFB-ISZR; SKFB-Human-Igazolas; SKFB-BVORG-I; SKFB-BVORG-J; SKFB-BVORG-P";
                    }
                case "Személyügyi alosztályvezető":
                    {
                        return "SKFB-Szem-Szemvez; SKFB-Szem-Szemelyugy; SKFB-Vezetok; SKFB-IrfanView; SKFB-NX-ISZM; SKFB-NX-IHRV; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-NX-IITA; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-Pictures; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-PR83; SKFB-Kozfoglalkprog; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Toborzas; SKFB-Ugyfelkapu; SKFB-Szenyor; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-NYDR-Human; SKFB-NYDR; SKFB-IKKB; SKFB-PR147; SKFB-ISZR; SKFB-Human-Igazolas; SKFB-BVORG-I; SKFB-BVORG-J; SKFB-BVORG-P";
                    }
                case "Személyügyi főelőadó":
                    {
                        return "SKFB-Szem-Szemelyugy; SKFB-Szem-Ugykezelo; SKFB-Futar; SKFB-Vezetok; SKFB-NX-ISZM; SKFB-NX-IHRM; SKFB-NX-IHRV; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-Napijelentes; SKFB-FTPIlletmeny; SKFB-NexonHRpersONLINE; SKFB-PR83; SKFB-VezetoiSzignalas; SKFB-Toborzas; SKFB-Ugyfelkapu; SKFB-Szenyor; SKFB-NYDR-Human; SKFB-NYDR; SKFB-IKKB; SKFB-PR147; SKFB-BVORG-J; SKFB-BVORG-P; SKFB-BVORG-S";
                    }
                case "Személyügyi előadó":
                    {
                        return "SKFB-Szem-Szemelyugy; SKFB-Szem-Ugykezelo; SKFB-Futar; SKFB-NX-ISZM; SKFB-NX-IHRM; SKFB-NX-IHRV; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-Napijelentes; SKFB-FTPIlletmeny; SKFB-NexonHRpersONLINE; SKFB-PR83; SKFB-Ugyfelkapu; SKFB-Szenyor; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-PR147; SKFB-ISZR; SKFB-BVORG-J";
                    }
                case "Személyügyi segédelőadó":
                    {
                        return "SKFB-CafeteriaAdmin; SKFB-Szem-Szemelyugy; SKFB-Szem-Ugykezelo; SKFB-Futar; SKFB-NX-ISZM; SKFB-NX-IHRM; SKFB-NX-IHRV; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-Napijelentes; SKFB-FTPUsers; SKFB-FTPIlletmeny; SKFB-NexonHRpersONLINE; SKFB-Vezetoi-elfoglaltsag; SKFB-PR83; SKFB-VezetoiSzignalas; SKFB-Ugyfelkapu; SKFB-Szenyor; SKFB-PR147; SKFB-BVORG-J";
                    }
                case "Titkársági alosztályvezető":
                    {
                        return "SKFB-Szem-Szemvez; SKFB-Szem-Szemelyugy; SKFB-Vezetok; SKFB-IrfanView; SKFB-NX-ISZM; SKFB-NX-IHRV; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-NX-IITA; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-Pictures; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-PR83; SKFB-Kozfoglalkprog; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Toborzas; SKFB-Ugyfelkapu; SKFB-Szenyor; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-FN-SZERZODES-SZERKESZTO; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-NYDR-Human; SKFB-NYDR; SKFB-IKKB; SKFB-PR147; SKFB-ISZR; SKFB-Human-Igazolas; SKFB-BVORG-I; SKFB-BVORG-J; SKFB-BVORG-P";
                    }
                case "Ügykezelő":
                    {
                        return "SKFB-Szem-Ugykezelo; SKFB-Futar; SKFB-Internet-Enabled; SKFB-Napijelentes; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-Letszamjelentes-biztpub; SKFB-eSzigno; SKFB-PR145; SKFB-BVORG-I";
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
                case "Katonai ügyész":
                    {
                        return "SKFB-Internet-Enabled";
                    }
                case "Ügyészségi fogalmazó":
                    {
                        return "SKFB-Internet-Enabled";
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
                case "Kiemelt nyomozó":
                    {
                        return "SKFB-Internet-Enabled; SKFB-PR51";
                    }
                case "Főelőadó":
                    {
                        return "SKFB-Internet-Enabled; SKFB-PR51";
                    }
                case "Előadó":
                    {
                        return "SKFB-Internet-Enabled; SKFB-PR51";
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
                        return "SKFB-Vezetok; SKFB-IrfanView; SKFB-NX-IFEM; SKFB-NX-IBVV; SKFB-Nexon; SKFB-FN-bizt-ov; SKFB-Internet-Enabled; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-Pictures; SKFB-NexonHRpersONLINE; SKFB-Vezetoi-elfoglaltsag; SKFB-VEZKOZV; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Vir; SKFB-VIR-Munkaltatas-User; SKFB-Parancsnok; SKFB-VezetoiJelenlet; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-bfb-ugyintezo; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-FN-kart-ugyintezo; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-Tulora; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-parancsnok; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-BIT-JELENTES; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-FN-Fegyelmi-fofelugyelo; SKFB-PR114; SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo; SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo-jovahagyo; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-jovahagyo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-FN-Navigator-kffenaplo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-IKKB; SKFB-Szallas; SKFB-BVORG-J; SKFB-BVORG-J-2";
                    }
                case "Parancsnok helyettes":
                    {
                        return "SKFB-Bizt-Biztov; SKFB-Vezetok; SKFB-IrfanView; SKFB-PR25; SKFB-NX-ISZM; SKFB-NX-ISZA; SKFB-Nexon; SKFB-FN-bizt-ov; SKFB-FN-bizt; SKFB-Internet-Enabled; SKFB-FlashEnabled; SKFB-OptenOptijusPlussz; SKFB-FN-int-vedett; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-Vezetoi-elfoglaltsag; SKFB-FTPVedelem; SKFB-KiemeltFogvatartottR; SKFB-VEZKOZV; SKFB-VezetoiSzignalas; SKFB-Ter; SKFB-Vir; SKFB-Bfb; SKFB-VezetoiJelenlet; SKFB-FN-kart-adatszolgaltato; SKFB-FN-kart-ugyintezo; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-Tulora; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-eloallitasnaplo; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Navigator-belepesinaplo; SKFB-Parancsnokhelyettes; SKFB-Bizttechfejlesztes; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-BIT-JELENTES; SKFB-FN-Navigator-ellenorzesinaplo-jovahagyo; SKFB-FN-Fegyelmi-jogkor-gyakorloja; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-FN-Fegyelmi-egyeb-szakterulet; SKFB-FN-Fegyelmi-fofelugyelo; SKFB-MarathonTerra3; SKFB-JKR-Dashboard; SKFB-JKR-BMadmin; SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo; SKFB-FN-Navigator-korletfelugyeloiellenorzesinaplo-jovahagyo; SKFB-FN-Navigator-ejfeli-adatszolgaltatas; SKFB-FN-Navigator-bitnaplo; SKFB-FN-Navigator-bitnaplo-jovahagyo; SKFB-FN-Navigator-kffenaplo-jovahagyo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo-jovahagyo; SKFB-FN-Navigator-kffenaplo; SKFB-FN-Navigator-munkahelyiszolgalatinaplo; SKFB-IKKB; SKFB-PR152; SKFB-BVORG-KSZNYFO; SKFB-BVORG-A; SKFB-BVORG-B; SKFB-BVORG-C; SKFB-BVORG-D; SKFB-BVORG-E; SKFB-BVORG-F; SKFB-BVORG-G; SKFB-BVORG-H; SKFB-BVORG-I; SKFB-BVORG-J; SKFB-BVORG-L; SKFB-BVORG-M; SKFB-BVORG-N; SKFB-BVORG-O; SKFB-BVORG-P; SKFB-BVORG-Q; SKFB-BVORG-R; SKFB-BVORG-S; SKFB-BVORG-J-2; SKFB-Adatszolg-Kitolto-Biztonsag";
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
                case "Nyomozó és fegyelmi tiszt":
                    {
                        return "SKFB-Vezkozv-Fegyelmi; SKFB-Vezetok; SKFB-IrfanView; SKFB-NX-IFEM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-Napijelentes; SKFB-OptenOptijus; SKFB-Pictures; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-PR31; SKFB-SajtoRZS; SKFB-Szenyor; SKFB-Vezkozv-Eloado; SKFB-Kommunikacios; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-BIT-JELENTES; SKFB-FN-Navigator-bitnaplo; SKFB-IKKB; SKFB-FN-Navigator-bitnaplo-osztalyvezeto; SKFB-ISZR; SKFB-KameraFelvetelek; SKFB-BVORG-J; SKFB-BVORG-J-2";
                    }
                case "Tűzvédelmi vezető":
                    {
                        return "SKFB-IrfanView; SKFB-Internet-Enabled; SKFB-FN-fogugykez; SKFB-FlashEnabled; SKFB-OptenOptijus; SKFB-Vezkozv-Tuzvedelem; SKFB-NexonHRpersONLINE; SKFB-VezetoiSzignalas; SKFB-PR119; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-IKKB; SKFB-Adatszolg-Kitolto-Rendezvenyek";
                    }
                case "Munkavédelmi vezető":
                    {
                        return "SKFB-Vezkozv-Munkavedelem; SKFB-Internet-Enabled; SKFB-OptenOptijus; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-VezetoiSzignalas; SKFB-PR119; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-Ellenorzesinaplo-biztpub-iras; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-IKKB; SKFB-ISZR";
                    }
                case "Titkárságvezető":
                    {
                        return "SKFB-Vezetok; SKFB-IrfanView; SKFB-FN-nevelok; SKFB-FN-penzugy; SKFB-Internet-Enabled; SKFB-OptenOptijusPlussz; SKFB-FTPUsers; SKFB-VezetoiSzignalas; SKFB-PR58; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-kart-ugyintezo; SKFB-FN-kart-egyeb-panasz-kivizsgalo; SKFB-FN-kart-megtekinto; SKFB-FN-bvbank-megtekinto; SKFB-FN-TELEFON-megtekinto; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-Navigator-ellenorzesinaplo; SKFB-KulsoEllenorzes; SKFB-PR125; SKFB-Vezkozv-Titkarsagvezeto; SKFB-FN-Fegyelmi-reintegracios-tiszt; SKFB-ISZR; SKFB-BVORG-KSZNYFO; SKFB-BVORG-A; SKFB-BVORG-B; SKFB-BVORG-C; SKFB-BVORG-D; SKFB-BVORG-E; SKFB-BVORG-F; SKFB-BVORG-G; SKFB-BVORG-H; SKFB-BVORG-I; SKFB-BVORG-J; SKFB-BVORG-K; SKFB-BVORG-L; SKFB-BVORG-M; SKFB-BVORG-N; SKFB-BVORG-O; SKFB-BVORG-P; SKFB-BVORG-Q; SKFB-BVORG-R; SKFB-BVORG-S; SKFB-BVORG-J-2";
                    }
                case "Belső ellenőr":
                    {
                        return "SKFB-ForrasUsers; SKFB-Abevjava; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-BelsoellenorTudastar; SKFB-VezetoiSzignalas; SKFB-Vir; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-param-szerk; SKFB-FN-fogl-munkaerogazdalkodo; SKFB-FN-fogl-kult-reint-tiszt; SKFB-ForrasDotNet; SKFB-Asz; SKFB-Vezkozv-Belsoellenor; SKFB-PR84; SKFB-IKKB; SKFB-BVORG-A";
                    }
                case "Jogtanácsos":
                    {
                        return "SKFB-Abevjava; SKFB-FN-nevelok; SKFB-FN-bunnyilv; SKFB-Internet-Enabled; SKFB-OptenCeginfo; SKFB-OptenOptijusPlussz; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-VezetoiSzignalas; SKFB-Vezkozv-Jogtanacsos; SKFB-PR102; SKFB-FN-SZERZODES-MEGTEKINTO; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-BVORG-I; SKFB-Adatszolg-Kitolto-Jogi";
                    }
                case "Lelkész":
                    {
                        return "SKFB-FN-nevelok; SKFB-Internet-Enabled; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-FN-fogl-munkahelyvezeto; SKFB-FN-fogl-kult-reint-tiszt; SKFB-PR94; SKFB-Vezkozv-Lelkesz; SKFB-FN-Fegyelmi-egyeb-szakterulet";
                    }
                case "Parancsnok titkárnő":
                    {
                        return "SKFB-Vezetok; SKFB-NX-ISZM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-Napijelentes; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-Scan-Pk; SKFB-Vezetoi-elfoglaltsag; SKFB-Parancsnok; SKFB-VezetoiJelenlet; SKFB-Tulora; SKFB-Letszamjelentes-biztpub; SKFB-Ellenorzesinaplo-biztpub-olvasas; SKFB-PR152; SKFB-ISZR; SKFB-Parancsnok-Titkarno; SKFB-BVORG-D";
                    }
                case "Előadó":
                    {
                        return "SKFB-Users; SKFB-Vezetok; SKFB-IrfanView; SKFB-NX-ISZM; SKFB-NX-IFEM; SKFB-Nexon; SKFB-Internet-Enabled; SKFB-Napijelentes; SKFB-OptenOptijus; SKFB-NX-SZAB; SKFB-FTPUsers; SKFB-NexonHRpersONLINE; SKFB-Scan-Pk; SKFB-Vezetoi-elfoglaltsag; SKFB-PR31; SKFB-VEZKOZV; SKFB-Parancsnok; SKFB-VezetoiJelenlet; SKFB-Szenyor; SKFB-Vezkozv-Eloado; SKFB-Letszamjelentes-biztpub; SKFB-FN-Navigator-jelentesrekotnaplo; SKFB-FN-JFK-FEGYJUTMEGTEKINTO; SKFB-ISZR; SKFB-KameraFelvetelek";
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
                case "Biztonsági és fogvatartási ügyek osztálya":
                    {
                        return GetBiztAndBVPermissions(groupName);
                    }
                case "EFOP":
                    {
                        return GetEFOPPermissions(groupName);
                    }
                case "Egészségügyi és pszichológiai osztály":
                    {
                        return GetEUPermissions(groupName);
                    }
                case "Gazdasági Ellátó Intézet":
                    {
                        return GetGEIPermissions(groupName);
                    }
                case "Műszaki ellátási osztály":
                    {
                        return GetMuszakiEllatasPermissions(groupName);
                    }
                case "Személyügyi és titkársági osztály":
                    {
                        return GetSzemPermissions(groupName);
                    }
                case "Ügyészség":
                    {
                        return GetUgyeszPermissions(groupName);
                    }
                case "Nemzeti Védelmi Szolgálat":
                    {
                        return GetNVSZPermissions(groupName);
                    }
                case "Vezetői törzs":
                    {
                        return GetVezetokPermissions(groupName);
                    }
                case "Vezetői közvetlen":
                    {
                        return GetVezkozvPermissions(groupName);
                    }
                default:
                    {
                        return noPermissions;
                    }
            }
        }
    }
}