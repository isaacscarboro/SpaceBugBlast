using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeAttack : MonoBehaviour
{
    public float lifeTime = 50f;
    public GameObject oP;
    public enemyMovement attackCheck;
    
    // Start is called before the first frame update
    void Start()
    {
      
        oP = this.gameObject.transform.parent.gameObject;
        this.gameObject.transform.SetParent(this.gameObject.transform.parent.parent.GetChild(1).GetChild(2).GetChild(4).GetChild(0).GetChild(0).GetChild(1).GetChild(0).GetChild(0));
        this.transform.localPosition = new Vector3(0f,0f,0f);
        this.transform.localEulerAngles =  new Vector3(0f,0f,0f);
        attackCheck = oP.GetComponent<enemyMovement>();
        attackCheck.animator.SetBool("MAttack",true);
    }

    // Update is called once per frame
    void Update()
    {
        if(oP !=null){
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0){
        attackCheck = oP.GetComponent<enemyMovement>();
        attackCheck.animator.SetBool("MAttack",false);
        Object.Destroy(this.gameObject);
        }
    }}
}
