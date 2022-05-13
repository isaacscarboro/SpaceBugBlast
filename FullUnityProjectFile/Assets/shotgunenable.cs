using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgunenable : MonoBehaviour
{
    public GameObject shot;
    public float timer;
    public Animator animator;
    public GameObject animated;
    // Start is called before the first frame update
    void Start()
    {
        animator = animated.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         timer -= Time.deltaTime;
        if(timer <= 0){
            gameObject.SetActive(false);
        }
    }
    void OnEnable(){
    timer = .5f;
    Instantiate(shot, this.transform.parent.GetChild(2).position, this.transform.parent.GetChild(2).rotation);
    }
    void OnDisable(){
        animator.SetBool("shot", false);
    }
}