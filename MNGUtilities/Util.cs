using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MNG.Utilities
{
    public static class Util
    {
        public static void AppendFile(string fileName, params object[] data)
        {
            if (data == null) return;
            if (data.Length == 0) return;

            var text = string.Join(",", data ) + Environment.NewLine;

            File.AppendAllText(fileName, text);
        }

    }
}
