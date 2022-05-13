using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawn : MonoBehaviour
{
    public Transform player;
    public float timer = .1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if(timer > 0){player = GameObject.FindGameObjectsWithTag("playerfullpos")[0].transform;
         player.position = this.transform.position;
         player.eulerAngles = this.transform.eulerAngles;
         GameObject.FindGameObjectsWithTag("playerfullpos")[0].transform.eulerAngles = this.transform.eulerAngles;
         timer -= Time.deltaTime;}
    }
}
