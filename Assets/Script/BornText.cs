using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BornText : MonoBehaviour
{
    public GameObject Born_0;
    public GameObject super;
    private GameObject clone;
    


    public float X_min, X_max, Z_min, Z_max;
    // Use this for initialization
    public  void StartBorn()
    {
        StartCoroutine(BornObject());
    }

    // Update is called once per frame
    void Update()
    {


    }
    IEnumerator BornObject()
    {
        int Num = 0;
        while(Num<10)
        {
            Num += 1;
            clone = Instantiate(Born_0);
            float ranx_ = Random.Range(X_min, X_max);
            float ranz = Random.Range(Z_min, Z_max);
            Vector3 pos = new Vector3(transform.position.x + ranx_, transform.position.y, transform.position.z + ranz);
            Vector3 po = new Vector3( 0.2f, 0.2f, 0.2f);
            clone = Instantiate(Born_0, pos, transform.rotation);
            clone.transform.parent = super.transform;
            clone.transform.localPosition = pos;
            clone.transform.localScale = po;
            clone.SetActive(true);
            
            Object script = clone.GetComponent<Delete>();
            Destroy(script);
            yield return new WaitForSeconds(0.5f);
          } 
    }
    public void Delet()
    {
        Destroy(clone);
    }
}
