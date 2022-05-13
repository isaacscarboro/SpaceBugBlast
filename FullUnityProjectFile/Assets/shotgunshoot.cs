using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class shotgunshoot : MonoBehaviour
{
    public ParticleSystem particle;
    public GameObject player;
    public pStats playerStats;
    public NpcStats npcStats;
    public float damage = 1;
    public float timer;
    public enemyMovement npcMove;
    public List<ParticleCollisionEvent> collisionEvents;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        
        player = GameObject.FindGameObjectsWithTag("player")[0];
        playerStats = player.GetComponent<pStats>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        timer -= Time.deltaTime;
        if(timer <= 0){
            Object.Destroy(this.gameObject);
        }
    }
 void OnParticleCollision(GameObject other){
     
     if(other.tag == "Body" || other.tag == "Head"){
     npcStats = other.GetComponent<NpcStats>();
     npcMove = other.GetComponent<enemyMovement>();
     npcStats.health = npcStats.health - (damage / (npcStats.armor /5) * (playerStats.damage * 0.01f));
     npcMove.agro = 5f;
     }
     if(other.tag == "projectile"){
         Object.Destroy(other);
     }
 }
void OnEnable(){
    timer = 5f;
 
}
void OnDisable(){

}
}
