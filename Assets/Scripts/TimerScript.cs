using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour {

    public float maxTime = 60.0f;
    [SerializeField]
    private float countDown;

	// Use this for initialization
	void Start () {
        countDown = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
        countDown -= Time.deltaTime;

        if(countDown<=0.0f)
        {
            CoinScript.coinCount = 0;
            SceneManager.LoadScene("SampleScene");
        }
	}
}
