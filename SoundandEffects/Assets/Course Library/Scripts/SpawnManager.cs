using NUnit.Framework.Constraints;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
