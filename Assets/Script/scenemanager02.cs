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
    private float timer = 19.2f;


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0.0f)
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

