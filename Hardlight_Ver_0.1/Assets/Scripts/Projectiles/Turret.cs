using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [Header("Attributes")]
    public float activeRange = 5.0f;
    private float turnSpeed = 5f;
    public float fireRate = 1f;
    public int damage = 10;
    public float projectileSpeed = 5f;
    public float projectileRange = 20f;

    [Header("Unity Setup")]
    public GameObject player;
    private float distanceToTarget;
    private float fireCooldown = 0f;
    public GameObject projectile;
    private Quaternion defRot;
    public Transform barrel;

    // Start is called before the first frame update
    void Start()
    {

       //player = GameObject.Find("Player");
        defRot = transform.rotation;
        InvokeRepeating("FindTarget", 0f, 0.2f);
    }

    private void FindTarget() //Finds where to aim. In this case the player's position
    {
        distanceToTarget = Vector3.Distance(transform.position, player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (distanceToTarget < activeRange) //Checks to see if target is close enough to turret
        {
            Vector3 direction = player.transform.position - transform.position; //Sets turret to face its target
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            Vector3 rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * turnSpeed).eulerAngles;
            transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);

            if (fireCooldown <= 0f) //Sets the rate of fire of the turret
            {
                Shoot();
                fireCooldown = 1f / fireRate;
            }

            fireCooldown -= Time.deltaTime;
        } else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, defRot, Time.deltaTime * turnSpeed); //Returns the turret to its default position when no target is acquired
        }

        

        void Shoot()
        {
            GameObject bulletGO = (GameObject)Instantiate(projectile, barrel.position, barrel.rotation);
            Bullet bullet = bulletGO.GetComponent<Bullet>();
            
            if (bullet != null)
            {
                bullet.Attributes(damage, projectileSpeed, projectileRange); //Passes on turret's attributes to spawned bullet
            }

        }
    }

    /*void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        OnDrawGizmosSelected.DrawWireSphere(transform.position, range);
    }*/
}
