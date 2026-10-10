// See https://aka.ms/new-console-template for more information
using System.Net.Http.Json;
using ServerCs;
using System.Runtime.InteropServices;

var client = new HttpClient();

var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
Console.WriteLine(response);

if (response.IsSuccessStatusCode)
{
    Console.WriteLine("Response received successfully.");
}
else
{
    Console.WriteLine("No response received.");
}


var post = await response.Content.ReadFromJsonAsync<List<Post>>();


for(int i = 10; i < 15; i++)
{
    Console.WriteLine($"O conteudo eh : {post[i].body} e o id eh : { post[i].id}:");

    Console.WriteLine();
}