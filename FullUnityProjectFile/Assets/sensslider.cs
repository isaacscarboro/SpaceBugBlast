using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sensslider : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start(){
        if(!PlayerPrefs.HasKey("sens")){
             PlayerPrefs.SetFloat("sens",1f);
        }
        }
    
    
    void Update(){
       
        this.gameObject.GetComponent<Slider>().value = PlayerPrefs.GetFloat("sens");
      
    }
  public void go(){
      PlayerPrefs.SetFloat("sens",this.gameObject.GetComponent<Slider>().value);


  }
}
