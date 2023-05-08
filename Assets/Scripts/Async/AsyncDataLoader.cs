using System.Threading.Tasks;
using System.Net.Http;
using UnityEngine;

public class AsyncDataLoader : MonoBehaviour
{
    // HttpClient is intended to be instantiated once per application.
    static readonly HttpClient client = new HttpClient();

    public async Task<string> DoPostRequest(string url, string body)
    {
        ThreadFunctions.ShowThreadInformation("AsyncDataLoader.DoPostRequest (Task #" + Task.CurrentId.ToString() + ")");
        string result;

        // Call asynchronous network methods in a try/catch block to handle exceptions.
        try
        {
            Debug.Log($"[AsyncDataLoader.DoPostRequest] url: {url} - body: {body}");
            using HttpResponseMessage response = await client.PostAsync(url, new StringContent(body));
            response.EnsureSuccessStatusCode();

            Debug.Log("[AsyncDataLoader.DoPostRequest] reading response content...");
            string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);

            Debug.Log($"[AsyncDataLoader.DoPostRequest] response: {responseBody}");
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
        ThreadFunctions.ShowThreadInformation("AsyncDataLoader.DoGetRequest (Task #" + Task.CurrentId.ToString() + ")");
        string result;

        // Call asynchronous network methods in a try/catch block to handle exceptions.
        try
        {
            Debug.Log($"[AsyncDataLoader.DoGetRequest] url: {url}");
            using HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            Debug.Log("[AsyncDataLoader.DoGetRequest] reading response content...");
            string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);

            Debug.Log($"[AsyncDataLoader.DoGetRequest] response: {responseBody}");
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
