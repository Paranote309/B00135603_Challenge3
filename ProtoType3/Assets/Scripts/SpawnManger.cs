using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25,0,0);

    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript= GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

   

    // Update is called once per frame
    void Update()
    {
        // if (playerControllerScript.gameOver == false){
        //    Instantiate(obstaclePrefab, spawnPos , obstaclePrefab, transform.rotation);
        // }
    }
     void SpawnObstacle () {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
