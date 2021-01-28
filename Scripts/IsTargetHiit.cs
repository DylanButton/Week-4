using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTargetHiit : MonoBehaviour
{
public Animator Targetanimator;
 public float health = 50f;
public float defaultHealth = 50f;

[SerializeField] float TimePassed = 5f;


 
public void damaged(float damage){
    health -= damage;
    if (health<=0f){
       Targetanimator.SetBool("BeenHit", true); 
    }


}
public void Update()
{
    if (health <=0 )
    {   
            health = defaultHealth;
            if (health>=50f){
            Targetanimator.SetBool("BeenHit", false); 
    
    }
}
    
}
 
}
