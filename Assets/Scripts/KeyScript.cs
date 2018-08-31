using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {

    

    void OnCollisionEnter(Collision PlayerObject)
    {
        if (PlayerObject.CompareTag("Player"))
        {
            PlayerObject.GetComponent<PlayerScript>().hasKey = true;

                
            

            Destroy();
        }
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
