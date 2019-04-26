using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectbloodUI : MonoBehaviour {

    public float playerHP;
    public float playerHPMax;
    
    private Color c;

    //百分比數值
    public float HP50;
    private float HP30;
    private float HP10;


    //物體閃爍
    private float shake;

    // Use this for initialization
    void Start () {
        //假設玩家血量 之後刪除
        playerHP = 10;
        playerHPMax = 100;

        //計算血量百分比
        HP50 = playerHPMax/2;
        HP30 = (playerHPMax * 3) / 10;
        HP10 = (playerHPMax * 9) / 10;

        //獲取圖片屬性
        c =this.GetComponent<Image>().color;
        c = new Color(c.r, c.g, c.b, 0 / 255f);

        //this.GetComponent<Renderer>().material.color = new Color
        //(
        //        this.GetComponent<Renderer>().material.color.r,
        //        this.GetComponent<Renderer>().material.color.g,
        //        this.GetComponent<Renderer>().material.color.b,
        //        //以下透明度
        //        this.GetComponent<Renderer>().material.color.a
        //);
    }
	
	// Update is called once per frame
	void Update () {

        shake += Time.deltaTime;

        if (playerHP<HP50)
        {
            if (shake % 1 > 0.5f)
            {
                c = new Color(c.r, c.g, c.b, 30 / 255f);
                //this.GetComponent<SkinnedMeshRenderer>().material.color = new Color(
                //this.GetComponent<SkinnedMeshRenderer>().material.color.r,
                //this.GetComponent<SkinnedMeshRenderer>().material.color.g,
                //this.GetComponent<SkinnedMeshRenderer>().material.color.b,
                //this.GetComponent<SkinnedMeshRenderer>().material.color.a + 30);
            }
            else
            {
                c = new Color(c.r, c.g, c.b, 0 / 255f);
                //this.GetComponent<SkinnedMeshRenderer>().material.color = new Color(
                //this.GetComponent<SkinnedMeshRenderer>().material.color.r,
                //this.GetComponent<SkinnedMeshRenderer>().material.color.g,
                //this.GetComponent<SkinnedMeshRenderer>().material.color.b,
                //this.GetComponent<SkinnedMeshRenderer>().material.color.a - 30);
            }

        }


    }
}
