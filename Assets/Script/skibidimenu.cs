using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skibidimenu : MonoBehaviour
{
  public void OnPlayButton ()
  {
    SceneManager.LoadScene("idk");
  }

  public void OnQuitButton ()
  {
    Application.Quit();
  }
}
