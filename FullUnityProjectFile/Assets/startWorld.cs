using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startWorld : MonoBehaviour
{

    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject playerhand;
    // Start is called before the first frame update
    void Start()
    {   
        int level = Random.Range(1,4);
        
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

            default:
            break;
    }
    int swap = Random.Range(1,4);
    playerhand.GetComponent<weapons>().swap_weapon(swap);
    }
}
