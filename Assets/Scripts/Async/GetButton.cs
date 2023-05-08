using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading;
using System;
using System.Threading.Tasks;

public class GetButton : MonoBehaviour
{
    [SerializeField] private TMP_InputField _urlText;

    [SerializeField] private Button _getButton;

    [SerializeField] private ResponseTextController _responseTextController;

    private AsyncDataLoader _loader;

    private void Awake()
    {
        _loader = FindObjectOfType<AsyncDataLoader>();
    }

    public async void OnButtonPress()
    {
        Debug.Log("[GetButton.OnButtonPress] GET button pressed");
        ThreadFunctions.ShowThreadInformation("GetButton.OnButtonPress (Task #" + Task.CurrentId.ToString() + ")");

        _getButton.interactable = false;
        _responseTextController.SetLoading();

        var url = _urlText.text;

        url = StringFunctions.CleanString(url);

        Debug.Log($"[GetButton.OnButtonPress] GET url: {url}");

        var result = await _loader.DoGetRequest(url);

        _responseTextController.SetText(result);
        _getButton.interactable = true;
    }
}
