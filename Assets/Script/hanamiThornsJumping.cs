using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanamiThornsJumping : MonoBehaviour
{
    public LogicScript logicScript;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = FindObjectOfType<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(logicScript.playerScore >= 10)
        {
            animator.SetBool("ThornsJumpingAnim", true);
        }
    }
}
