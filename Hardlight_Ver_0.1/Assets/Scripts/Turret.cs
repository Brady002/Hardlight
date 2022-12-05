using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [Header("Attributes")]
    public float activeRange = 5.0f;
    private float turnSpeed = 5f;
    public float fireRate = 1f;
    //public float volleySize = 1f;

    [Header("Unity Setup")]
    public GameObject player;
    private Transform target;
    private float distanceToTarget;
    private float fireCooldown = 0f;
    public GameObject projectile;
    private Quaternion defRot;
    //public Transform barrel;

    // Start is called before the first frame update
    void Start()
    {

        //player = GameObject.Find("Player");
        defRot = transform.rotation;
        InvokeRepeating("FindTarget", 0f, 0.2f);
    }

    private void FindTarget()
    {
        distanceToTarget = Vector3.Distance(transform.position, player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (distanceToTarget < activeRange)
        {
            Vector3 direction = player.transform.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            Vector3 rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * turnSpeed).eulerAngles;
            transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);

            if (fireCooldown <= 0f)
            {
                Shoot();
                fireCooldown = 1f / fireRate;
            }

            fireCooldown -= Time.deltaTime;
        } else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, defRot, Time.deltaTime * turnSpeed);
        }

        

        void Shoot()
        {
            /*GameObject bulletGO = (GameObject)Instantiate(projectile, transform.position, transform.rotation);
            Bullet bullet = bulletGO.GetComponent<Bullet>();
            
            if (bullet != null)
            {
                bullet.SeekTarget(transform.rotation);
            }*/
            Instantiate(projectile, transform.position, transform.rotation);

        }
    }

    /*void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        OnDrawGizmosSelected.DrawWireSphere(transform.position, range);
    }*/
}
