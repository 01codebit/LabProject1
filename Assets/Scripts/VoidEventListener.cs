using UnityEngine;

public class VoidEventListener : MonoBehaviour
{
    [SerializeField] VoidEventChannelSO channel;

    private bool transformMe;
    private float degreesPerSecond = 360.0f;
    private float count = 0;

    void OnEventRaised()
    {
        transformMe = true;
    }

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

    private void OnEnable()
    {
        channel.OnEventRaised += OnEventRaised;    
    }

    private void OnDestroy()
    {
        channel.OnEventRaised -= OnEventRaised;
    }
}

