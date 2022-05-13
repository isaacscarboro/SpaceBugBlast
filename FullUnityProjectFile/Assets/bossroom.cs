using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossroom : MonoBehaviour
{
    public float stage;
    public GameObject player;
    public pStats stats;
    public GameObject npc1;
    public NpcStats npcStats1;
    public enemyMovement npcmove1;
    public int alive = 1;
    public bool next = false;
    public GameObject portal;
    public Transform other;
    public GameObject boss;

void Start(){
    alive = 1;
        player = GameObject.FindGameObjectsWithTag("player")[0];
        stats = player.GetComponent<pStats>();
        stage = stats.gameStage;
        npc1 = Instantiate(boss,  this.transform);
        npcStats1 = npc1.transform.GetChild(0).GetComponent<NpcStats>();
        npcmove1 = npc1.transform.GetChild(0).GetComponent<enemyMovement>();
        npcmove1.other = other;
        npcStats1.holder = this.gameObject;
        npcStats1.armor = stage * 2;
        npcStats1.health = 100 + (stage * 100);
        npcStats1.damage = 100 + (stage * 50);


}

void FixedUpdate(){
        if(alive <= 0 && !next){
        next = true;
        }
        portal.SetActive(next);
    }
}
