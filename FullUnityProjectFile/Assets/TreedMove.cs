using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreedMove : MonoBehaviour
{
public float jumpCD = .2f;
public float playerGroundedDrag = 6f;
public float playerAirDrag = 2f;
public float airMultiplier = .5f;
public float multiplier = 10f; 
public Vector2 movement;
public float mspeed = 10.0f;
public Vector3 direction;
public Rigidbody rb;
public GameObject cam;
public GameObject directionMovement;
public Vector2 viewAmount;
public Vector2 viewRotation;
public float sens;
public bool isGround;
public float height = 2f;
public float jumpForce= 15f;
public LayerMask ground;
public Vector3 slopeDir;
public bool slope;
public RaycastHit hit;
public bool slide;
public GameObject groundChecker;
public float sprint;
public float jumps = 2;
public float tempJumps;
public LayerMask interactable;
public Transform head;
public GameObject weapons;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("sens")){
        sens = PlayerPrefs.GetFloat("sens");
        }else{sens = 1f;}
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {




        isGround = Physics.CheckSphere(groundChecker.transform.position, 0.4f, ground);
        drag();
        if (isGround){
            tempJumps = jumps;
        }
        if (Input.GetKeyDown("space") && tempJumps > 0) {
        jump();
        tempJumps = tempJumps -1;
        }
        mouse();
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        cam.transform.localRotation = Quaternion.Euler(viewRotation.x, viewRotation.y,0);
        directionMovement.transform.rotation = Quaternion.Euler(0,viewRotation.y,0);
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        direction = (directionMovement.transform.forward * movement.y + directionMovement.transform.right * movement.x);


     if (Input.GetKey("c") ) {
        slide = true;
        }else{
            slide = false;
        }
    
    if (Input.GetKey("left shift")) {
        sprint = 2f;
        }else{
            sprint = 1f;
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








    private void FixedUpdate(){
      slope = slopeCheck();
        move();
      if (Input.GetKeyDown("e")){
            if(Physics.Raycast(head.transform.position, head.transform.forward,out hit, 50f, interactable)){
                weapons.GetComponent<weapons>().swap_weapon(hit.transform.gameObject.GetComponent<itemholder>().currentweapon);  

                          }
        }
       
        
    }
    void drag(){
    if(isGround){
        
       rb.drag = playerGroundedDrag;
    }else{
        
        rb.drag = playerAirDrag;
    }
    }

    void move(){
        if(isGround && !slope && !slide){
        rb.AddForce(direction.normalized * mspeed * sprint * multiplier,ForceMode.Acceleration);
        }
        else if(isGround && slope && !slide){
        rb.AddForce(slopeDir.normalized * mspeed * sprint * multiplier,ForceMode.Acceleration);
        }
        else if(!isGround && !slide){
        rb.AddForce(direction.normalized * mspeed * sprint * multiplier * airMultiplier,ForceMode.Acceleration);
        }else if(slide && slope){
            rb.AddForce(slopeDir.normalized * mspeed * sprint * multiplier * 1.2f,ForceMode.Acceleration);
        }else if(slide && !slope){
            rb.drag = 0;
            float tempy = rb.velocity.y;
            rb.velocity = new Vector3(rb.velocity.x,0,rb.velocity.z);
            rb.velocity = directionMovement.transform.forward * rb.velocity.magnitude;
            rb.velocity = new Vector3(rb.velocity.x,tempy,rb.velocity.z);
        }

        }
    
    void mouse(){
        viewAmount.x = Input.GetAxisRaw("Mouse X") * sens;
        viewAmount.y = Input.GetAxisRaw("Mouse Y") * sens;

        viewRotation.y += viewAmount.x * sens;
        viewRotation.x -= viewAmount.y * sens;
        viewRotation.x = Mathf.Clamp(viewRotation.x, -90f,90f);
    }
    void jump(){
        
        rb.velocity = new Vector3(rb.velocity.x,rb.velocity.y + jumpForce,rb.velocity.z);
        
    }
    void slideControl(){

    }
}
