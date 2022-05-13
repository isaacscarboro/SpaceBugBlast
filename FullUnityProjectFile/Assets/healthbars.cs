using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthbars : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        transform.LookAt(player);
    }
}
