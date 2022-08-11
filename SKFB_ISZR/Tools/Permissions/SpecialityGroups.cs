using System.Windows.Forms;

namespace SKFB_ISZR.Tools.Permissions
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
                        specialityGroups.Items.Add("Biztonsági osztályvezető");
                        specialityGroups.Items.Add("Biztonsági osztályvezető-helyettes");
                        specialityGroups.Items.Add("Biztonsági tiszt");
                        specialityGroups.Items.Add("Biztonsági főfelügyelő");
                        specialityGroups.Items.Add("Biztonsági felügyelő");
                        specialityGroups.Items.Add("Fegyveres biztonsági őr");
                        specialityGroups.Items.Add("Kutyatelep-vezető");
                        specialityGroups.Items.Add("Kutyavezető");
                        specialityGroups.Items.Add("Müveleti csoport");
                        specialityGroups.Items.Add("Fegyvermester");
                        specialityGroups.Items.Add("Szállításvezető");
                        specialityGroups.Items.Add("Segédelőadó");
                        specialityGroups.Items.Add("Előadó");
                        specialityGroups.Items.Add("Körlet felügyelő");
                        specialityGroups.Items.Add("Körlet főfelügyelő");
                        specialityGroups.Items.Add("Műveleti főfelügyelő");
                        break;
                    }
                case "Büntetés-végrehajtási osztály":
                    {
                        specialityGroups.Items.Add("Büntetés-végrehajtási osztályvezető");
                        specialityGroups.Items.Add("Büntetés-végrehajtási osztályvezető-helyettes");
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
                case "Egészségügyi osztály":
                    {
                        specialityGroups.Items.Add("Egészségügyi osztályvezető");
                        specialityGroups.Items.Add("Főápoló");
                        specialityGroups.Items.Add("Orvos");
                        specialityGroups.Items.Add("Orvos asszisztens");
                        specialityGroups.Items.Add("Szakápoló");
                        specialityGroups.Items.Add("Előadó");
                        break;
                    }
                case "Gazdasági osztály":
                    {
                        specialityGroups.Items.Add("Gazdasági vezető");
                        specialityGroups.Items.Add("Gazdasági osztályvezető");
                        specialityGroups.Items.Add("Gazdasági osztályvezető-helyettes");
                        specialityGroups.Items.Add("Gépház műhelyvezető");
                        specialityGroups.Items.Add("Gépház foglalkoztatási segédelőadó");
                        specialityGroups.Items.Add("Gépház művezető");
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
                        break;
                    }
                case "Gazdasági társaság":
                    {
                        specialityGroups.Items.Add("Munkáltatási biztonsági vezető");
                        specialityGroups.Items.Add("Biztonsági vezető");
                        specialityGroups.Items.Add("Munkaügyi előadó");
                        specialityGroups.Items.Add("Titkárság");
                        specialityGroups.Items.Add("Igazgatóság");
                        specialityGroups.Items.Add("Tűz és munkavédelmi vezető");
                        specialityGroups.Items.Add("Sales Manager");
                        specialityGroups.Items.Add("Művezető");
                        specialityGroups.Items.Add("Mosodavezető");
                        specialityGroups.Items.Add("Kiemelt művezető");
                        specialityGroups.Items.Add("Kereskedelmi vezető");
                        specialityGroups.Items.Add("Gépjárművezető");
                        specialityGroups.Items.Add("Foglalkoztatási segédelőadó");
                        specialityGroups.Items.Add("Foglalkoztatási felügyelő");
                        specialityGroups.Items.Add("Bolt vezető");
                        specialityGroups.Items.Add("Bolti eladó");
                        break;
                    }
                case "Informatikai osztály":
                    {
                        specialityGroups.Items.Add("Informatikai osztályvezető");
                        specialityGroups.Items.Add("Informatikai főelőadó");
                        specialityGroups.Items.Add("Informatikai előadó");
                        specialityGroups.Items.Add("Biztonságtechnikus");
                        break;
                    }
                case "Személyügyi és szociális osztály":
                    {
                        specialityGroups.Items.Add("Személyügyi osztályvezető");
                        specialityGroups.Items.Add("Személyügyi főelőadó");
                        specialityGroups.Items.Add("Személyügyi előadó");
                        specialityGroups.Items.Add("Személyügyi segédelőadó");
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
                case "Vezetőség":
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
                        specialityGroups.Items.Add("Kártalantási előadó");
                        specialityGroups.Items.Add("Lelkész");
                        specialityGroups.Items.Add("Pszichológus");
                        specialityGroups.Items.Add("Előadó");
                        break;
                    }
                default:
                    break;
            }
        }
    }
}