using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnemyTo : MonoBehaviour
{
    public Transform controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Slerp(this.transform.position , controller.position, 1f);
        this.transform.rotation = controller.rotation;
    }
}
