using PresentationTimekeeper.Dto;

namespace PresentationTimekeeper.Util
{
    public static class Utility
    {
        public static string SubstringFromRight(string str, int length)
        {
            return str.Substring(str.Length - length, length);
        }

        public static int ConvertHms2Sec(int hour, int minute, int second)
        {
            return hour * 60 * 60 + minute * 60 + second;
        }

        public static HmsInt Second2HmsInt(int second)
        {
            return new HmsInt
            {
                Hour = second / (60 * 60),
                Minute = (second % (60 * 60)) / 60,
                Second = second % 60
            };
        }

        public static HmsString Second2HmsString(int second)
        {
            var hmsInt = Second2HmsInt(second);

            return new HmsString
            {
                Hour = SubstringFromRight($"0{hmsInt.Hour}", 2),
                Minute = SubstringFromRight($"0{hmsInt.Minute}", 2),
                Second = SubstringFromRight($"0{hmsInt.Second}", 2)
            };
        }
    }
}
