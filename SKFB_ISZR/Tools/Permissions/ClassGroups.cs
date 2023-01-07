using System.Windows.Forms;

namespace SKFB_ISZR.Tools.Permissions
{
    // Szakterületi alcsoportok importálása
    internal class ClassGroups
    {
        // Központi combobox
        public static ComboBox specialityGroups = new ComboBox();

        // Osztályok
        /*
         * Biztonsági és fogvatartási ügyek osztálya
         * EFOP
         * Egészségügyi és pszichológiai osztály
         * Gazdasági Ellátó Intézet
         * Humánpolitikai osztály
         * Ipari, termelési, logisztikai és üzemfenntartási osztály
         * Kereskedelmi és ruhaipari osztály
         * Minőségellenőrzési osztály
         * Műszaki ellátási osztály
         * Személyügyi és titkársági osztály
         * Vezetői közvetlen
         * Vezetői törzs
         */

        // Combobox módosítása
        public static void GetGroups(string speciality)
        {
            specialityGroups.Items.Clear();

            switch (speciality)
            {
                case "Biztonsági és fogvatartási ügyek osztálya":
                    {
                        // Biztonsági
                        specialityGroups.Items.Add("Osztályvezető");
                        specialityGroups.Items.Add("Biztonsági alosztályvezető");
                        specialityGroups.Items.Add("Biztonsági tiszt");
                        specialityGroups.Items.Add("Biztonsági főfelügyelő");
                        specialityGroups.Items.Add("Biztonsági felügyelő");
                        specialityGroups.Items.Add("Fegyveres biztonsági őr");
                        specialityGroups.Items.Add("Kutyatelep-vezető");
                        specialityGroups.Items.Add("Kutyavezető");
                        specialityGroups.Items.Add("Fegyvermester");
                        specialityGroups.Items.Add("Biztonsági segédelőadó");
                        specialityGroups.Items.Add("Biztonsági előadó");
                        specialityGroups.Items.Add("Körlet felügyelő");
                        specialityGroups.Items.Add("Körlet főfelügyelő");
                        specialityGroups.Items.Add("Műveleti főfelügyelő");
                        // Fogvatartási
                        specialityGroups.Items.Add("Fogvatartási alosztályvezető");
                        specialityGroups.Items.Add("Fogvatartási alosztályvezető-helyettes");
                        specialityGroups.Items.Add("Nyilvántartó főelőadó");
                        specialityGroups.Items.Add("Nyilvántartó előadó");
                        specialityGroups.Items.Add("Nyilvántartó segédelőadó");
                        specialityGroups.Items.Add("Körlet ellátó főfelügyelő");
                        specialityGroups.Items.Add("Körlet ellátó segédelőadó");
                        specialityGroups.Items.Add("Vezető reintegrációs tiszt");
                        specialityGroups.Items.Add("Reintegraciós tiszt");
                        specialityGroups.Items.Add("Szociális segédelőadó");
                        specialityGroups.Items.Add("Pártfogó felügyelő");
                        break;
                    }
                case "EFOP":
                    {
                        specialityGroups.Items.Add("Csoportvezető");
                        specialityGroups.Items.Add("Pályázati tanácsadó");
                        break;
                    }
                case "Egészségügyi és pszichológiai osztály":
                    {
                        specialityGroups.Items.Add("Osztályvezető");
                        specialityGroups.Items.Add("Főápoló");
                        specialityGroups.Items.Add("Orvos");
                        specialityGroups.Items.Add("Orvos asszisztens");
                        specialityGroups.Items.Add("Szakápoló");
                        specialityGroups.Items.Add("Előadó");
                        specialityGroups.Items.Add("Szakpszichológus");
                        specialityGroups.Items.Add("Pszichológus");
                        break;
                    }
                case "Gazdasági Ellátó Intézet":
                    {
                        specialityGroups.Items.Add("Informatikus");
                        specialityGroups.Items.Add("Biztonságtechnikus");
                        specialityGroups.Items.Add("Felszer");
                        specialityGroups.Items.Add("Kártérítés");
                        specialityGroups.Items.Add("Letét");
                        break;
                    }
                case "Humánpolitikai osztály":
                    {
                        specialityGroups.Items.Add("-");
                        break;
                    }
                case "Ipari, termelési, logisztikai és üzemfenntartási osztály":
                    {
                        specialityGroups.Items.Add("-");
                        break;
                    }
                case "Kereskedelmi és ruhaipari osztály":
                    {
                        specialityGroups.Items.Add("-");
                        break;
                    }
                case "Minőségellenőrzési osztály":
                    {
                        specialityGroups.Items.Add("-");
                        break;
                    }
                case "Műszaki ellátási osztály":
                    {
                        specialityGroups.Items.Add("Osztályvezető");
                        specialityGroups.Items.Add("Gazdasági alosztályveztő");
                        specialityGroups.Items.Add("Gépház műhelyvezető");
                        specialityGroups.Items.Add("Gépház foglalkoztatási segédelőadó");
                        specialityGroups.Items.Add("Élelmezésvezető");
                        specialityGroups.Items.Add("Élelmezési csoportvezető");
                        specialityGroups.Items.Add("Élelmezési foglalkoztatási segédelőadó");
                        specialityGroups.Items.Add("Raktárvezető");
                        specialityGroups.Items.Add("Raktáros foglalkoztatási segédelőadó");
                        specialityGroups.Items.Add("Raktáros foglalkoztatási előadó");
                        specialityGroups.Items.Add("Műszaki főelőadó");
                        specialityGroups.Items.Add("Műszaki előadó");
                        specialityGroups.Items.Add("Beszerző");
                        specialityGroups.Items.Add("Gépjármű műhelyvezető");
                        specialityGroups.Items.Add("Gépjárművezető");
                        specialityGroups.Items.Add("Pénzügyi előadó");
                        specialityGroups.Items.Add("Pénztáros");
                        specialityGroups.Items.Add("Számvíteli főelőadó");
                        specialityGroups.Items.Add("Számviteli előadó");
                        specialityGroups.Items.Add("Gondnok");
                        specialityGroups.Items.Add("Takarító");
                        specialityGroups.Items.Add("Fenntartási alosztályvezető"); //KZ
                        break;
                    }
                case "Személyügyi és titkársági osztály":
                    {
                        // Személyügyi
                        specialityGroups.Items.Add("Osztályvezető");
                        specialityGroups.Items.Add("Személyügyi főelőadó");
                        specialityGroups.Items.Add("Személyügyi előadó");
                        specialityGroups.Items.Add("Személyügyi segédelőadó");
                        // Titkárság
                        specialityGroups.Items.Add("Titkársági alosztályvezető");
                        specialityGroups.Items.Add("Ügykezelő");
                        break;
                    }
                case "Ügyészség":
                    {
                        specialityGroups.Items.Add("Katonai ügyész");
                        specialityGroups.Items.Add("Ügyészségi fogalmazó");
                        break;
                    }
                case "Nemzeti Védelmi Szolgálat":
                    {
                        specialityGroups.Items.Add("Kiemelt nyomozó");
                        specialityGroups.Items.Add("Főelőadó");
                        specialityGroups.Items.Add("Előadó");
                        break;
                    }
                case "Vezetői törzs":
                    {
                        specialityGroups.Items.Add("Parancsnok");
                        specialityGroups.Items.Add("Parancsnok helyettes");
                        break;
                    }
                case "Vezetői közvetlen":
                    {
                        specialityGroups.Items.Add("Nyomozó és fegyelmi tiszt");
                        specialityGroups.Items.Add("Tűzvédelmi vezető");
                        specialityGroups.Items.Add("Munkavédelmi vezető");
                        specialityGroups.Items.Add("Titkárságvezető");
                        specialityGroups.Items.Add("Belső ellenőr");
                        specialityGroups.Items.Add("Jogtanácsos");
                        specialityGroups.Items.Add("Lelkész");
                        specialityGroups.Items.Add("Parancsnok titkárnő");
                        specialityGroups.Items.Add("Előadó");
                        break;
                    }
                default:
                    break;
            }
        }
    }
}