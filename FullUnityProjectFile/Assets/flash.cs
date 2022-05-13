using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flash : MonoBehaviour
{
    public float timer = .5f;
    public LayerMask playerBullets;
    public RaycastHit hit;
    public Transform head;
    public float damage = 10f;
    public pStats playerStats;
    public GameObject player;
    public NpcStats hitNpc;
    public GameObject npc;
    public enemyMovement hitNpcMove;
    // Start is called before the first frame update
    void Start()
    {
       playerStats = player.GetComponent<pStats>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f ){
        gameObject.SetActive(false);
        }
    }
    void OnEnable(){
        timer = .5f;
        if(Physics.Raycast(head.transform.position, head.transform.forward,out hit, Mathf.Infinity, playerBullets)){
            if(hit.collider.tag == "Body"){
            npc = hit.collider.gameObject;
            hitNpc = npc.GetComponent<NpcStats>();
            hitNpcMove = npc.GetComponent<enemyMovement>();
            hitNpc.health = hitNpc.health - (damage / (hitNpc.armor / 2) * (playerStats.damage * 0.01f));
            hitNpcMove.agro = 5f;
        } if(hit.collider.tag == "Head"){
            npc = hit.collider.gameObject.transform.parent.gameObject;
            hitNpc = npc.GetComponent<NpcStats>();
            hitNpcMove = npc.GetComponent<enemyMovement>();
            hitNpc.health = hitNpc.health - (damage * (playerStats.damage * 0.01f));
            hitNpcMove.agro = 5f;

        }
        if(hit.collider.tag == "projectile"){
            Object.Destroy(hit.collider.gameObject);
        }
        }
    }
}
