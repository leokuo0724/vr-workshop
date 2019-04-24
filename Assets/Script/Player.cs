using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Player : MonoBehaviour {
    public Transform BulletPoint;
    public GameObject BulletPrefab;
    public SteamVR_Action_Boolean spawn;
    public SteamVR_Input_Sources m_inputSource;
    public float timer;
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        //spawn.GetStateDown(m_inputSource)         
        timer += Time.deltaTime;
      　
        
        if (spawn.GetStateDown(m_inputSource))
        {
           GameObject go = Instantiate(BulletPrefab, BulletPoint.position, BulletPoint.transform.rotation) as GameObject;
            go.transform.Rotate(90f, 0, 0);
            go.GetComponent<Rigidbody>().velocity = 10f*BulletPoint.transform.forward; 

        }

    }
}
