using UnityEngine;

public class GameEventTester : MonoBehaviour
{
    [SerializeField] private GameEventSO Event;

    [SerializeField] private bool raiseEvent = false;

    void Update()
    {
        if(raiseEvent)
        {
            raiseEvent = false;
            Event.Raise();
        }
    }
}
