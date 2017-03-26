namespace Promotion.Core
{
    public class GetData
    {
        private IData _repo;

        public GetData(IData repo) { _repo = repo; }

        public Blog LoadData(string Connectionstring)
        {
            var original = _repo.LoadData(Connectionstring);
            return original;
        }
    }
}
