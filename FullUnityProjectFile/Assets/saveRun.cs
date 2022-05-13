using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveRun : MonoBehaviour
{
    public GameObject controler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void go(){
        controler.GetComponent<endmenu>().menu = 2;

    }
}
