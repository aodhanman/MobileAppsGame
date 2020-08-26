using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    float scrollSpeed = -5f;
    Vector2 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos =Mathf.Repeat (Time.time * scrollSpeed, 100);
        transform.position = startPos + Vector2.up * newPos;
    }
}
