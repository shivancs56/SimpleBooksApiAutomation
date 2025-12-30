using RestSharp;
using NUnit.Framework;

namespace SimpleBooksApiAutomation
{
    public class SubmitOrderTests
    {
        [Test]
        public void SubmitBookOrder()
        {
            var client = new RestClient("https://simple-books-api.click");
            var request = new RestRequest("/orders", Method.Post);

            // Auth Token yahan dalo (Bearer Token)
            string myToken = "623b437b02c153fe48dec7cb40ea024927b0a9f58b2a0e8010ac602c2e304bf5";
            request.AddHeader("Authorization", "Bearer " + myToken);

            request.AddJsonBody(new { bookId = 1, customerName = "Shivam" });

            var response = client.Execute(request);
            Assert.That((int)response.StatusCode, Is.EqualTo(201));
        }
    }
}