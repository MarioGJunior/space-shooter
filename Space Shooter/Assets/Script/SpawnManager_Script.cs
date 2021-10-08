using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager_Script : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("respawn", 0, 2);
    }

    private void respawn()
    {
        Instantiate(enemy, new Vector2(Random.Range(-8, 8), Camera.main.orthographicSize + 2), Quaternion.identity);
    }
}
