using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;


public class ObjectPooler : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> objectPool = new List<GameObject>();

    [SerializeField]
    private GameObject prefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 20f; i++)
        {
            GameObject newObject = Instantiate(prefab);
            newObject.SetActive(false);

            objectPool.Add(newObject);

        }

    }

   public GameObject GetObjectFromPool()
   {
        if(objectPool.Count == 0)
        {
            return null;
        }
         
        GameObject obj = objectPool[0];
        objectPool.Remove(obj);
        return obj;
   }

    public void ReturnObjectToPool(GameObject obj)
    {
        objectPool.Add(obj);

    }
}
