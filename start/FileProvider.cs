using System;
using System.Collections.Generic;
using System.Text;

namespace start
{
    public class FileProvider
    {
        internal static void Replace(string path, string value)
        {
            var dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            var writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }

        public static string GetValue(string path)
        {
            var reader = new StreamReader(path, Encoding.UTF8);
            var fileData = reader.ReadToEnd();
            reader.Close();
            return fileData;
        }

        public static bool Exists(string path)
        {
            return File.Exists(path);
        }
    }
}
