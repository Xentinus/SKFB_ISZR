using Microsoft.Office.Interop.Word;
using System;
using System.Reflection;

using Word = Microsoft.Office.Interop.Word;

namespace SKFB_ISZR.Tools
{
    internal class DocumentEditor
    {
        // WORD szerkesztőnek fix deklarálásai
        private static object PDFformat = WdSaveFormat.wdFormatPDF;

        private static object missing = Missing.Value;
        private static object readOnly = false;
        private static readonly object isVisible = false;

        // Felhasználó alap adatai
        public static string lastName = string.Empty;

        public static string firstName = string.Empty;
        public static string rank = string.Empty;
        public static string username = string.Empty;
        public static string specialty = string.Empty;
        public static string post = string.Empty;
        public static string office = string.Empty;
        public static string ntg = string.Empty;

        // Kamera jogosultság igényléséhez
        public static string generatedUsername = string.Empty;

        // Kamera jgoosultság és Windows jogosultság igényléséhez
        public static string permissionType = string.Empty;

        public static string permissionList = string.Empty;

        // Windows jogosultság igényléséhez
        public static string group = string.Empty;

        // FŐNIX3 jogosultság igényléséhez
        public static string specialitys = string.Empty;

        public static string localPermissions = string.Empty;
        public static string nationPermissions = string.Empty;

        // Parkolási engedély kéréséhez
        public static string carType = string.Empty;

        public static string carBrand = string.Empty;
        public static string carModell = string.Empty;
        public static string licensePlace = string.Empty;

        // PIN kód kiállításához
        public static string generatedPIN = string.Empty;

        // Kamerakép lementéséhez
        public static string recordReason = string.Empty;

        public static string recordLineCount = string.Empty;
        public static string recordCameraName = string.Empty;
        public static string recordTimeStart = string.Empty;
        public static string recordTimeEnd = string.Empty;

        // Kijelölt ügyintéző neve
        public static string fullName = string.Empty;

        // Javasló osztályvezető neve és osztályának neve
        public static string classLeaderName = string.Empty;

        public static string classLeaderRole = string.Empty;

