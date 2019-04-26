using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dmage : MonoBehaviour {

    public float Hp = 100f;
    public Image Hp_Bar;
    public GameObject DeadImage;
    public BornText bo;
    public GameObject enemy;
    
    // Use this for initialization
    public void Awake()
    {
        Hp = 20;
    }
    public void hit()
    {
        Hp -= 1;
        Hp_Bar.fillAmount = Hp / 100f;
        print(Hp);
        if(Hp==0 ||Hp<0)
        {
            enemy.SetActive(false);
            DeadImage.SetActive(true);
            bo.Delet();
        }
    }

   

}
