using System;
using UnityEngine;
using UnityEngine.Events;

public class Publisher : MonoBehaviour
{
    [SerializeField] private UnityEvent _clicked;

    public event Action<string> Clicked;

    void OnMouseDown()
    {
        Debug.Log("[Publisher.OnMouseDown]");
        _clicked.Invoke();
    }

    public void Click()
    {
        Debug.Log("[Publisher.Click]");
        _clicked.Invoke();
    }
}
