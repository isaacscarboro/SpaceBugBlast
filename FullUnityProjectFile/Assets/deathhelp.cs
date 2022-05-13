using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathhelp : MonoBehaviour
{
    public GameObject player;
    public pStats playerStats;
    public int type;
    public ParticleSystem.MainModule sys;
    public float timetillDis = 3f;
    public TreedMove playerMove;
    // Start is called before the first frame update
    void Start()
    {
        sys = this.GetComponent<ParticleSystem>().main;
        player = GameObject.FindGameObjectsWithTag("player")[0];
        playerStats = player.GetComponent<pStats>();
        playerMove = player.GetComponent<TreedMove>();
        type = Random.Range(1,4);
        switch(type){
            case 1:
            sys.startColor = Color.yellow;
            playerMove.mspeed += .05f;
            break;
            case 2:
            sys.startColor = Color.blue;
            playerStats.armor += .2f;
            playerStats.health += 5f;
            playerStats.maxhealth +=5f;
            break;
            
            case 3:
            sys.startColor = Color.green;
            playerStats.damage += 5f;
            break;

            default:
            break;

        }
        transform.LookAt(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
    if(timetillDis <= 0){
        Object.Destroy(this);
    }
    timetillDis -= Time.deltaTime;
    }
    void OnDisable(){
        Object.Destroy(this);
    }

}
