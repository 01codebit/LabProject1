using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading;

public class PostButton : MonoBehaviour
{
    [SerializeField] private TMP_InputField _urlText;

    [SerializeField] private TMP_InputField _bodyText;

    [SerializeField] private Button _postButton;

    [SerializeField] private ResponseTextController _responseTextController;

    private AsyncDataLoader _loader;

    private void Awake()
    {
        _loader = FindObjectOfType<AsyncDataLoader>();
    }

    public async void OnButtonPress()
    {
        Debug.Log("POST button pressed");
        Debug.Log($"current thread: {Thread.CurrentThread.GetHashCode()}");

        _postButton.interactable = false;
        _responseTextController.SetLoading();

        var url = _urlText.text;
        var body = _bodyText.text;

        url = StringFunctions.CleanString(url);
        body = StringFunctions.CleanString(body);

        Debug.Log($"Post url: {url}");
        Debug.Log($"Post body: {body}");

        var result = await _loader.DoPostRequest(url, body);
        _responseTextController.SetText(result);
        _postButton.interactable = true;
    }
}
