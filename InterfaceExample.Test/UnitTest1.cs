using NUnit.Framework;
using InterfaceExample.Core;
using System.Configuration;

namespace InterfaceExample.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void CreateModel()
        {
            Post post1 = new Post();
            post1.Title = "Test Driven Development or TDD";
            post1.Url = "https://www.funkysi1701.com/2017/03/12/test-driven-development-tdd/";
            post1.Tags.Add("csharp");
            post1.Tags.Add("TDD");
            Post post2 = new Post();
            post2.Title = "Github Vs Bitbucket Vs Visual Studio Team Services";
            post2.Url = "https://www.funkysi1701.com/2017/03/04/github-vs-bitbucket-vs-vsts/";
            post2.Tags.Add("csharp");
            post2.Tags.Add("TDD");
            Blog blog = new Blog();
            blog.Posts.Add(post1);
            blog.Posts.Add(post2);
            Assert.AreEqual("TDD", blog.Posts[0].Tags[1].ToString());
            Assert.AreEqual("TDD", post1.Tags[1].ToString());
        }

        [Test]
        public void GetDataFromXML()
        {
            GetData db = new GetData(new XML());
            Blog blog = db.LoadData(ConfigurationManager.AppSettings["WebsiteURL"]);
            Assert.AreEqual(118, blog.Posts.Count);
            Assert.AreEqual("SOLID and other programming terms",blog.Posts[0].Title);
            Assert.AreEqual("Imposter Syndrome", blog.Posts[10].Title);
            Assert.AreEqual("Laziness", blog.Posts[100].Title);
            Assert.AreEqual("I love Nagios", blog.Posts[117].Title);
        }

        [Test]
        public void GetDataFromSQL()
        {
            GetData db = new GetData(new SQL());
            Blog blog = db.LoadData(ConfigurationManager.AppSettings["ConnectionString"]);
            Assert.AreEqual("SOLID and other programming terms", blog.Posts[0].Title);
            Assert.AreEqual("Imposter Syndrome", blog.Posts[1].Title);
        }
        [Test]
        public void SendDataToBuffer()
        {
            XML x = new XML();
            Blog blog = x.LoadData(ConfigurationManager.AppSettings["WebsiteURL"]);
            var message = blog.Posts[0].Title + " " + blog.Posts[0].Url;
            AddToSocial b = new AddToSocial(new FakeBuffer());
            string output = b.Add(message, "twitter", ConfigurationManager.AppSettings["BufferKey"]);
            Assert.AreEqual("RanToCompletion", output);
        }
    }
}
