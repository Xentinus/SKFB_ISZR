using System.Windows.Forms;

namespace SKFB_ISZR
{
    // Szakterületi alcsoportok importálása
    internal class SpecialityGroups
    {
        // Központi combobox
        public static ComboBox specialityGroups = new ComboBox();

        /*
        Biztonsági osztály
        Büntetés-végrehajtási osztály
        EFOP
        Egészségügyi osztály
        Gazdasági osztály
        Gazdasági társaság
        Informatikai osztály
        Nemzeti Védelmi Szolgálat
        Személyügyi és szociális osztály
        Ügyészség
        Vezetői közvetlen
        Vezetőség
        */

        // Combobox módosítása
        public static void GetGroups(string speciality)
        {
            specialityGroups.Items.Clear();

            switch (speciality)
            {
                case "Biztonsági osztály":
                    {
                        specialityGroups.Items.Add("Biztonsági felügyelők");
                        specialityGroups.Items.Add("Biztonsági főfelügyelők");
                        specialityGroups.Items.Add("Biztonsági tisztek");
                        specialityGroups.Items.Add("Biztonsági osztályvezető");
                        specialityGroups.Items.Add("Biztonsági osztályvezető helyettes");
                        specialityGroups.Items.Add("Fegyveres biztonsági őr");
                        specialityGroups.Items.Add("Kutyavezetők");
                        specialityGroups.Items.Add("Kutyatelep-vezető");
                        specialityGroups.Items.Add("Müveleti csoport");
                        specialityGroups.Items.Add("Fegyvermester");
                        specialityGroups.Items.Add("Szállításvezető");
                        specialityGroups.Items.Add("Titkárság");
                        break;
                    }
                case "Büntetés-végrehajtási osztály":
                    {
                        specialityGroups.Items.Add("Büntetés-végrehajtási osztályvezető");
                        specialityGroups.Items.Add("Körlet felügyelők");
                        specialityGroups.Items.Add("Körlet főfelügyelők");
                        specialityGroups.Items.Add("Bűnügyi nyilvántartók");
                        specialityGroups.Items.Add("Nyilvántartási osztályvezető-helyettes");
                        specialityGroups.Items.Add("Körlet ellátó főfelügyelő (Anyagi)");
                        specialityGroups.Items.Add("Körlet ellátó segédelőadó (Anyagi)");
                        specialityGroups.Items.Add("Reintegraciós tisztek");
                        specialityGroups.Items.Add("Vezető Reintegrációs tiszt");
                        specialityGroups.Items.Add("Szociális előadók");
                        specialityGroups.Items.Add("Pártfogó felügyelők");
                        break;
                    }
                case "EFOP":
                    {
                        specialityGroups.Items.Add("Csoportvezető");
                        specialityGroups.Items.Add("Pályázati tanácsadók");
                        break;
                    }
                case "Egészségügyi osztály":
                    {
                        specialityGroups.Items.Add("Előadók");
                        specialityGroups.Items.Add("Szakápolók");
                        specialityGroups.Items.Add("Főápolók");
                        specialityGroups.Items.Add("Egészségügyi osztályvezető");
                        specialityGroups.Items.Add("Orvosok");
                        specialityGroups.Items.Add("Fogszakorvos");
                        specialityGroups.Items.Add("Fogszakorvos asszisztens");
                        break;
                    }
                case "Gazdasági osztály":
                    {
                        specialityGroups.Items.Add("Anyaggazdálkodási főelőadó");
                        specialityGroups.Items.Add("Gazdasági vezető");
                        specialityGroups.Items.Add("Gépház raktárosok");
                        specialityGroups.Items.Add("Gépház vezetők");
                        specialityGroups.Items.Add("Gépjárművezetők");
                        specialityGroups.Items.Add("Műszaki csoport");
                        specialityGroups.Items.Add("Pénzügyi csoport");
                        specialityGroups.Items.Add("Raktárosok");
                        specialityGroups.Items.Add("Pénztárosok");
                        specialityGroups.Items.Add("Számviteli csoport");
                        specialityGroups.Items.Add("Élelmezési csoport");
                        break;
                    }
                case "Gazdasági társaság":
                    {
                        specialityGroups.Items.Add("Biztonsági vezető");
                        specialityGroups.Items.Add("Munkaügyi csoport");
                        specialityGroups.Items.Add("Titkárság");
                        specialityGroups.Items.Add("Igazgatóság");
                        break;
                    }
                case "Informatikai osztály":
                    {
                        specialityGroups.Items.Add("Hír-biztonságtechnika");
                        specialityGroups.Items.Add("Informatikai előadók");
                        specialityGroups.Items.Add("Informatikai osztályvezető");
                        break;
                    }
                case "Személyügyi és szociális osztály":
                    {
                        specialityGroups.Items.Add("Személyügyi előadók");
                        specialityGroups.Items.Add("Személyügyi és szervezési osztályvezető");
                        specialityGroups.Items.Add("Ügykezelők");
                        break;
                    }
                case "Ügyészség":
                    {
                        specialityGroups.Items.Add("Katonai ügyészek");
                        break;
                    }
                case "Nemzeti Védelmi Szolgálat":
                    {
                        specialityGroups.Items.Add("Operatív csoport");
                        break;
                    }
                case "Vezetőség":
                    {
                        specialityGroups.Items.Add("Parancsnok");
                        specialityGroups.Items.Add("Parancsnok helyettes");
                        break;
                    }
                case "Vezetői közvetlen":
                    {
                        specialityGroups.Items.Add("Belső ellenőrők");
                        specialityGroups.Items.Add("Előadók");
                        specialityGroups.Items.Add("Nyomozó és fegyelmi tiszt");
                        specialityGroups.Items.Add("Jogtanácsosok");
                        specialityGroups.Items.Add("Kártalantási előadók");
                        specialityGroups.Items.Add("Lelkészek");
                        specialityGroups.Items.Add("Munkavédelmi vezető");
                        specialityGroups.Items.Add("Pszichológusok");
                        specialityGroups.Items.Add("Titkárságvezető");
                        specialityGroups.Items.Add("Tűzvédelmi vezető");
                        break;
                    }
                default:
                    break;
            }
        }
    }
}