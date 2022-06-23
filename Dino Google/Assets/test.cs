using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 1;
    [SerializeField] private pool objectPool = null;

    private void Start()
    {
        StartCoroutine(nameof(SpawnRoutine));
    }
    private IEnumerator SpawnRoutine()
    {
        int counter = 0;
        while (true)
        {

            GameObject obj = objectPool.getPooledObject(counter++ % 2);

            obj.transform.position = transform.position;

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
