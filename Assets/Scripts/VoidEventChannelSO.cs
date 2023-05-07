using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// This class is used for Events that have no arguments (Example: Exit game event)
/// </summary>

[CreateAssetMenu(menuName = "Events/Void Event Channel")]
public class VoidEventChannelSO : ScriptableObject
{
    public UnityAction OnEventRaised;

    public void RaiseEvent()
    {
        Debug.Log("[VoidEventChannelSO.RaiseEvent]");
        if(OnEventRaised != null)
            OnEventRaised.Invoke();
    }
}
