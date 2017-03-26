namespace Promotion.Core
{
    public class AddToSocial
    {
        private ISocial _repo;

        public AddToSocial(ISocial repo) { _repo = repo; }

        public string Add(string content, string type, string token)
        {
            var original = _repo.Add(content, type, token);
            return original;
        }
    }
}
