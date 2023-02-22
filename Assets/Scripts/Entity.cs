using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public float HP = 500.0f;
  
    public bool IsDead = false;


    public void Damage(float Damage)
    {
        HP -= Damage;
        if (HP <= 0)
        {
            if (!IsDead)
            {
                IsDead = true;
                Die();
            }
        }
    }

    public virtual void Die()
    {
        
        Destroy(gameObject);
       
    }

    

    public IEnumerator DestroyOverSeconds(float time, GameObject go)
    {
        yield return new WaitForSeconds(time);
        Destroy(go);
    }
}
