using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RootsSpawner : MonoBehaviour
{
    public GameObject rootsAttack;
    public float timer = 0;
    public float spawnRate = 1.5f;
    public float widthOffset = 15;
    public float ySpawnOffset;
    public float deleteTime = 1.6f;
    public Transform Player;
    private float playerX;

    
    // Start is called before the first frame update
    void Start()
    {
        spawnRoots();
        
    }

    // Update is called once per frame
    void Update()
    {
        

        playerX = Player.position.x-1.5f;
        if (timer < spawnRate)

            {
                timer += Time.deltaTime;

            }   
        else
            {
                timer = 0;
                spawnRoots();
                
            }
            
        

    }

    


    void spawnRoots()
    {
        float leftmostPoint = transform.position.x - widthOffset;
        float rightmostPoint = transform.position.x + widthOffset;

        var copy = Instantiate(rootsAttack, new Vector3(playerX, ySpawnOffset, 0), transform.rotation);
        
    }

    
}
