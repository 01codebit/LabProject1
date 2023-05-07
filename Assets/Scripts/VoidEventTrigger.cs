using UnityEngine;

public class VoidEventTrigger : MonoBehaviour
{
    [SerializeField] VoidEventChannelSO channel;

    void OnMouseDown()
    {
        Debug.Log("[VoidEventTrigger.OnMouseDown]");
        channel.RaiseEvent();
    }
}
