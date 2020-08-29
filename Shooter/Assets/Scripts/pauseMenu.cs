using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject pausemenuUI;
    
    [SerializeField] private bool isPaused;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            isPaused = !isPaused;
        }
        if (isPaused){
            ActivateMenu();

        }
        else
        {
            DeactivateMenu();
        }
    }
    void ActivateMenu(){

        Time.timeScale = 0;
        AudioListener.pause = true;
        pausemenuUI.SetActive(true);
    }
    void DeactivateMenu(){

        Time.timeScale =1;
                AudioListener.pause = false;

        pausemenuUI.SetActive(false);
    }
}
