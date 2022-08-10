namespace SKFB_ISZR.Tools
{
    internal class RankConverter
    {
        /*
         *  munkavállaló - mv.
            rendvédelmi-alkalmazott - ra.
            őrmester - őrm.
            törzsörmester - tőrm.
            főtörzsörmester - ftőrm.
            zászlós - zls.
            törzszászlós - tzls.
            főtörzszászlós - ftzls.
            hadnagy - hdgy.
            főhadnagy - fhdgy.
            százados - szds.
            őrnagy - őrgy.
            alezredes - alez.
            ezredes - ezds.
            dandártábornok - ddtbk.
            vezérőrnagy - vőrgy.
            altábornagy - altbgy.
        */

        public static string GetShortRank(string longRank)
        {
            switch (longRank)
            {
                case "munkavállaló":
                    {
                        return "mv.";
                    }
                case "rendvédelmi-alkalmazott":
                    {
                        return "ra.";
                    }
                case "őrmester":
                    {
                        return "őrm.";
                    }
                case "törzsörmester":
                    {
                        return "tőrm.";
                    }
                case "főtörzsörmester":
                    {
                        return "ftőrm.";
                    }
                case "zászlós":
                    {
                        return "zls.";
                    }
                case "törzszászlós":
                    {
                        return "tzls.";
                    }
                case "főtörzszászlós":
                    {
                        return "ftzls.";
                    }
                case "hadnagy":
                    {
                        return "hdgy.";
                    }
                case "főhadnagy":
                    {
                        return "fhdgy.";
                    }
                case "százados":
                    {
                        return "szds.";
                    }
                case "őrnagy":
                    {
                        return "őrgy.";
                    }
                case "alezredes":
                    {
                        return "alez.";
                    }
                case "ezredes":
                    {
                        return "ezds.";
                    }
                case "dandártábornok":
                    {
                        return "ddtbk.";
                    }
                case "vezérőrnagy":
                    {
                        return "vőrgy.";
                    }
                case "altábornagy":
                    {
                        return "altbgy.";
                    }
                default:
                    {
                        return " ";
                    }
            }
        }
    }
}