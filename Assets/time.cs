using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{

    int time_int = 3;
    public Text time_UI;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("timer", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void timer()
    {
        time_int -= 1;
        time_UI.text = time_int + "";
        if (time_int == 0)
        {
            time_UI.text = "時間到";
            CancelInvoke("timer");
            
        }
    }
}