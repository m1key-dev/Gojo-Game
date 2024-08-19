using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager02 : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    private int levelToLoad;
    public GameObject readyScreen;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            FadeToLevel(2);
        }
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene("sukunaInvaders");
    }

    public void FadeToLevel (int levelIndex)
    {
        animator.SetTrigger("fadeOut");
    }
}

