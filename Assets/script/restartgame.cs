using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartgame : MonoBehaviour
{
   public void RestartLevel()
   {
    Time.timeScale = 1;
    GameManager.health = 5;
    SceneManager.LoadScene(0);
   }
}
