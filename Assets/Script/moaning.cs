using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moaning : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] mySounds;

    private AudioClip activeSound;




  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            activeSound = mySounds[Random.Range(0, mySounds.Length)];
            audioSource.PlayOneShot(activeSound);
        }
    }
}
