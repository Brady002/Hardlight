using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [Header("Attributes")]
    public float fireRate = 1f;
    public int damage = 10;
    public float projectileSpeed = 5f;
    public float projectileRange = 20f;

    [Header("Unity Setup")]
    [SerializeField] private InputActionReference fireButton;
    public GameObject projectile;
    AudioSource source;
    //public Transform barrel;

    // Start is called before the first frame update
    void Start()
    {
        //source = GetComponent<AudioSource>();
    }

    private void OnEnable() => fireButton.action.performed += Fire;

    private void OnDisable() => fireButton.action.performed -= Fire;

    public void Fire(InputAction.CallbackContext obj)
    {
        GameObject bulletGO = (GameObject)Instantiate(projectile, transform.position, transform.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.Attributes(damage, projectileSpeed, projectileRange); //Passes on attributes to spawned bullet
            source.Play();
        }
    }

}
