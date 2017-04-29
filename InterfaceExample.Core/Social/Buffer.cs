using BufferAPI;
using System.Linq;

namespace InterfaceExample.Core
{
    public class Buffer : ISocial
    {
        public string Add(string content, string type, string token)
        {
            var service = new BufferService(token);
            var profileResult = service.GetProfiles();

            var allProfiles = profileResult.Result;
            var socialProfile = allProfiles.Content.Where(y => y.Service == type);
            if (type == "twitter" && content.Length > 140) content = content.Substring(0, 140);
            var response = service.PostUpdate(content, socialProfile);
            var p = response.Result;
            string result = p.Response.ReasonPhrase;
            return result;
        }
    }
}
