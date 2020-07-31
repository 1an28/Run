﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgCtrl : MonoBehaviour
{
    GameObject maincam;
    // Start is called before the first frame update
    void Start()
    {
        maincam = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if ( transform.position.x <= maincam.transform.position.x - 14 ) {
            Destroy(this.gameObject);
        }
    }
}
