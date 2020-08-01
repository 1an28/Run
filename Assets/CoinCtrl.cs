using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCtrl : MonoBehaviour
{
    public int price = 1;
    public PlayerCtrl playerCtrl;


    // Start is called before the first frame update
    void Start()
    {
        
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
