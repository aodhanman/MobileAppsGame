using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class level : MonoBehaviour
{


    public static int levelValue = 1;
    Text levelNo;
    // Start is called before the first frame update
    void Start()
    {
        levelNo = GetComponent<Text> ();

    }

    // Update is called once per frame
    void Update()
    {
        levelNo.text = "level: " + levelValue;
    }
}