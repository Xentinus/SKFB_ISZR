namespace SKFB_ISZR.Tools
{
    // Központi ellenőrző
    internal class SummaryChecker
    {
        // Kapott adatok ellenőrzése
        public static bool CheckDatas(params string[] summaryDatas)
        {
            foreach (string summaryData in summaryDatas)
            {
                if (string.IsNullOrWhiteSpace(summaryData)) return false;
            }
            return true;
        }
    }
}