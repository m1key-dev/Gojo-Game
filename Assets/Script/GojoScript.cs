using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GojoScript : MonoBehaviour
{

Animator animator;
public Rigidbody2D myRigidbody;
public float flapStrength;
public LogicScript logic;
public bool gojoHope = true;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        logic = GameObject.FindGameObjectWithTag("Skibidi Tag").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
if (Input.GetKeyDown(KeyCode.Space) == true && gojoHope == true)
    {
        myRigidbody.velocity = Vector2.up * flapStrength;
        animator.SetTrigger("Jump");
    }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        gojoHope = false;
       
    }
}
