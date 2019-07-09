using System;
using System.IO;


namespace R5T.NetStandard.IO
{
    public static class StringReaderHelper
    {
        public const string EndOfString = null;


        public static bool ReadLine(StringReader stringReader, out string line)
        {
            line = stringReader.ReadLine();

            var isEnd = line == StringReaderHelper.EndOfString;
            return isEnd;
        }
    }
}
