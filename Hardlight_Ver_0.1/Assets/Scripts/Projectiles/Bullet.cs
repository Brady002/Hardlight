using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 1f;
    public float damage = 1f;
    public float range = 1f;
    private Vector3 startPos;
    
    public void Attributes(float _damage, float _projectileSpeed, float _projectileRange)
    {
        damage = _damage;
        speed = _projectileSpeed;
        range = _projectileRange;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float velocity = speed * Time.deltaTime;

        transform.Translate(transform.forward * velocity, Space.World);

        if (Vector3.Distance(transform.position, startPos) >= range)
        {
            Destroy(gameObject);
            return;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        return;
    }

}
