using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballscript : MonoBehaviour
{
    public float timer = 10f;
    public GameObject player;
    public float speed = 5f; 
    public Rigidbody rb;
    public GameObject self;
    public pStats playerStats;
 
    // Start is called before the first frame update
    void Start()
    {
    player = GameObject.FindGameObjectsWithTag("player")[0];
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
    transform.LookAt(player.transform.position);
    rb.AddForce(this.transform.forward * speed, ForceMode.Force);
    timer -= Time.deltaTime;
    if(timer <= 0){
        Object.Destroy(self);
    }
    }
    void OnTriggerEnter(Collider hit){
    if (hit.gameObject == player){
    playerStats = player.GetComponent<pStats>();
    playerStats.health = playerStats.health -20;
    playerStats.damaged = true;
    Object.Destroy(self);
    }
}
}
