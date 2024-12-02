using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int maxPoolSize = 20;
    [SerializeField] private int startPoolSize = 10;

    private List<GameObject> _availableObjects = new List<GameObject>();
    private List<GameObject> _inUseObjects = new List<GameObject>();
    private int _totalObjects = 0;

    private void Start()
    {
        for (int i = 0; i < startPoolSize; i++)
        {
            AddObjectToPool();
        }
    }

    private GameObject AddObjectToPool()
    {
        if (_totalObjects >= maxPoolSize) return null;
        
        GameObject obj = Instantiate(prefab);
        obj.SetActive(false);
        _availableObjects.Add(obj);
        _totalObjects++;
        return obj;
    }

    public GameObject TryGetFromPool()
    {
        if (_availableObjects.Count > 0)
        {
            GameObject obj = _availableObjects[0];
            _availableObjects.RemoveAt(0);
            _inUseObjects.Add(obj);
            obj.SetActive(true);
            return obj;
        }
        
        GameObject newObj = AddObjectToPool();
        if (newObj != null)
        {
            _inUseObjects.Add(newObj);
            newObj.SetActive(true);
            return newObj;
        }
        
        return null;
    }

    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
        _inUseObjects.Remove(obj);
        _availableObjects.Add(obj);
    }

    public int GetTotalObjects() => _totalObjects;
    public int GetAvailableCount() => _availableObjects.Count;
    public int GetInUseCount() => _inUseObjects.Count;
}
