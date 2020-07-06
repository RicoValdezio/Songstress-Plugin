﻿using UnityEngine;

namespace SongstressPlugin
{
    class IntonerColors
    {
        internal static Color ZeroColor = new Color(0.988281f, 0.609375f, 0.699218f); //#FD9CB3
        internal static Color OneColor = new Color(0.910156f, 0.3515625f, 0.535156f); //#E95A89
        internal static Color TwoColor = new Color(0.171875f, 0.535156f, 0.738281f); //#2C89BD
        internal static Color ThreeColor = new Color(0.785156f, 0.347656f, 0.921875f); //#C959EC
        internal static Color FourColor = new Color(0.070312f, 0.683593f, 0.593750f); //#12AF98
        internal static Color FiveColor = new Color(0.628906f, 0.593750f, 0.480469f); //#A1987B
        internal static Color ChosenColor;

        internal static string ZeroString = "<color=#FD9CB3>";
        internal static string OneString = "<color=#E95A89>";
        internal static string TwoString = "<color=#2C89BD>";
        internal static string ThreeString = "<color=#C959EC>";
        internal static string FourString = "<color=#12AF98>";
        internal static string FiveString = "<color=#A1987B>";
        internal static string ChosenString;

        internal static void Init()
        {
            if (Random.Range(1, 100) >= 95)
            {
                switch (Random.Range(1, 5))
                {
                    case 1:
                        ChosenColor = OneColor;
                        ChosenString = OneString;
                        break;
                    case 2:
                        ChosenColor = TwoColor;
                        ChosenString = TwoString;
                        break;
                    case 3:
                        ChosenColor = ThreeColor;
                        ChosenString = ThreeString;
                        break;
                    case 4:
                        ChosenColor = FourColor;
                        ChosenString = FourString;
                        break;
                    case 5:
                        ChosenColor = FiveColor;
                        ChosenString = FiveString;
                        break;
                }
            }
            ChosenColor = ZeroColor;
            ChosenString = ZeroString;
        }
    }
}
