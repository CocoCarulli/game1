using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class flag : MonoBehaviour
{
    [SerializeField] private flag nextOne;
    private bool MustBeDeactivate;

    // Start is called before the first frame update
    void Start()
    {
        if(nextOne != null)
        {
            nextOne.MustBeDeactivate = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (MustBeDeactivate){
            gameObject.SetActive(false);
            MustBeDeactivate = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          if (nextOne != null)
        {
           nextOne.gameObject.SetActive(true);
        } 
        else 
        {
            SceneManager.LoadScene("titre");
        }
        }
        Debug.Log($"enter in to {name}");
        this.gameObject.SetActive(false);
    }

}
