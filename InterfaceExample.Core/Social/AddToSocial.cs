namespace InterfaceExample.Core
{
    public class AddToSocial
    {
        private ISocial _repo;

        public AddToSocial(ISocial repo)
        {
            this._repo = repo;
        }

        public string Add(string content, string type, string token)
        {
            var original = this._repo.Add(content, type, token);
            return original;
        }

        public string ComposeMessage(Post post)
        {
            string answer = string.Empty;
            answer = answer + post.Title + " " + post.Url + " ";
            foreach (var tag in post.Tags)
            {
                answer = answer + "#" + tag.Replace(" ", string.Empty) + ", ";
            }

            return answer.Remove(answer.Length - 2);
        }
    }
}
