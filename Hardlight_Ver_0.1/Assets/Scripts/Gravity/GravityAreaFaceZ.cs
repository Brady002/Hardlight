using System.Collections.Generic;
using UnityEngine;

public class GravityAreaFaceZ : GravityArea
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 center;

    private Vector3 lockZ = new Vector3(1f, 1f, 0f);

    public override Vector3 GetGravityDirection(GravityBody _gravityBody)
    {
        return (Vector3.Scale((center + transform.position) - _gravityBody.transform.position, lockZ)).normalized;
    }
}
