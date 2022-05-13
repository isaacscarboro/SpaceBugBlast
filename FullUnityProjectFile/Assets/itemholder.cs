using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemholder : MonoBehaviour
{
    public int currentweapon;
    // Start is called before the first frame update
    void Start()
    {
    currentweapon = Random.Range(0,3);
    GameObject.FindGameObjectsWithTag("playerItems")[0].GetComponent<weapons>().swap_weapon(currentweapon);
    GameObject.FindGameObjectsWithTag("player")[0].GetComponent<pStats>().damage += 50;
    Object.Destroy(this.gameObject);
       
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}