using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private Publisher _publisher;
    [SerializeField] private List<Observer> _observers;


    // Start is called before the first frame update
    void Start()
    {
        if(_observers.Count>0 && _publisher)
        {
            foreach(var o in _observers)
            {
                _publisher.Clicked += o.OnClicked;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy() 
    {
        if(_observers.Count>0 && _publisher)
        {
            foreach(var o in _observers)
            {
                _publisher.Clicked -= o.OnClicked;
            }
        }
        
    }
}
