using System;
using System.IO;
using System.Text;


namespace R5T.NetStandard.IO
{
    public static class StreamHelper
    {
        public static Stream FromString(string value)
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(value));
            return stream;
        }
    }
}
