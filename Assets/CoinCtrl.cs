using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCtrl : MonoBehaviour
{
    public int price = 1;

    private GameObject player;
    private PlayerCtrl playerCtrl;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find( "Player" );
        playerCtrl = player.GetComponent<PlayerCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D( Collision2D col ) {
        if ( col.gameObject.tag == "Player" ) {
            playerCtrl.GetCoin( price );
            Destroy( gameObject );
        }
    }
}
