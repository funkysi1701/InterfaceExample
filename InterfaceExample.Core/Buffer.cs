using BufferAPI;
using System.Linq;

namespace Promotion.Core
{
    public class Buffer : ISocial
    {
        public string Add(string content,string type, string token)
        {
            var service = new BufferService(token);
            var profileResult = service.GetProfiles();

            var allProfiles = profileResult.Result;
            var SocialProfile = allProfiles.Content.Where(y => y.Service == type);

            var response = service.PostUpdate(content, SocialProfile);
            var p = response.Result;
            string result = response.Status.ToString();
            return result;
        }
    }
}
