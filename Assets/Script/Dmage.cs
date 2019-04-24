using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dmage : MonoBehaviour {

    public float Hp = 100f;
    public Image Hp_Bar;
	// Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {

            Hp -= 25;
            Hp_Bar.fillAmount = Hp / 100f;
            print(Hp);
        }

    }
    
}
