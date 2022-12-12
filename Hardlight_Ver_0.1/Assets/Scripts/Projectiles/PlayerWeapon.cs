using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [Header("Attributes")]
    public float fireRate = 1f;
    public float damage = 10f;
    public float projectileSpeed = 5f;
    public float projectileRange = 20f;

    [Header("Unity Setup")]
    public GameObject projectile;
    AudioSource source;
    //public Transform barrel;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
 
    // Update is called once per frame
    public void Fire()
    {
        Debug.Log("Fired");
        GameObject bulletGO = (GameObject)Instantiate(projectile, transform.position, transform.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.Attributes(damage, projectileSpeed, projectileRange); //Passes on attributes to spawned bullet
            source.Play();
        }
    }

}
