using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public float activeRange = 5.0f;
    private GameObject player;
    private Transform target;
    private float distanceToTarget;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.Find("Player");
        InvokeRepeating("FindTarget", 0f, 0.5f);
    }

    private void FindTarget()
    {
        distanceToTarget = Vector3.Distance(transform.position, player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(distanceToTarget < activeRange)
        {
            Vector3 direction = player.transform.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            Vector3 rotation = targetRotation.eulerAngles;
            transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);
        }
    }

    /*void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        OnDrawGizmosSelected.DrawWireSphere(transform.position, range);
    }*/

    
}
