using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pool : MonoBehaviour
{
    [System.Serializable]
    public struct Pool
    {
        public Queue<GameObject> pooledObject;
        public GameObject objectPrefab;
        public int poolSize;
    }


    [SerializeField] private Pool[] pools = null;

    private void Awake()
    {
        for (int j = 0; j < pools.Length; j++)
        {
            pools[j].pooledObject = new Queue<GameObject>();

            for (int i = 0; i < pools[j].poolSize; i++)
            {
                GameObject obj = Instantiate(pools[j].objectPrefab);
                obj.SetActive(false);

                pools[j].pooledObject.Enqueue(obj);
            }
        }
    }

    public GameObject getPooledObject(int ObjectType)
    {
        if (ObjectType >= pools.Length)
        {
            return null;
        }
        GameObject obj = pools[ObjectType].pooledObject.Dequeue();

        obj.SetActive(true);

        pools[ObjectType].pooledObject.Enqueue(obj);

        return obj;
    }
}
