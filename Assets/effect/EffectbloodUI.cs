using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectbloodUI : MonoBehaviour {

    public float playerHP;
    public float playerHPMax;
    public Image i;
    public float f;
    private Color c;

    //百分比數值
    public float HP50;
    public float HP30;
    public float HP10;

    //閃爍效果

    //物體閃爍
    private float shake;

    // Use this for initialization
    void Start () {
        //假設玩家血量 之後刪除
        playerHP = 9;
        playerHPMax = 100;

        //計算血量百分比
        HP50 = playerHPMax/2;
        HP30 = (playerHPMax * 3) / 10;
        HP10 = playerHPMax / 10;

        //獲取圖片屬性
        f =this.GetComponent<Image>().color.a;
        c = this.GetComponent<Image>().color;
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
        f = this.GetComponent<Image>().color.a;
        i.color = c;

        shake += Time.deltaTime;

        if (c.a < 0)
        {
            c.a = 0;
        }

        if (playerHP < HP10)
        {
            if (shake % 1 > 0.5f)
            {
                c = new Color(c.r, c.g, c.b, c.a + 2f / 255f);
            }
            else
            {
                c = new Color(c.r, c.g, c.b, c.a - 2f / 255f);
            }
        }else if (playerHP < HP30)
        {
            if (shake % 1 > 0.5f)
            {
                c = new Color(c.r, c.g, c.b, c.a + 1f / 255f);
            }
            else
            {
                c = new Color(c.r, c.g, c.b, c.a - 1f / 255f);
            }
        }else if (playerHP < HP50)
        {
            if (shake % 1 > 0.5f)
            {
                c = new Color(c.r, c.g, c.b, c.a + 0.3f / 255f);
            }
            else
            {
                c = new Color(c.r, c.g, c.b, c.a - 0.3f / 255f);
            }
        }
    }
}
