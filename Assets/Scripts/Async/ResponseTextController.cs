using UnityEngine;
using TMPro;

public class ResponseTextController : MonoBehaviour
{
    [SerializeField] private TMP_Text _responseText;

    [SerializeField] private TMP_Text _responseTime;

    [SerializeField] private GameObject _loadingImage;

    private bool _isLoading;

    private float _loadingImageSpeed = 360f;

    private float _startLoading;

    // Start is called before the first frame update
    void Start()
    {
        _responseText.text = "";
        _responseTime.text = "";
        _loadingImage.SetActive(false);
        _isLoading = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(_isLoading)
        {
            // ruoto l'immagine di loading
            _loadingImage.transform.Rotate(Vector3.forward, _loadingImageSpeed * Time.deltaTime);
        }
    }

    private void StartTimer()
    {
        _startLoading = Time.time;
    }

    private float GetElapsedTime()
    {
        var end = Time.time;
        var elapsed = Mathf.Floor((end - _startLoading) * 100);
        elapsed = elapsed/100f;

        return elapsed;
    }


    public void SetLoading(bool loading=true)
    {
        _isLoading = loading;
        _loadingImage.SetActive(_isLoading);

        if(loading)
        {
            _responseText.text = "";
            _responseTime.text = "";
            StartTimer();
        }
        else
        {
            var et = GetElapsedTime();
            _responseTime.text = $"Time: {et} s";
            _loadingImage.transform.rotation = Quaternion.identity;
        }
    }

    public void SetText(string text)
    {
        SetLoading(false);
        _responseText.text = text;
    }
}
