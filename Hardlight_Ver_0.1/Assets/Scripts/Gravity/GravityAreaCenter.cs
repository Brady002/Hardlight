using System.Collections.Generic;
using UnityEngine;

public class GravityAreaCenter : GravityArea
{
    public float gForce = 1;

    public override Vector3 GetGravityDirection(GravityBody _gravityBody)
    {
        return (transform.position - _gravityBody.transform.position * gForce).normalized;
    }
}
