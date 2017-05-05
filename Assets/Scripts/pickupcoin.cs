using UnityEngine;
using System.Collections;

public class pickupcoin : MonoBehaviour
{
    public int Score;
    private CoinCounter coinCounter;

    void Start()
    {
        coinCounter = GameObject.Find("CoinCount").GetComponent<CoinCounter>();
    }
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
            coinCounter.AddScore(Score);
			Destroy(this.gameObject);
		}
	}
}
