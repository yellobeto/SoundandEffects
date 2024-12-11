using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private Vector3
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle ()
}

