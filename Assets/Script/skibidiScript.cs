using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skibidiScript : MonoBehaviour
{
    
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {   
        logic = GameObject.FindGameObjectWithTag("Skibidi Tag").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
    }
   

}
