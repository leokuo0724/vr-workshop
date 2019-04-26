using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Test1 : MonoBehaviour {
    public Restart re;
    public BroadCase bc;
    public SteamVR_Action_Boolean spawn;
    public SteamVR_Input_Sources m_inputSource;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //spawn.GetStateDown(m_inputSource)
          if (Input.GetKeyDown(KeyCode.A))
        {
            bc.MSm();
        }
        //spawn.GetStateUp(m_inputSource)
        if (Input.GetKeyDown(KeyCode.X))
        {
            re.ResetGame();
        }
	}
}
