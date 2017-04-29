using System.IO;

namespace InterfaceExample.Core
{
    public class FileLogger : ILogger
    {
        public void WriteLog(string data, string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(data);
            }
        }

        public string ReadLog(string path)
        {
            string lastline = string.Empty;
            if (File.Exists(path))
            {
                foreach (var item in File.ReadLines(path))
                {
                    lastline = item;
                }
            }

            return lastline;
        }
    }
}
