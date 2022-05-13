using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour
{
    public GameObject player;
    public pStats playerStats;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject boss;
    public GameObject currentLevel;
    public bool once = true;
    // Start is called before the first frame update
    void Start()
    {   
        currentLevel = this.transform.parent.gameObject;
        once = true;
        player = GameObject.FindGameObjectsWithTag("player")[0];
        playerStats = player.GetComponent<pStats>();
        this.gameObject.SetActive(false);
    }

    
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider collision){
         if(once){
        if (collision.gameObject == player){
         playerStats.gameStage += 1;
         int level = Random.Range(1,4);
         if(((playerStats.gameStage- 1) % 3) == 0){
             level = 5;
         }
         once = false;
            switch(level){
            case 1:
            Instantiate(level1,  new Vector3(0,0,0), new Quaternion(0f, 0f, 0f, 1f));
            
            break;
            case 2:
            Instantiate(level2,  new Vector3(0,0,0), new Quaternion(0f, 0f, 0f, 1f));
            break;
            
            case 3:
            Instantiate(level3,  new Vector3(0,0,0), new Quaternion(0f, 0f, 0f, 1f));
            break;
            case 5:
            Instantiate(boss,new Vector3(0,0,0), new Quaternion(0f, 0f, 0f, 1f));
            break;

            default:
            break;
    }
    Object.Destroy(currentLevel);
    }
         }
    } 
}
