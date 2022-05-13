using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float stage;
    public GameObject player;
    public pStats stats;
    public GameObject npc1;
    public GameObject npc2;
    public GameObject npc3;
    public GameObject npc4;
    public GameObject npc5;
    public GameObject rnpc;
    public GameObject mnpc;
    public NpcStats npcStats1;
    public NpcStats npcStats2;
    public NpcStats npcStats3;
    public NpcStats npcStats4;
    public NpcStats npcStats5;
    public enemyMovement npcmove1;
    public enemyMovement npcmove2;
    public enemyMovement npcmove3;
    public enemyMovement npcmove4;
    public enemyMovement npcmove5;
    public int alive = 5;
    public bool next = false;
    public GameObject portal;
    public Transform other;

    // Start is called before the first frame update
    void Start()
    {
        alive = 5;
        next = false;
        
        player = GameObject.FindGameObjectsWithTag("player")[0];
        stage = player.GetComponent<pStats>().gameStage;
        npc1 = Instantiate(rnpc,  this.transform);
        npcStats1 = npc1.transform.GetChild(0).GetComponent<NpcStats>();
        npcmove1 = npc1.transform.GetChild(0).GetComponent<enemyMovement>();
        npcmove1.other = other;
        npcStats1.holder = this.gameObject;
        npcStats1.armor = stage * 1;
        npcStats1.health = 100 + (stage * 10);
        npcStats1.damage = 100 + (stage * 5);
        npc2 = Instantiate(rnpc,  this.transform);
        npcStats2 = npc2.transform.GetChild(0).GetComponent<NpcStats>();
        npcmove2 = npc2.transform.GetChild(0).GetComponent<enemyMovement>();
        npcStats2.holder = this.gameObject;
        npcStats2.armor = stage * 1;
        npcmove2.other = other;
        npcStats2.health = 100 + (stage * 10);
        npcStats2.damage = 100 + (stage * 5);
        npc3 = Instantiate(rnpc,  this.transform);
        npcStats3 = npc3.transform.GetChild(0).GetComponent<NpcStats>();
        npcmove3 = npc3.transform.GetChild(0).GetComponent<enemyMovement>();
        npcmove3.other = other;
        npcStats3.holder = this.gameObject;  
        npcStats3.armor = stage * 1;
        npcStats3.health = 100 + (stage * 10);
        npcStats3.damage = 100 + (stage * 5);
        
        npc4 = Instantiate(mnpc,  this.transform);
        npcStats4 = npc4.transform.GetChild(0).GetComponent<NpcStats>();
        npcmove4 = npc4.transform.GetChild(0).GetComponent<enemyMovement>();
        npcStats4.holder = this.gameObject;
        npcStats4.armor = stage * 1;
        npcmove4.other = other;
        npcStats4.health = 100 + (stage * 10);
        npcStats4.damage = 100 + (stage * 5);
        npc5 = Instantiate(mnpc,  this.transform);
        npcStats5 = npc5.transform.GetChild(0).GetComponent<NpcStats>();
        npcmove5 = npc5.transform.GetChild(0).GetComponent<enemyMovement>();
        npcmove5.other = other;
        npcStats5.holder = this.gameObject;  
        npcStats5.armor = stage * 1;
        npcStats5.health = 100 + (stage * 10);
        npcStats5.damage = 100 + (stage * 5);



        
    }
    void FixedUpdate(){
        if(alive <= 0 && !next){
        next = true;
        }
        portal.SetActive(next);
    }
}
