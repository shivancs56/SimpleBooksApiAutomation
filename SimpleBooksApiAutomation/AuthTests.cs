using RestSharp;
using NUnit.Framework;
using System; =

namespace SimpleBooksApiAutomation
{
    [TestFixture] 
    public class AuthTests
    {
        [Test] 
        public void RegisterClient()
        {
            var client = new RestClient("https://simple-books-api.click");
            var request = new RestRequest("/api-clients/", Method.Post);

            request.AddJsonBody(new
            {
                clientName = "ShivamQA",
                clientEmail = "shivam_test893@example.com" 
            });

            var response = client.Execute(request);
            Console.WriteLine("Tera Access Token: " + response.Content);

            // Assertion 
            Assert.That((int)response.StatusCode, Is.EqualTo(201).Or.EqualTo(409));
            
        }
    }
}