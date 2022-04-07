using Main.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Team!!");

            var objInput = new CreditAmountInputModel();

            Console.Write("Enter the credit amount: ");
            objInput.creditAmount = Console.ReadLine();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44349/api/Rate");

            var byteContent = getByteContent(JsonConvert.SerializeObject(objInput));
            var resWithToken = client.PostAsync("", byteContent).Result;
            var result = resWithToken.Content.ReadAsStringAsync().Result;

            Console.WriteLine(result);
        }

        private static ByteArrayContent getByteContent(string collectValue)
        {
            var buffer = System.Text.Encoding.UTF8.GetBytes(collectValue);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return byteContent;
        }
    }
}
