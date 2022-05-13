using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sou : MonoBehaviour
{
    public float timer = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0){
            timer = 1f;
            this.gameObject.SetActive(false);
        }
    }
}
