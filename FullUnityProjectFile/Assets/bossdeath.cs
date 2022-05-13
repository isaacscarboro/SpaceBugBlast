using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossdeath : MonoBehaviour
{
    public GameObject death;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnDestroy(){
      GameObject.FindGameObjectsWithTag("player")[0].GetComponent<pStats>().health = GameObject.FindGameObjectsWithTag("player")[0].GetComponent<pStats>().maxhealth;
        
    Instantiate(death, new Vector3(this.transform.position.x,this.transform.position.y - 3, this.transform.position.z ),this.transform.rotation);
    }
}
