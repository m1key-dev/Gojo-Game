using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    public Animator animator;
    public LogicScript logicScript;
    private int levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
       logicScript = FindObjectOfType<LogicScript>();
       

    }

    // Update is called once per frame
    void Update()
    {
        if (logicScript.playerScore>=30)
        {
            FadeToLevel(1);
        }
    }

    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void FadeToLevel (int levelIndex)
    {
        animator.SetTrigger("fadeOut");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene("cutscene1");
    }
}
