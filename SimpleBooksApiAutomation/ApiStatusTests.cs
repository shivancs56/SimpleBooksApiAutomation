using RestSharp;
using NUnit.Framework;

[TestFixture]
public class ApiStatusTests
{
    [Test]
    public void CheckApiStatus()
    {
        var client = new RestClient("https://simple-books-api.click");
        var request = new RestRequest("/status", Method.Get);
        var response = client.Execute(request);

        Assert.That((int)response.StatusCode, Is.EqualTo(200));
        Console.WriteLine(response.Content); // Output: {"status":"OK"}
    }
}