using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boxpl : MonoBehaviour {
    public GameObject Exp;
    public GameObject playerExp;

    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        { 

        Vector3 temp = transform.position;
        
        Instantiate(Exp, temp, Quaternion.identity);
        
        Destroy(this.gameObject);   
        Destroy(other.gameObject);
        }
        if(other.gameObject.tag=="player")
        {
            Vector3 temp = transform.position;
            Instantiate(playerExp, temp, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}



