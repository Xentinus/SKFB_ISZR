namespace SKFB_ISZR.Tools.Permissions
{
    internal class SpecialityPermissions
    {
        public static string globalPermission = "SKFB-Adatszolgaltatasok; SKFB-Cafeteria; SKFB-FN3-F2020; SKFB-FN3-FONIX3; SKFB-FN3-Mobil; SKFB-FN-karbejelento; SKFB-FN-lekerdezok; SKFB-FN-Navigator-kfenaplo; SKFB-FN-Rebeka-felhasznalo; SKFB-Internet-Enabled; SKFB-Intranet; SKFB-MapRoamApp; SKFB-RobotZsaruNeo; SKFB-Users; ";

        public static string GetPermissions(string specialityName)
        {
            switch (specialityName)
            {
                case "Biztonsági osztály":
                    {
                        return "SKFB-BIZT; SKFB-FN-bizt; SKFB-Scan-Bizt; SKFB-FN-Navigator-belepesinaplo; SKFB-FN-Navigator-megtekinto; " + globalPermission;
                    }
                case "Büntetés-végrehajtási osztály":
                    {
                        return "SKFB-BV; SKFB-Scan-Bv; " + globalPermission;
                    }
                case "EFOP":
                    {
                        return "SKFB-EFOP; SKFB-Scan-Efop; SKFB-FN-RIN-EFOPESETMENEDZSER; " + globalPermission;
                    }
                case "Egészségügyi osztály":
                    {
                        return "SKFB-EU; SKFB-FN-BvEuSzakdolgozo; SKFB-Scan-Eu; " + globalPermission;
                    }
                case "Gazdasági osztály":
                    {
                        return "SKFB-GAZD; SKFB-Scan-Gazd; " + globalPermission;
                    }
                case "Gazdasági társaság":
                    {
                        return "SKFB-GT; SKFB-Scan-Gt; " + globalPermission;
                    }
                case "Informatikai osztály":
                    {
                        return "SKFB-INFO; SKFB-Scan-Info; " + globalPermission;
                    }
                case "Nemzeti Védelmi Szolgálat":
                    {
                        return "SKFB-NVSZ; " + globalPermission;
                    }
                case "Személyügyi és szociális osztály":
                    {
                        return "SKFB-SZEM; SKFB-Scan-Szem; " + globalPermission;
                    }
                case "Ügyészség":
                    {
                        return "SKFB-Ugyeszseg; " + globalPermission;
                    }
                case "Vezetői közvetlen":
                    {
                        return "SKFB-VEZKOZV; SKFB-Scan-Vezkozv; " + globalPermission;
                    }
                case "Vezetőség":
                    {
                        return "SKFB-Vezetok; SKFB-Scan-Pk; " + globalPermission;
                    }
                default:
                    {
                        return globalPermission;
                    }
            }
        }
    }
}