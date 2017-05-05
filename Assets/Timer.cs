using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeToWin;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (Time.timeSinceLevelLoad < timeToWin)
	        GetComponent<UnityEngine.UI.Text>().text ="Time: " + Time.timeSinceLevelLoad.ToString("0");
	    else
	        GetComponent<UnityEngine.UI.Text>().text = "Wygrałeś!!!!";

	}
}
