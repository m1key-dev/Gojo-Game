using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueShoot : MonoBehaviour
{
    public GameObject bluePrefab;
    Animator animator;
    private float nextFireTime = 0;
    public float cooldownTime = 10f;

    private float spawnY;
    private float spawnX;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spawnY = transform.position.y + 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnX = transform.position.x + 0.36f;
        if(Time.time > nextFireTime){
            
        
            
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Instantiate(bluePrefab, new Vector3 (spawnX, spawnY, 0), Quaternion.identity);
                nextFireTime = Time.time + cooldownTime;
            }
        }
        shootingBlueAnim();
    }

    private void shootingBlueAnim()
    {
        animator.SetBool("shootingBlue", Input.GetKeyDown(KeyCode.Q));
    }
}
