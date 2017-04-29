using System.Configuration;

namespace InterfaceExample.Core
{
    public class RunApp
    {
        public void CreateContent(string social)
        {
            FileLog log = new FileLog(new FileLogger());
            string FilePath = ConfigurationManager.AppSettings[social];
            string value = log.Read(FilePath);
            GetData db = new GetData(new XML());
            Blog blog = db.LoadData(ConfigurationManager.AppSettings["WebsiteURL"]);
            int id = db.FindData(value, blog);
            id++;
            AddToSocial b = new AddToSocial(new Buffer());
            string message = b.ComposeMessage(blog.Posts[id]);
            string output = b.Add(message, social, ConfigurationManager.AppSettings["BufferKey"]);
            if (output != "Forbidden" && output != "Bad Request") log.Write(blog.Posts[id].Title, ConfigurationManager.AppSettings[social]);
        }
    }
}
