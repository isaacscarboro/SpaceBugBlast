using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgun : MonoBehaviour
{
    public GameObject shot;
    public bool canFire = true;
    public float shootCD = 1f;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Animator>();
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
            shootCD = 1f;
        }
        }
    }
    void fire(){
        animator.SetBool("shot", true);
        shot.SetActive(true);
        
    }
}
