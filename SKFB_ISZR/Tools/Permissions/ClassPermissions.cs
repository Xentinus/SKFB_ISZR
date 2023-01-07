namespace SKFB_ISZR.Tools.Permissions
{
    internal class ClassPermissions
    {
        private static readonly string globalPermission = "SKFB-Adatszolgaltatasok; SKFB-Cafeteria; SKFB-FN3-F2020; SKFB-FN3-FONIX3; SKFB-FN3-Mobil; SKFB-FN-karbejelento; SKFB-FN-lekerdezok; SKFB-FN-Navigator-kfenaplo; SKFB-FN-Navigator-megtekinto; SKFB-FN-Rebeka-felhasznalo; SKFB-Intranet; SKFB-MapRoamApp; SKFB-RobotZsaruNeo; SKFB-Users; ";

        public static string getPermissions(string className)
        {
            switch (className)
            {
                case "Biztonsági és fogvatartási ügyek osztálya":
                    {
                        return "SKFB-BIZT; SKFB-FN-bizt; SKFB-Scan-Bizt; SKFB-FN-Navigator-belepesinaplo; SKFB-BV; SKFB-Scan-Bv;" + globalPermission;
                    }
                case "EFOP":
                    {
                        return "SKFB-EFOP; SKFB-Scan-Efop; SKFB-FN-RIN-EFOPESETMENEDZSER; " + globalPermission;
                    }
                case "Egészségügyi és pszichológiai osztály":
                    {
                        return "SKFB-EU; SKFB-FN-BvEuSzakdolgozo; SKFB-Scan-Eu; " + globalPermission;
                    }
                case "Gazdasági Ellátó Intézet":
                    {
                        return "SKFB-GEI; SKFB-Scan-GEI; " + globalPermission;
                    }
                case "Humánpolitikai osztály":
                    {
                        return globalPermission;
                    }
                case "Ipari, termelési, logisztikai és üzemfenntartási osztály":
                    {
                        return globalPermission;
                    }
                case "Kereskedelmi és ruhaipari osztály":
                    {
                        return globalPermission;
                    }
                case "Minőségellenőrzési osztály":
                    {
                        return globalPermission;
                    }
                case "Műszaki ellátási osztály":
                    {
                        return "SKFB-GAZD; SKFB-Scan-Gazd; " + globalPermission;
                    }
                case "Személyügyi és titkársági osztály":
                    {
                        return "SKFB-SZEM; SKFB-Scan-Szem; " + globalPermission;
                    }
                case "Ügyészség":
                    {
                        return "SKFB-Ugyeszseg; " + globalPermission;
                    }
                case "Nemzeti Védelmi Szolgálat":
                    {
                        return "SKFB-NVSZ; " + globalPermission;
                    }
                case "Vezetősi törzs":
                    {
                        return "SKFB-Vezetok; SKFB-Scan-Pk; " + globalPermission;
                    }
                case "Vezetői közvetlen":
                    {
                        return "SKFB-VEZKOZV; SKFB-Scan-Vezkozv; " + globalPermission;
                    }
                default:
                    {
                        return globalPermission;
                    }
            }
        }
    }
}