using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PostButton : MonoBehaviour
{
    [SerializeField] private TMP_InputField _urlText;

    [SerializeField] private TMP_InputField _bodyText;

    [SerializeField] private AsyncLoader _loader;

    [SerializeField] private Button _postButton;

    [SerializeField] private ResponseTextController _responseTextController;

    private string CleanString(string input)
    {
        var output = input.Replace(" ", "");
        output = output.Replace("\n", "");

        return output;
    }

    public async void OnButtonPress()
    {
        Debug.Log("POST button pressed");

        _postButton.interactable = false;
        _responseTextController.SetLoading();

        var url = _urlText.text;
        var body = _bodyText.text;

        url = CleanString(url);
        body = CleanString(body);

        Debug.Log($"Post url: {url}");
        Debug.Log($"Post body: {body}");

        var result = await _loader.DoPostRequest(url, body);
        _responseTextController.SetText(result);
        _postButton.interactable = true;
    }
}
