using System.Collections.Generic;
using UnityEngine;

public class GravityAreaFaceX : GravityArea
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 center;

    private Vector3 lockX = new Vector3(0f, 1f, 1f);

    public override Vector3 GetGravityDirection(GravityBody _gravityBody)
    {
        return (Vector3.Scale((center + transform.position) - _gravityBody.transform.position, lockX)).normalized;
    }
}
