using System;
using System.Net.Http;

HttpClient client = new HttpClient();
string uri = "https://httpbin.org/anything";
string responseText = await client.GetStringAsync(uri);

Console.WriteLine("body: " + responseText);
