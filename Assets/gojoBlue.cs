using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gojoBlue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 0.6f);
    }
    //potom musim pridat OnCollisionEnter2D k enemy projectiles aby se nicily na impactu
}
