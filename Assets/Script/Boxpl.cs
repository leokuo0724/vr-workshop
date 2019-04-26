using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boxpl : MonoBehaviour {
    public GameObject Exp;
    public Player pl;
    public bool i = false;
    public int a=0;
    //public AudioSource test; 
    // Use this for initialization
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            i = true;
            Vector3 temp = transform.position;
            Instantiate(Exp, temp, Quaternion.identity);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            pl.ddas();
        }
      
    }
}



