using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GetButton : MonoBehaviour
{
    [SerializeField] private TMP_InputField _urlText;

    [SerializeField] private AsyncLoader _loader;

    [SerializeField] private Button _getButton;

    [SerializeField] private ResponseTextController _responseTextController;

    private string CleanString(string input)
    {
        var output = input.Replace(" ", "");
        output = output.Replace("\n", "");

        return output;
    }

    public async void OnButtonPress()
    {
        Debug.Log("GET button pressed");
        var start = Time.time;

        _getButton.interactable = false;
        _responseTextController.SetLoading();

        var url = _urlText.text;

        url = CleanString(url);

        Debug.Log($"Post url: {url}");

        var result = await _loader.DoGetRequest(url);
        _responseTextController.SetText(result);
        _getButton.interactable = true;
    }
}
