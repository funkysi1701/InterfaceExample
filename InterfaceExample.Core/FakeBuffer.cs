namespace Promotion.Core
{
    public class FakeBuffer : ISocial
    {
        public string Add(string content, string type, string token)
        {
            return "RanToCompletion";
        }
    }
}
