using System;
using System.IO;


namespace R5T.NetStandard.IO
{
    public static class StringReaderExtensions
    {
        public static bool ReadLineIsEnd(this StringReader stringReader, out string line)
        {
            var output = StringReaderHelper.ReadLine(stringReader, out line);
            return output;
        }
    }
}
