using System.Collections.Generic;
using UnityEngine;

public class GravityAreaPoint : GravityArea
{
    [SerializeField] private Vector3 center;


    public override Vector3 GetGravityDirection(GravityBody _gravityBody)
    {
        return (center + transform.position - _gravityBody.transform.position).normalized;
    }
}
