namespace cicd.Tests;
using System.Net.Http;


public class UnitTest1
{
    [Fact]
    public async void TestAddWorks()
    {
        string URL = "https://localhost:5001/add?x=3&y=5";
        //         var handler = new HttpClientHandler();
        // handler.ClientCertificateOptions = ClientCertificateOption.Manual;
        // handler.ServerCertificateCustomValidationCallback = 
        //     (httpRequestMessage, cert, cetChain, policyErrors) =>
        // {
        //     return true;
        // };

        var client = new HttpClient(/*handler*/);

        HttpResponseMessage response = await client.GetAsync(URL);

        int resultInt = Convert.ToInt32(response.Content.ReadAsStringAsync().Result);

        Assert.Equal(8, resultInt);
    }
}