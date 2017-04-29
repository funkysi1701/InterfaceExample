namespace InterfaceExample.Core
{
    public class FileLog
    {
        private ILogger _repo;

        public FileLog(ILogger repo)
        {
            this._repo = repo;
        }

        public void Write(string content, string path)
        {
            this._repo.WriteLog(content, path);
        }

        public string Read(string path)
        {
            return this._repo.ReadLog(path);
        }
    }
}
