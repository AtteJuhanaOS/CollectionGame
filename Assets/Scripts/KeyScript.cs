using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {


    private void OnTriggerEnter(Collider PlayerObject)
    {
        if (PlayerObject.CompareTag("Player"))
        {
            PlayerObject.GetComponent<PlayerScript>().hasKey = true;

            Destroy(gameObject);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
