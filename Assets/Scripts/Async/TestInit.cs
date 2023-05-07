using UnityEngine;
using TMPro;

public class TestInit : MonoBehaviour
{
    [SerializeField] private TMP_InputField _urlText;

    [SerializeField] private TMP_InputField _bodyText;

    [SerializeField] private string _testUrl;

    [SerializeField] [TextArea] private string _testBody;

    void Start()
    {
        _urlText.text = _testUrl;
        _bodyText.text = _testBody;        
    }
}
