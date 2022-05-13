using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batdamage : MonoBehaviour

{
public float damage = 100;
public GameObject player;
public pStats playerStats;
   void Start()
    {
        
        player = GameObject.FindGameObjectsWithTag("player")[0];
        playerStats = player.GetComponent<pStats>();
       
    }
     private void OnTriggerEnter(Collider other)
    {
        if(other != null){
         if(other.gameObject.tag == "Body" || other.gameObject.tag == "Head"){
             if(other.gameObject.GetComponent<NpcStats>().iframes <= 0f){
        other.gameObject.GetComponent<NpcStats>().health -= ((damage / (other.gameObject.GetComponent<NpcStats>().armor /5)) * (playerStats.damage * 0.01f));
        other.gameObject.GetComponent<NpcStats>().iframes = .5f; 
             }
    }if(other.gameObject.tag == "projectile"){
        Object.Destroy(other.gameObject);
    }}
}
}