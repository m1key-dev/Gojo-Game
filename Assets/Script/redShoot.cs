using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redShoot : MonoBehaviour
{

    public GameObject redPrefab;
    Animator animator;
    private float nextFireTime = 0;
    public float cooldownTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextFireTime){
            
        
            
            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(redPrefab, transform.position, Quaternion.identity);
                nextFireTime = Time.time + cooldownTime;
            }
        }
        shootingRedAnim();
        
    }

    private void shootingRedAnim()
    {
        animator.SetBool("shootingRed", Input.GetButtonDown("Fire1"));
    }
}
