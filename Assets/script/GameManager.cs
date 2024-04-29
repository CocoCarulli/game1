using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject live1, live2, live3, live4, live5, gameOver;
    public static int health;


    void Start()
    {
          health = 5;
          live1.gameObject.SetActive(true);
          live2.gameObject.SetActive(true);
          live3.gameObject.SetActive(true);
          live4.gameObject.SetActive(true);
          live5.gameObject.SetActive(true);
          gameOver.gameObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        switch (health)
        {
            
            case 5:
                 live1.gameObject.SetActive(true); 
                 live2.gameObject.SetActive(true);
                 live3.gameObject.SetActive(true);
                 live4.gameObject.SetActive(true);
                 live5.gameObject.SetActive(true);
                 break;

            case 4:
                 live1.gameObject.SetActive(true); 
                 live2.gameObject.SetActive(true);
                 live3.gameObject.SetActive(true);
                 live4.gameObject.SetActive(true);
                 live5.gameObject.SetActive(false);
                 break;

            case 3:
                 live1.gameObject.SetActive(true); 
                 live2.gameObject.SetActive(true);
                 live3.gameObject.SetActive(true);
                 live4.gameObject.SetActive(false);
                 live5.gameObject.SetActive(false);
                 break;

            case 2:
                 live1.gameObject.SetActive(true); 
                 live2.gameObject.SetActive(true);
                 live3.gameObject.SetActive(false);
                 live4.gameObject.SetActive(false);
                 live5.gameObject.SetActive(false);
                 break;

            case 1:
                 live1.gameObject.SetActive(true); 
                 live2.gameObject.SetActive(false);
                 live3.gameObject.SetActive(false);
                 live4.gameObject.SetActive(false);
                 live5.gameObject.SetActive(false);
                 break;

            default:
                 live1.gameObject.SetActive(false); 
                 live2.gameObject.SetActive(false);
                 live3.gameObject.SetActive(false);
                 live4.gameObject.SetActive(false);
                 live5.gameObject.SetActive(false);
                 gameOver.gameObject.SetActive(true);
                 Time.timeScale = 0;
                 break;
            
        }
    }
}
