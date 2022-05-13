using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firePistolm1 : MonoBehaviour
{
    public GameObject flash;
    public bool canFire = true;
    public float shootCD = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canFire && (Input.GetMouseButtonDown(0))){
            fire();
            canFire = false;
        }
        if(!canFire){
        shootCD -= Time.deltaTime;
        if(shootCD <= 0f){
            canFire = true;
            shootCD = 0.3f;
        }
        }
    }
    void fire(){
        flash.SetActive(true);
    }
}
