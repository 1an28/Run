using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
//using DG.tweening;

public class CanvasCtrl : MonoBehaviour
{
    private GameObject textObject;
    private Text scoreText;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        textObject = GameObject.Find("CoinNum");
        scoreText = textObject.GetComponent<Text>();
        scoreText.text = "000000";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString("000000");
    }

    public void AddScore( int price ) {
        score += price;
    }
}
