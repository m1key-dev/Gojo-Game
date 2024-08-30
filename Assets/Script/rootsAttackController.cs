using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootsAttackController : MonoBehaviour
{
   public float damage = 10f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<playerStats>().TakeDamage(damage);
        }

        if (collision.gameObject.tag == "Player Projectile")
        {
            Destroy(gameObject);
        }
    }
}
