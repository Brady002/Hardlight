using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{

    public GameObject[] targets;
    public GameObject target;
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
        opening = target.transform.GetComponent<TargetScript>().isHit;
        if (opening)
        {

            doorAnim.SetBool("IsOpening", true);
        }
    }

}
