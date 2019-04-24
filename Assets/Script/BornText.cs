using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BornText : MonoBehaviour
{
    public GameObject Born_0;
    public float X_min, X_max, Z_min, Z_max;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(BornObject());
    }

    // Update is called once per frame
    void Update()
    {


    }
    IEnumerator BornObject()
    {
        float ranx_ = Random.Range(X_min, X_max);
        float ranz = Random.Range(Z_min, Z_max);
        Vector3 pos = new Vector3(transform.position.x + ranx_, transform.position.y, transform.position.z + ranz);
        Instantiate(Born_0, pos, transform.rotation);
        yield return new WaitForSeconds(2);
    }
}
