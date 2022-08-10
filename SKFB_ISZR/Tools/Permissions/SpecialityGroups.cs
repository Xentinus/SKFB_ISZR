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
                        specialityGroups.Items.Add("Biztonsági osztályvezető helyettes");
                        specialityGroups.Items.Add("Biztonsági tiszt"); // TODO: átnevzve
                        specialityGroups.Items.Add("Biztonsági főfelügyelő"); // TODO: átnevezve
                        specialityGroups.Items.Add("Biztonsági felügyelő"); // TODO: átnevezve
                        specialityGroups.Items.Add("Fegyveres biztonsági őr");
                        specialityGroups.Items.Add("Kutyatelep-vezető");
                        specialityGroups.Items.Add("Kutyavezető"); // TODO: átnevezve
                        specialityGroups.Items.Add("Müveleti csoport");
                        specialityGroups.Items.Add("Fegyvermester");
                        specialityGroups.Items.Add("Szállításvezető");
                        specialityGroups.Items.Add("Titkárság"); // megnézni kell e még
                        specialityGroups.Items.Add("Segédelőadó"); // TODO: új altípus
                        specialityGroups.Items.Add("Előadó"); // TODO: új altípus horváth kata
                        specialityGroups.Items.Add("Körlet felügyelők"); // TODO: áthelyezése a bv osztályból
                        specialityGroups.Items.Add("Körlet főfelügyelők"); // TODO: áthelyezése a bv osztályból
                        break;
                    }
                case "Büntetés-végrehajtási osztály":
                    {
                        specialityGroups.Items.Add("Büntetés-végrehajtási osztályvezető");
                        specialityGroups.Items.Add("Büntetés-végrehajtási osztályvezető-helyettes");
                        specialityGroups.Items.Add("Nyilvántartó előadó"); // TODO: átnevezésre került
                        specialityGroups.Items.Add("Nyilvántartó segédelőadó"); // TODO: új altípus
                        specialityGroups.Items.Add("Körlet ellátó főfelügyelő"); // TODO: átnevezve
                        specialityGroups.Items.Add("Körlet ellátó segédelőadó"); // TODO: átnevezve
                        specialityGroups.Items.Add("Vezető Reintegrációs tiszt");
                        specialityGroups.Items.Add("Reintegraciós tiszt"); // TODO: átnevezve
                        specialityGroups.Items.Add("Szociális segédelőadó"); // TODO: átnevezve
                        specialityGroups.Items.Add("Pártfogó felügyelő"); // TODO: átnevezve
                        break;
                    }
                case "EFOP":
                    {
                        specialityGroups.Items.Add("Csoportvezető");
                        specialityGroups.Items.Add("Pályázati tanácsadó"); // TODO: átnevezve
                        break;
                    }
                case "Egészségügyi osztály":
                    {
                        specialityGroups.Items.Add("Egészségügyi osztályvezető");
                        specialityGroups.Items.Add("Főápoló"); // TODO: átnevezve
                        specialityGroups.Items.Add("Orvos"); // TODO: átnvezve
                        specialityGroups.Items.Add("Orvos asszisztens"); // TODO: átnevezve
                        specialityGroups.Items.Add("Szakápoló"); // TODO: átnevezve
                        specialityGroups.Items.Add("Előadó"); // TODO: átnevezve
                        break;
                    }
                case "Gazdasági osztály":
                    {
                        specialityGroups.Items.Add("Gazdasági vezető");
                        specialityGroups.Items.Add("Gazdasági osztályvezető"); // TODO: új altípus
                        specialityGroups.Items.Add("Gazdasági osztályvezető-helyettes"); // TODO: új altípus
                        specialityGroups.Items.Add("Anyaggazdálkodási főelőadó");
                        specialityGroups.Items.Add("Gépház raktáros"); // TODO: átnevezve
                        specialityGroups.Items.Add("Gépház vezető"); // TODO: átnevezve
                        specialityGroups.Items.Add("Gépjárművezető"); // TODO: átnevezve
                        specialityGroups.Items.Add("Műszaki csoport");
                        specialityGroups.Items.Add("Pénzügyi csoport");
                        specialityGroups.Items.Add("Pénztáros"); // TODO: átnevezve
                        specialityGroups.Items.Add("Számviteli csoport");
                        specialityGroups.Items.Add("Élelmezési csoport");
                        specialityGroups.Items.Add("Takarító"); // TODO: új altípus
                        specialityGroups.Items.Add("Raktárvezető"); // TODO: új altípus
                        specialityGroups.Items.Add("Raktáros"); // TODO: átnevezve
                        specialityGroups.Items.Add("Gondnok");  // TODO: új altípus
                        break;
                    }
                case "Gazdasági társaság":
                    {
                        specialityGroups.Items.Add("Munkáltatási biztonsági vezető"); // TODO: új altípus
                        specialityGroups.Items.Add("Biztonsági vezető");
                        specialityGroups.Items.Add("Munkaügyi csoport");
                        specialityGroups.Items.Add("Titkárság");
                        specialityGroups.Items.Add("Igazgatóság");
                        specialityGroups.Items.Add("Tűz és munkavédelmi vezető"); // TODO: új altípus
                        specialityGroups.Items.Add("Sales Manager"); // TODO: új altípus
                        specialityGroups.Items.Add("Művezető"); // TODO: új altípus
                        specialityGroups.Items.Add("Mosodavezető"); // TODO: új altípus
                        specialityGroups.Items.Add("Kiemelt művezető"); // TODO: új altípus
                        specialityGroups.Items.Add("Kereskedelmi vezető"); // TODO: új altípus
                        specialityGroups.Items.Add("Gépjárművezető"); // TODO: új altípus
                        specialityGroups.Items.Add("Foglalkoztatási segédelőadó"); // TODO: új altípus
                        specialityGroups.Items.Add("Foglalkoztatási felügyelő"); // TODO: új altípus
                        specialityGroups.Items.Add("Bolt vezető"); // TODO: új altípus
                        specialityGroups.Items.Add("Bolti eladó"); // TODO: új altípus
                        break;
                    }
                case "Informatikai osztály":
                    {
                        specialityGroups.Items.Add("Informatikai osztályvezető");
                        specialityGroups.Items.Add("Informatikai főelőadó"); // TODO: új altípus
                        specialityGroups.Items.Add("Informatikai előadó"); // TODO: átnevezve
                        specialityGroups.Items.Add("Biztonságtechnikus"); // TODO: átnevezve
                        break;
                    }
                case "Személyügyi és szociális osztály":
                    {
                        specialityGroups.Items.Add("Személyügyi és szervezési osztályvezető");
                        specialityGroups.Items.Add("Személyügyi főelőadó"); // TODO: új altípus
                        specialityGroups.Items.Add("Személyügyi előadó"); // TODO: átnevezve
                        specialityGroups.Items.Add("Személyügyi segédelőadó"); // TODO: újaltípus
                        specialityGroups.Items.Add("Ügykezelő"); // TODO: átnevezve
                        break;
                    }
                case "Ügyészség":
                    {
                        specialityGroups.Items.Add("Katonai ügyész"); // TODO: átnevezve
                        specialityGroups.Items.Add("Ügyészségi fogalmazó"); // TODO: új altípus
                        break;
                    }
                case "Nemzeti Védelmi Szolgálat":
                    {
                        specialityGroups.Items.Add("Kiemelt nyomozó"); // TODO: új altípus
                        specialityGroups.Items.Add("Főelőadó"); // TODO: új altípus
                        specialityGroups.Items.Add("Előadó"); // TODO: új altípus
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
                        specialityGroups.Items.Add("Belső ellenőr"); // TODO: átnevezve
                        specialityGroups.Items.Add("Jogtanácsos"); // TODO: átnevezve
                        specialityGroups.Items.Add("Kártalantási előadó"); // TODO: átnevezve
                        specialityGroups.Items.Add("Lelkész"); // TODO: átnevezve
                        specialityGroups.Items.Add("Pszichológus"); // TODO: átnevezve
                        specialityGroups.Items.Add("Előadó"); // TODO: átnevezve
                        break;
                    }
                default:
                    break;
            }
        }
    }
}