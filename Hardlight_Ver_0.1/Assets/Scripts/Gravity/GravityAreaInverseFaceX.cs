using System.Collections.Generic;
using UnityEngine;

public class GravityAreaInverseFaceX : GravityArea
{
    [SerializeField] private Vector3 center;

    private Vector3 lockZ = new Vector3(0f, 1f, 1f);
    private Vector3 rotationAngle;

    public override Vector3 GetGravityDirection(GravityBody _gravityBody)
    {
        return (Vector3.Scale(_gravityBody.transform.position - (center + transform.position), lockZ)).normalized;
    }
}
