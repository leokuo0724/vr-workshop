using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterContraler : MonoBehaviour {
    public GameObject MyTarget;
    public GameObject playerExp;
    public Dmage dmage;
    private NavMeshAgent MyAgent;//宣告循跡代理人
    private Animator anim;
    
   
    
    // Use this for initialization
    void Start () {
        
        MyAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //判定怪物和我們的距離
        float dis = Vector3.Distance(transform.position, MyTarget.transform.position);

        if(dis<50 && dis>1)
        {
            anim.SetBool("Run", true);
            MyAgent.SetDestination(MyTarget.transform.position);//追蹤(誰)
            MyAgent.stoppingDistance = 1.0f;
        }
        else
        {
            Vector3 temp = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z +0.2f);
            Instantiate(playerExp, temp, Quaternion.identity);
            Destroy(this.gameObject);
            dmage.hit();
        }
	}
    

}
