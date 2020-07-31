using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObj : MonoBehaviour
{
    public GameObject player;
    public GameObject ground;
    public GameObject bg;

    private float createGPOS = 0;
    private float createBGPOS = 0;
    private int oneLine;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CreateGround();
        CreateBg();
    }
    void CreateGround() {
        if ( player.transform.position.x >= createGPOS ) {
            oneLine = Random.Range( 2, 5 );
            for (int i = 0; i < oneLine; i++) {
                Instantiate( ground, new Vector2(createGPOS + 12 + i, 0), ground.transform.rotation );
            }
            createGPOS += Random.Range( 1.5f, 4.0f ) + oneLine;
        }
    }

    void CreateBg() {
        if ( player.transform.position.x >= createBGPOS ) {
            Instantiate( bg, new Vector2(createBGPOS + 13.3f, 0), bg.transform.rotation );
            createBGPOS += 13.3f;
        }
    }
}