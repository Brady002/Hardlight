using UnityEngine;

public class GravityAreaUp : GravityArea
{
    public float gForce = 10;

    public override Vector3 GetGravityDirection(GravityBody _gravityBody)
    {
        return -transform.up;
    }

}
