using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gojoRed : MonoBehaviour
{

    public float moveSpeed;
    public float damage = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<EnemyBehaviour>().TakeDamage(damage);
            Destroy(gameObject);

        
        }
        //potom musim pridat aby se to nicilo kdyz dojde na enemaka
        //a hp system
    }
}
