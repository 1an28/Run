using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private Rigidbody2D rb2d;
    private Animator anim;
    private SpriteRenderer spRend;


    // Start is called before the first frame update
    void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
        this.anim = GetComponent<Animator>();
        this.spRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = 1.0f; //右方向に走らせ続ける
        //Input.GetAxisRaw("Horizontal"); //A[-1] : Null[0] : D[+1] <キー入力>

        float velX = rb2d.velocity.x; //x軸の速度取得
        float velY = rb2d.velocity.y; //y軸の速度取得

        anim.SetFloat( "Speed", Mathf.Abs( velX ) ); //AnimatorのSpeedに速度を代入
        rb2d.AddForce( Vector2.right * x * speed ); //rigidbody2Dの関数を使ってplayerを移動させる

        if ( velY > 1.3f ) { //ジャンプアニメーション
            anim.SetBool( "isJump", true );
            anim.SetBool( "isFall", false );
        } else if ( velY < -1.3f ) { //落ちるアニメーション
            anim.SetBool( "isJump", false );
            anim.SetBool( "isFall", true );
        } else { //地面にいるアニメーション
            anim.SetBool( "isJump", false );
            anim.SetBool( "isFall", false );
        }

        //進んだ方向を向くようにする    
        if ( x > 0 ) {
            spRend.flipX = false;
        } else if ( x < 0 ) {
            spRend.flipX = true;
        }

        //飛ぶ
        if ( Input.GetButtonDown("Jump") ) {
            rb2d.AddForce( Vector2.up * jumpForce );
        }
        
        //速度制限
        if ( velX > 8.0f ) {
            rb2d.velocity = new Vector2( 8.0f, velY );
        } else if ( velX < -8.0f ) {
            rb2d.velocity = new Vector2( -8.0f, velY );
        }
    }
}
