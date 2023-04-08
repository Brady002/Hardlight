using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOnTargetShot : MonoBehaviour
{

    public GameObject[] targets;
    private int targetsHit;
    private int numberOfTargets;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject value in targets)
        {
            numberOfTargets++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(targetsHit >= numberOfTargets)
        {
            //doorAnim.SetBool("IsOpening", true);
        } else
        {
            //doorAnim.SetBool("IsOpening", false);
        }
    }
}
