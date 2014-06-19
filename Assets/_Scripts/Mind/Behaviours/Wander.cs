using UnityEngine;
using System.Collections;

public class Wander : AbstractBehaviour
{
    Vector3 direction;
    float tempo;

    public override void Act()
    {
        if (Vector3.Distance(owner.body.m_initpos, transform.position) < owner.body.m_minactionray)
        {
            if (tempo >= 1)
            {
                tempo = 0;
                direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            }
            else
                tempo += Time.deltaTime;            
                
        }
        else
        {
            direction = (owner.body.m_initpos - transform.position).normalized;            
        }

        owner.body.Move(direction);
        
    }

    public override bool Think()
    {
        return true;
    }
}