        // Megkeresi az összes hasonló értéket majd kicseréli az új értékre
        private static void FindAndReplaceAllShortItem(Application wordApp, object findMe, object replaceMe)
        {
            try
            {
                object replaceAll = WdReplace.wdReplaceAll;
                object missing = Missing.Value;
                wordApp.Application.Selection.Find.ClearFormatting();
                wordApp.Application.Selection.Find.Text = (string)findMe;
                wordApp.Application.Selection.Find.Replacement.ClearFormatting();

                wordApp.Application.Selection.Find.Replacement.Text = (string)replaceMe;
                wordApp.Application.Selection.Find.Execute(
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref replaceAll,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Megkeresi az elkönyvelt érték helyét majd kicseréli az újra (hosszú stringek miatt ez jobb)
        private static void FindAndReplaceBookmarkedItem(Document wordDoc, object findMe, object replaceMe)
        {
            try
            {
                wordDoc.Bookmarks.get_Item(ref findMe).Range.Text = (string)replaceMe;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Elkészíti az új dokumentumot
        public static void Create(object filename, object SaveAs, string ServiceName)
        {
            Application wordApp = new Application();
            Document myWordDoc = null;
            wordApp.Visible = false;

            // Alap dokumentum megnyítása
            myWordDoc = wordApp.Documents.Open(
                ref filename,
                ref missing,
                ref readOnly,
                ref missing,
                ref missing,
                ref missing,
                ref missing,
                ref missing,
                ref missing,
                ref missing,
                ref missing,
                ref missing,
                ref missing,
                ref missing,
                ref missing,
                ref missing);

            myWordDoc.Activate();

            // Felhasználó alap adatai
            FindAndReplaceAllShortItem(wordApp, "<lastName>", lastName);
            FindAndReplaceAllShortItem(wordApp, "<firstName>", firstName);
            FindAndReplaceAllShortItem(wordApp, "<rank>", rank);
            FindAndReplaceAllShortItem(wordApp, "<specialty>", specialty);
            FindAndReplaceAllShortItem(wordApp, "<office>", office);
            FindAndReplaceAllShortItem(wordApp, "<ntg>", ntg);
            FindAndReplaceAllShortItem(wordApp, "<fullName>", SignatureEditor.GetUserRankSignature(fullName)); // Felhasználó neve

            SignatureEditor.GetClassLeaderSignature(specialty);
            FindAndReplaceAllShortItem(wordApp, "<classLeader>", classLeaderName); // Osztályvezető neve
            FindAndReplaceAllShortItem(wordApp, "<classLeaderRole>", classLeaderRole); // Osztályvezető osztálya

            // Teljesen alap FIX értékek

            // Csoport / Beosztás
            if (ServiceName != "Windows")
            {
                FindAndReplaceAllShortItem(wordApp, "<post>", post);
            }
            else
            {
                FindAndReplaceAllShortItem(wordApp, "<group>", group);
            }

            // Felhasználónév
            if (ServiceName == "Email" || ServiceName == "Windows" || ServiceName == "Fonix") FindAndReplaceAllShortItem(wordApp, "<username>", username);

            // Generált felhasználónév
            if (ServiceName == "CameraPermissions") FindAndReplaceAllShortItem(wordApp, "<generatedUsername>", generatedUsername);

            // Generált PIN kód
            if (ServiceName == "PIN") FindAndReplaceAllShortItem(wordApp, "<generatedPIN>", generatedPIN);

            // Jogosultsági tipus
            if (ServiceName == "Windows" || ServiceName == "CameraPermissions" || ServiceName == "Fonix") FindAndReplaceAllShortItem(wordApp, "<permissionType>", permissionType);

            // Jogosultsági lista
            if (ServiceName == "Windows" || ServiceName == "CameraPermissions") FindAndReplaceBookmarkedItem(myWordDoc, "permissionList", permissionList);

            // Főnix Szakterületek, intézeti hozzáférések, országos hozzáférések
            if (ServiceName == "Fonix")
            {
                FindAndReplaceBookmarkedItem(myWordDoc, "specialitys", specialitys);
                FindAndReplaceBookmarkedItem(myWordDoc, "localPermissions", localPermissions);
                FindAndReplaceBookmarkedItem(myWordDoc, "nationPermissions", nationPermissions);
            }

            // Parkoló autó információi
            if (ServiceName == "Parking")
            {
                FindAndReplaceAllShortItem(wordApp, "<carType>", carType);
                FindAndReplaceAllShortItem(wordApp, "<carBrand>", carBrand);
                FindAndReplaceAllShortItem(wordApp, "<carModell>", carModell);
                FindAndReplaceAllShortItem(wordApp, "<licensePlate>", licensePlace);
            }

            // Kaerakép lementése
            if (ServiceName == "CameraRecord")
            {
                FindAndReplaceAllShortItem(wordApp, "<date>", LoadingSplashScreen.dayToday);
                FindAndReplaceBookmarkedItem(myWordDoc, "recordReason", recordReason);
                FindAndReplaceBookmarkedItem(myWordDoc, "recordLineCount", recordLineCount);
                FindAndReplaceBookmarkedItem(myWordDoc, "recordCameraName", recordCameraName);
                FindAndReplaceBookmarkedItem(myWordDoc, "recordTimeStart", recordTimeStart);
                FindAndReplaceBookmarkedItem(myWordDoc, "recordTimeEnd", recordTimeEnd);
            }

            try
            {
                // Átszerkesztett dokumentum elmentése PDFként
                myWordDoc.SaveAs2(
                    ref SaveAs,
                    ref PDFformat,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing,
                    ref missing);
            }
            finally
            {
                // Alap dokumentum bezárása mentés nélkül
                myWordDoc.Close(ref readOnly);

                // Office bezárása mentés nélkül
                wordApp.Quit(ref readOnly);
            }
        }
    }
}