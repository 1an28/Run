using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    public GameObject palyer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float nextX;

        if ( 0 >= palyer.transform.position.x ) {
            nextX = 0;
        } else {
            nextX = palyer.transform.position.x;
        }

        transform.position = new Vector3( nextX, transform.position.y, transform.position.z );
    }
}
