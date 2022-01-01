namespace SKFB_ISZR
{
    internal class SignatureEditor
    {
        // Kijelölt ügyintézők aláírása
        public static string GetUserRankSignature(string name)
        {
            switch (name)
            {
                case "Kellner Béla":
                    {
                        return "Kellner Béla bv. őrm.";
                    }
                case "Béla Kellner":
                    {
                        return "Kellner Béla bv. őrm.";
                    }
                case "Béres Anna":
                    {
                        return "Béres Anna bv. zls.";
                    }
                case "Tóth Vivien":
                    {
                        return "Vajda-Tóth Vivien bv. őrm.";
                    }
                case "Vajda-Tóth Vivien":
                    {
                        return "Vajda-Tóth Vivien bv. őrm.";
                    }
                case "Drávai Klaudia":
                    {
                        return "Drávai Klaudia bv. őrm.";
                    }
                case "Ézsöl Gábor":
                    {
                        return "Ézsöl Gábor bv. szds.";
                    }
                case "Horváth Katalin":
                    {
                        return "Horváth Katalin bv. ra.";
                    }
                case "Horváth Klaudia":
                    {
                        return "Horváth Klaudia bv. ra.";
                    }
                case "Vágner Judit":
                    {
                        return "Vágner Judit bv. ra.";
                    }
                case "Vinnai Sándor":
                    {
                        return "Vinnai Sándor bv. törm.";
                    }
                case "Bali Ákos Máté":
                    {
                        return "Bali Ákos Máté bv. őrm.";
                    }
                case "Gergelyi Éva":
                    {
                        return "Gergelyi Éva bv. zls.";
                    }
                case "Pintér Anita":
                    {
                        return "Pintér Anita bv. tőrm.";
                    }
                case "Hornung Tamás":
                    {
                        return "Hornung Tamás bv. tőrm.";
                    }
                case "Utassy Balázs":
                    {
                        return "Utassy Balázs bv. ra.";
                    }
                case "Varga László":
                    {
                        return "Varga László bv. szds.";
                    }
                default:
                    {
                        return name;
                    }
            }
        }

        // Osztályvezetők aláírása
        public static void GetClassLeaderSignature(string speciality)
        {
            /*
             *  Biztonsági osztály
                Büntetés-végrehajtási osztály
                EFOP
                Egészségügyi osztály
                Gazdasági osztály
                Gazdasági társaság *
                Informatikai osztály
                Nemzeti Védelmi Szolgálat *
                Személyügyi és szociális osztály
                Ügyészség *
                Vezetői közvetlen
                Vezetőség

            *-al jelölteknél a javasló üres
            */
            switch (speciality)
            {
                case "Biztonsági osztály":
                    DocumentEditor.classLeaderName = "Csalló Norbert bv. alez.";
                    DocumentEditor.classLeaderRole = "Biztonsági osztályvezető";
                    break;

                case "Büntetés-végrehajtási osztály":
                    DocumentEditor.classLeaderName = "Dögei Sándor bv. alez.";
                    DocumentEditor.classLeaderRole = "Büntetés-végrehajtási osztályvezető";
                    break;

                case "EFOP":
                    DocumentEditor.classLeaderName = "Vörös Csaba bv. alez.";
                    DocumentEditor.classLeaderRole = "EFOP Csoportvezető";
                    break;

                case "Egészségügyi osztály":
                    DocumentEditor.classLeaderName = "Nagy István bv. fhdgy.";
                    DocumentEditor.classLeaderRole = "Egészségügyi osztályvezető";
                    break;

                case "Gazdasági osztály":
                    DocumentEditor.classLeaderName = "Takács Péter bv. alez.";
                    DocumentEditor.classLeaderRole = "Gazdasági vezető";
                    break;

                case "Informatikai osztály":
                    DocumentEditor.classLeaderName = "Ézsöl Gábor bv. szds.";
                    DocumentEditor.classLeaderRole = "Informatikai osztályvezető";
                    break;

                case "Személyügyi és szociális osztály":
                    DocumentEditor.classLeaderName = "Varga Miklós bv. alez.";
                    DocumentEditor.classLeaderRole = "Személyügyi osztályvezető";
                    break;

                case "Vezetői közvetlen":
                    DocumentEditor.classLeaderName = "Fülöp István bv. ezds.";
                    DocumentEditor.classLeaderRole = "Intézetparancsnok";
                    break;

                case "Vezetőség":
                    DocumentEditor.classLeaderName = "Fülöp István bv. ezds.";
                    DocumentEditor.classLeaderRole = "Intézetparancsnok";
                    break;

                default:
                    DocumentEditor.classLeaderName = " ";
                    DocumentEditor.classLeaderRole = " ";
                    break;
            }
        }
    }
}