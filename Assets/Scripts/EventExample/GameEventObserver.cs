using UnityEngine;

public class GameEventObserver : MonoBehaviour
{
    private bool transformMe;
    private float degreesPerSecond = 360.0f;
    private float count = 0;

    public void Callback()
    {
        Debug.Log("[GameEventObserver] Event Received!");
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
}
