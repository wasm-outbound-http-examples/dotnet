using System;
using RestSharp;

var options = new RestClientOptions()
{
    Timeout = TimeSpan.FromSeconds(10)
};
var client = new RestClient(options);
var req = new RestRequest("https://httpbin.org/anything");
var res = await client.ExecuteGetAsync(req);

Console.WriteLine("text: " + res.Content);
