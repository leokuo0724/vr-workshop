using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boxpl : MonoBehaviour {
    public GameObject Exp;
    public int a;
    //public AudioSource test; 
    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {  
        if (other.gameObject.tag == "Bullet")
        {
         
        Vector3 temp = transform.position;
        Instantiate(Exp, temp, Quaternion.identity);
        Destroy(this.gameObject);   
        Destroy(other.gameObject);
        a++;
        print(a);
        }
      
    }
}



