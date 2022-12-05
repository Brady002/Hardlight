using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 1f;

    //private Transform target;
    
    /*public void SeekTarget(Quaternion _rotation)
    {
        transform.rotation = _rotation;
    }*/

    // Update is called once per frame
    void Update()
    {
        float distancePerFrame = speed * Time.deltaTime;

        transform.Translate(transform.forward * distancePerFrame, Space.World);
    }
}
