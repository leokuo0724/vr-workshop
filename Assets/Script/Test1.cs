using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour {
    public Restart re;
    public BroadCase bc;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.C))
        {
            bc.MSm();
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            re.ResetGame();
        }
	}
}
