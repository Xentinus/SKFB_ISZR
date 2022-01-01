using System;

namespace SKFB_ISZR
{
    // Központi ellenőrző
    internal class SummaryChecker
    {
        // Kapott adatok ellenőrzése
        public static bool CheckDatas(params string[] summaryDatas)
        {
            foreach (string summaryData in summaryDatas)
            {
                if (String.IsNullOrWhiteSpace(summaryData)) return false;
            }
            return true;
        }
    }
}