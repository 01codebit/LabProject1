using UnityEngine;

public class PersistentObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _persistentObjectPrefab;
    [SerializeField] private string _persistentObjectName;

    private bool _hasSpawned = false;

    private void Awake()
    {
        if(_hasSpawned) return;

        SpawnPersistentObject();
        _hasSpawned = true;
    }

    private void SpawnPersistentObject()
    {
        GameObject persistentObject = Instantiate(_persistentObjectPrefab);
        persistentObject.name = _persistentObjectName;
        DontDestroyOnLoad(persistentObject);
    }
}
