using UnityEngine;
using System.Collections;

public class MoveTarget : AbstractBehaviour{

    public float timer = 2;
    public override void Act()
    {
        if (owner.target != null)
        {
            Vector3 t_direction = (owner.target.transform.position - transform.position).normalized;
            owner.body.Move(t_direction);

            Debug.Log(t_direction);
        }
    }

    public override bool Think()
    {
        if (timer >= 1.1)
        {
            //Debug.Log("I think Im fucking shooting here");
            timer = 0;
            return true;
        }
        timer += 0.0100f;
        return false;
    }
}
