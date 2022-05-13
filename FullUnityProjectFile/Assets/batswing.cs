using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batswing : MonoBehaviour
{
    public GameObject shot;
    public float timer;
    public Animator animator;
    public bool canswing = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canswing && (Input.GetMouseButtonDown(0))){
            timer = .5f;
            animator.SetBool("shot", true);
            shot.SetActive(true);
            canswing = false;
        }
         timer -= Time.deltaTime;
        if(timer <= 0){
            animator.SetBool("shot", false);
            shot.SetActive(false);
            canswing = true;
        }
    }
void OnDisable(){
    shot.SetActive(false);
}
}