using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visionControl : MonoBehaviour
{
    public Camera cam;
    public float hitcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(1)){
            
            Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane));
            int layerMask = 1 << 6;
            RaycastHit hit;
            Vector3 dir = mouse - cam.transform.position;
            if(Physics.Raycast(cam.transform.position, dir.normalized, out hit, Mathf.Infinity,layerMask)){
            transform.position = hit.point;
            
            }else{
                hitcount++;
                Debug.DrawRay(cam.transform.position, dir.normalized, Color.white, 3.0f, true);
            }       
    }
        
    }

    public void goVision(){
            Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane));
            int layerMask = 1 << 6;
            RaycastHit hit;
            Vector3 dir = mouse - cam.transform.position;
            if(Physics.Raycast(cam.transform.position, dir.normalized, out hit, Mathf.Infinity,layerMask)){
            transform.position = hit.point;

    }else{
                hitcount++;
                Debug.DrawRay(cam.transform.position, dir.normalized, Color.white, 3.0f, true);
            }      
    }
}
