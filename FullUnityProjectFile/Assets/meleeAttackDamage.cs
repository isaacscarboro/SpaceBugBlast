using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeAttackDamage : MonoBehaviour
{
    public GameObject player;
    public pStats playerStats;
 
    // Start is called before the first frame update
    void Start()
    {
    player = GameObject.FindGameObjectsWithTag("player")[0];
    
    }


    
    void OnTriggerEnter(Collider hit){
    if (hit.gameObject == player){
    playerStats = player.GetComponent<pStats>();
    playerStats.health = playerStats.health -30;
    playerStats.damaged = true;
    Object.Destroy(this.transform.parent.gameObject);
    }
}
}

