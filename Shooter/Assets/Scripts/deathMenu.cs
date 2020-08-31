using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathMenu : MonoBehaviour
{
    [SerializeField] private GameObject deathmenuUI;
    


    // Start is called before the first frame update
    void Start()
    {
         deathmenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.health < 0.8){
            
             Time.timeScale = 0;
        AudioListener.pause = true;
        deathmenuUI.SetActive(true);

        }
        
    }
    void ActivateMenu(){

        Time.timeScale = 0;
        AudioListener.pause = true;
        deathmenuUI.SetActive(true);
    }
    public void DeactivateMenu(){

        Time.timeScale =1;
        AudioListener.pause = false;

        deathmenuUI.SetActive(false);
    }
}
