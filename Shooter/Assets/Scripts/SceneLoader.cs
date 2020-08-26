using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
     
     public void change(string scene_name)
     {
         SceneManager.LoadScene(scene_name);
     }
 
 }