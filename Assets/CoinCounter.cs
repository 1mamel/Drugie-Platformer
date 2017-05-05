using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    private int score;
    public Text tC;
	// Use this for initialization
	void Start ()
	{
	    tC = gameObject.GetComponent<Text>();
        UpdateScore();
	}

    public void AddScore(int addedScore)
    {
        score += addedScore;
        UpdateScore();
    }

    void UpdateScore()
    {
        tC.text = "Coins: " + score;
    }

}
