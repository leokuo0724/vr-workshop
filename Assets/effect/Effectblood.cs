using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effectblood : MonoBehaviour {

    private float tempTime;

    // Use this for initialization
    void Start () {
        tempTime = 0;
        //獲取材質屬性
        this.GetComponent<Renderer>().material.color = new Color
        (
                this.GetComponent<Renderer>().material.color.r,
                this.GetComponent<Renderer>().material.color.g,
                this.GetComponent<Renderer>().material.color.b,
                //以下透明度
                this.GetComponent<Renderer>().material.color.a
        );
    }

    // Update is called once per frame
    void Update()
    {
        if (tempTime < 1)
        {
            tempTime = tempTime + Time.deltaTime;
        }
        if (this.GetComponent<Renderer>().material.color.a <= 1)
        {
            this.GetComponent<Renderer>().material.color = new Color
            (
                this.GetComponent<Renderer>().material.color.r,
                this.GetComponent<Renderer>().material.color.g,
                this.GetComponent<Renderer>().material.color.b,


            //逐漸消失秒數
            gameObject.GetComponent<Renderer>().material.color.a - tempTime / 4 * Time.deltaTime
            );
        }
    }
}
