using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseview : MonoBehaviour
{
    public Vector2 amount;
    public float sens = 800;
    void Start(){

        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        amount.x += Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime;
        amount.y += Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime;
         if (amount.y < -90){amount.y = -90;} 
        if (amount.y > 90){amount.y = 90;} 
        transform.localRotation = Quaternion.Euler(-amount.y, amount.x, 0);
    }
}
