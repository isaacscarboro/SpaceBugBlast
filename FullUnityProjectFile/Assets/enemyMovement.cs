using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public Rigidbody rb;
    public bool slope;
    public Vector3 slopeDir;
    public Vector3 direction;
    public Transform other;
    public RaycastHit hit;
    public float height =7.557514f;
    public bool isGround;
    public GameObject groundCheck;
    public LayerMask ground;
    public float agroRange = 10f;
    public float attackRange = 4f;
    public float agro;
    public Transform player;
    public float shotCD = 2f;
    public bool shotBool = false;
    public bool shotBoolDelay = false;
    public GameObject shotType;
    public Animator animator;
    public GameObject Model;
    public float tempAttackDelay = 2f;
    public int type = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        
      
        rb = GetComponent<Rigidbody>();
        animator = Model.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics.CheckSphere(groundCheck.transform.position, 0.5f, ground);
       
        if(shotCD <= 0 && shotBool){
            
            shotBool = false;
            shotCD = 2f;
        }else if(shotCD > 0 && shotBool){
            shotCD -= Time.deltaTime;
        }
        if (agro > 0){
            agro -= Time.deltaTime;
        }
        if(shotBoolDelay){
            tempAttackDelay -= Time.deltaTime;
        } 
        if(tempAttackDelay <= 1.4f && shotBoolDelay){
        GameObject tempshot = Instantiate(shotType,  this.transform);
        animator.SetBool("Attack",false);
       if(type == 0){
        tempshot.transform.position = new Vector3(tempshot.transform.position.x,tempshot.transform.position.y + 1.45f,tempshot.transform.position.z);
       }
        tempAttackDelay = 2f;
        shotBool = true;
        shotBoolDelay = false;
        }
        }
    
    
    void FixedUpdate(){
      direction = transform.forward;
         if(Vector3.Distance(new Vector3(player.position.x, 0, player.position.z),new Vector3(transform.position.x, 0, transform.position.z)) <= agroRange){
             agro = 5f; 
         }
        if(agro > 0){
            transform.LookAt(new Vector3(player.position.x , this.transform.position.y, player.position.z));
            float tempy = rb.velocity.y;
            rb.velocity = new Vector3(rb.velocity.x,0,rb.velocity.z);
            rb.velocity = transform.forward * rb.velocity.magnitude;
            rb.velocity = new Vector3(rb.velocity.x,tempy,rb.velocity.z);
        }
         if(Vector3.Distance(new Vector3(player.position.x, 0, player.position.z),new Vector3(transform.position.x, 0, transform.position.z)) < attackRange){
        transform.LookAt(new Vector3(player.position.x , this.transform.position.y, player.position.z));
            rb.velocity = new Vector3(0,rb.velocity.y,0);
            
            if(!shotBool){
                attack();
                }
        }
         if(agro <= 0 && Vector3.Distance(new Vector3(other.position.x, 0, other.position.z),new Vector3(transform.position.x, 0, transform.position.z)) >= 20f){
            
            transform.LookAt(new Vector3(other.position.x + Random.Range(-5f,5f), this.transform.position.y, other.position.z+ Random.Range(-5f,5f)));
            float tempy = rb.velocity.y;
            rb.velocity = new Vector3(rb.velocity.x,0,rb.velocity.z);
            rb.velocity = transform.forward * rb.velocity.magnitude;
            rb.velocity = new Vector3(rb.velocity.x,tempy,rb.velocity.z);
           
        }
        
        move();
    }
    void move(){
   if (isGround ){
    
        rb.AddForce(transform.forward * 25 ,ForceMode.Acceleration);
    }


    }
      public bool slopeCheck(){
          if(Physics.Raycast(transform.position, Vector3.down, out hit, height/ 2 +.5f)){
              if(hit.normal != Vector3.up){
                  slopeDir = Vector3.ProjectOnPlane(direction,hit.normal);
                  return true;
              }
          }else{
            return false;
        }
    return false;
    }
    void attack(){
        
        animator.SetBool("Attack",true); 
        shotBoolDelay = true;
        
       
    }



}
