namespace InterfaceExample.Core
{
    public class GetData
    {
        private IData _repo;

        public GetData(IData repo)
        {
            this._repo = repo;
        }

        public Blog LoadData(string connectionstring)
        {
            var original = this._repo.LoadData(connectionstring);
            return original;
        }

        public int FindData(string value, Blog blog)
        {
            return this._repo.FindData(value, blog);
        }
    }
}
