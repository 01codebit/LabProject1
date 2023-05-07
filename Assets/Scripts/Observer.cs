using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    private bool transformMe;
    private float degreesPerSecond = 360.0f;
    private float count = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transformMe)
        {
            var elapsed = Time.deltaTime;
            count += elapsed;
            if(count>1.0f)
            {
                transformMe = false;
                count = 0f;
            }
            else
                transform.Rotate(Vector3.forward, degreesPerSecond * elapsed);
        }

    }

    public void OnPublisherEvent()
    {
        transformMe = true;
    }

    public void OnClicked(string msg)
    {
        Debug.Log($"[{this.gameObject.name}.OnClicked] {msg}");
    }
}
