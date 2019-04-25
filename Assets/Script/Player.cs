using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Player : MonoBehaviour {
    public Transform BulletPoint;
    public GameObject BulletPrefab;
    public GameObject WinerImage;
    public GameObject enemy;
    public SteamVR_Action_Boolean spawn;
    public SteamVR_Input_Sources m_inputSource;
    public Boxpl bo;
    public BornText bo1;
    public float timer;
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        //spawn.GetStateDown(m_inputSource)         
        timer += Time.deltaTime;
        
        
        if (Input.GetKeyDown(KeyCode.A)&&timer>0.5)
        {
            GameObject go = Instantiate(BulletPrefab, BulletPoint.position, BulletPoint.transform.rotation) as GameObject;
            go.transform.Rotate(90f, 0, 0);
            go.GetComponent<Rigidbody>().velocity = 10f*BulletPoint.transform.forward;
            timer = 0;

        }
        if(bo.a==1)
        {
            WinerImage.SetActive(true);
            enemy.SetActive(false);

            bo1.Delet();
        }

    }
}
