namespace InterfaceExample.Core
{
    public interface ILogger
    {
        void WriteLog(string data, string path);

        string ReadLog(string path);
    }
}
