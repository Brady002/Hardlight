using System.Collections.Generic;
using UnityEngine;

public class GravityAreaInversePoint : GravityArea
{
    [SerializeField] private Vector3 center;

    public override Vector3 GetGravityDirection(GravityBody _gravityBody)
    {
        return (_gravityBody.transform.position - (center + transform.position)).normalized;
    }
}
