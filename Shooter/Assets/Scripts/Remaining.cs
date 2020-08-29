using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Remaining : MonoBehaviour
{
    public static int remaining = 10;
    Text number;
    // Start is called before the first frame update
    void Start()
    {
        number = GetComponent<Text> ();

    }

    // Update is called once per frame
    void Update()
    {
        number.text = "Remaining Enemies: " + (remaining - Spawn.killed);
    }
}
