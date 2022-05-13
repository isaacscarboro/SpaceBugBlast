using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pMove : MonoBehaviour
{
     public Transform player;
     public float smooth = .5f;
     public Transform target;
     public bool canLook = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = player.position;
        transform.position = Vector3.Slerp(transform.position, newPos, smooth);
        look();
    }
    public void look(){
        if(canLook){
        transform.LookAt(target);
        }
    }
}
