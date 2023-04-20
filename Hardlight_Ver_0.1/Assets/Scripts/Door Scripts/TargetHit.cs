using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{

    public GameObject[] targets;
    private Animator doorAnim;
    bool opening = false;
    private int targetsHit = -1;
    // Start is called before the first frame update
    void Start()
    {
        doorAnim = this.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //opening = target.transform.GetComponent<TargetScript>().isHit;
        for (int i = 0; i < targets.Length; i++)
        {
            if(targets[i].transform.GetComponent<TargetScript>().isHit == true && targets[i].transform.GetComponent<TargetScript>().locked == false)
            {
                targetsHit++;
            }
            
        }

        if (targetsHit >= targets.Length - 1)
        {

            doorAnim.SetBool("IsOpening", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy();
        if (opening)
        {

            doorAnim.SetBool("IsOpening", true);
        }
        
    }

}
