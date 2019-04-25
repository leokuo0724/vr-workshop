using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroadCase : MonoBehaviour {
    public GameObject Born_Group;
    public GameObject Menu;
    public GameObject enemy;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void MSm()
    {
        Born_Group.BroadcastMessage("StartBorn");
        enemy.SetActive(true);
        Menu.SetActive(false); 
    }
}
