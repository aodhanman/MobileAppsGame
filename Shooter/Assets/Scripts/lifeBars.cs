﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeBars : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        localScale.x = Player.health;
        transform.localScale = localScale;
    }
}