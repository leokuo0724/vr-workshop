using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Valve.VR;

public class Player : MonoBehaviour {

    private AudioSource au;
    public Dmage da;
    public bool isStart;
    public Transform BulletPoint;
    public GameObject Ak;
    public GameObject BulletPrefab;
    public GameObject WinerImage;
    public GameObject enemy;
    public GameObject enemy1;
    public SteamVR_Action_Boolean spawn;
    public SteamVR_Input_Sources m_inputSource;
    public Boxpl bo;
    public BornText bo1;
    public float timer;
    public float fireRate = 0.5f;
    public float nextFire;
    // Use this for initialization
    void Start () {
        au = this.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //spawn.GetStateDown(m_inputSource)         
        timer += Time.deltaTime;
        if (timer > 30)
        {
            WinerImage.SetActive(true);
            enemy.SetActive(false);
            bo1.Delet();
            au.Stop();
            isStart = false;
            timer = -200;
        }
        if (da.Hp < 0 || da.Hp == 0)
        {
            da.DeadImage.SetActive(true);
            enemy.SetActive(false);
            bo1.Delet();
            au.Stop();
            isStart = false;
            timer = -200;
        }
        else if (timer > 0.1)
        {
            enemy1.SetActive(false);
            isStart = true;
        }
        if (isStart == true)
        {
            if (Input.GetKeyDown(KeyCode.A) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                au.Play();
                GameObject go = Instantiate(BulletPrefab, BulletPoint.position, BulletPoint.transform.rotation) as GameObject;
                go.transform.Rotate(90f, 0, 0);
                go.GetComponent<Rigidbody>().velocity = 10f * BulletPoint.transform.forward;

            }
        }

    }
}
