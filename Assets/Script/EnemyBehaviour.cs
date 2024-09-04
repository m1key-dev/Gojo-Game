using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] 
    private float currentHealth;
    [SerializeField]
    private float maxHealth = 200f;
    Animator animator;
    Transform player;
    Rigidbody2D rb;
    public float speed = 5f;
    public int attackType;

    private float nextFireTime = 0;
    public float cooldownTime = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        attackType = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newPosition = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
        rb.MovePosition(newPosition);
        if(Time.time > nextFireTime)
        {
        attackTarget();
        nextFireTime = Time.time + cooldownTime;
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    
    }   

    public void Die()
    {
        Destroy(gameObject);
    }

    public void attackTarget()
    {
        attackType = Random.Range(1,3);
        animator.SetInteger("Attack", attackType);
        attackType = 0;
    
    }
}
