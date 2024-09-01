using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6;
    public float hInput;
    private Animator animator;
    public playerStats currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        currentHealth = FindObjectOfType<playerStats>();
    }

    // Update is called once per frame
    void Update()
    {

       if (currentHealth.currentHealth > 0)
        {
        hInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right *hInput *moveSpeed * Time.deltaTime);
        SetAnimationRight();
        SetAnimationLeft();
        }
        
    }

    private void SetAnimationRight()
    {
        bool moveRight = hInput > 0;
        animator.SetBool("moveRight", moveRight);
    }

    private void SetAnimationLeft()
    {
        bool moveLeft = hInput < 0;
        animator.SetBool("moveLeft", moveLeft);
    }

    
}
