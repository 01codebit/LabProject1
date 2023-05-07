using System.Threading.Tasks;
using System.Net.Http;
using UnityEngine;

public class AsyncLoader : MonoBehaviour
{
    // HttpClient is intended to be instantiated once per application.
    static readonly HttpClient client = new HttpClient();
    
    public async Task<string> DoPostRequest(string url, string body)
    {
        string result;

        // Call asynchronous network methods in a try/catch block to handle exceptions.
        try
        {            
            Debug.Log($"[AsyncLoader.DoPostRequest] url: {url} - body: {body}");
            using HttpResponseMessage response = await client.PostAsync(url, new StringContent(body));
            response.EnsureSuccessStatusCode();

            Debug.Log($"[AsyncLoader.DoPostRequest] reading response content...");
            string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);

            Debug.Log($"[AsyncLoader.DoPostRequest] response: {responseBody}");
            result = responseBody;
        }
        catch (HttpRequestException e)
        {
            result = $"***ERROR*** message: {e.Message}";
            Debug.LogError(result);
        }

        return result;
    }

    public async Task<string> DoGetRequest(string url)
    {
        string result;

        // Call asynchronous network methods in a try/catch block to handle exceptions.
        try
        {            
            Debug.Log($"[AsyncLoader.DoGetRequest] url: {url}");
            using HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            Debug.Log($"[AsyncLoader.DoGetRequest] reading response content...");
            string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);

            Debug.Log($"[AsyncLoader.DoGetRequest] response: {responseBody}");
            result = responseBody;
        }
        catch (HttpRequestException e)
        {
            result = $"***ERROR*** message: {e.Message}";
            Debug.LogError(result);
        }

        return result;
    }

}
