using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NpcStats : MonoBehaviour
{
    public float health = 100f;
    public float armor = 0f;
    public float damage = 100f;
    public float score = 100f;
    public Transform healthBar;
    public GameObject hpTextObj;
    public Transform healthBarEmp;
    public Text hpText;
    public GameObject self;
    public GameObject player;
    public pStats playerStats;
    public GameObject death;
    public GameObject deathHelp;
    public GameObject holder;
    public float iframes =0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("player")[0];
        playerStats = GameObject.FindGameObjectsWithTag("player")[0].GetComponent<pStats>();
        hpText = hpTextObj.GetComponent<Text>();
        healthBarEmp.localScale = new Vector3((health / 100f)* 3, .1f, 1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(this.transform.position.y <= -100){
            this.health = 0;
        }
        if(iframes >= 0){iframes -= Time.deltaTime;}
        if(this.gameObject != null){
    healthBar.localScale = new Vector3((health / 100f)* 3, .1f, 1);
    hpText.text = ("HP: "+ Mathf.Round(health));
    if(health <= 1){
        Object.Destroy(self);
    }}
    }
    void OnDestroy(){
    if(player != null){
        if(this.gameObject != null){
            if(SceneManager.GetActiveScene().name == "FPS TEst"){
    
    
    GameObject.FindGameObjectsWithTag("player")[0].GetComponent<pStats>().addScore(score);
    Instantiate(death,  this.transform.position,this.transform.rotation);
    Instantiate(deathHelp,  this.transform.position,this.transform.rotation);
    if(holder.tag == "boss"){
    bossroom holdscript = holder.GetComponent<bossroom>();
    holdscript.alive -= 1;
    }else{
    script holdscript = holder.GetComponent<script>();
    holdscript.alive -= 1;
    }
    }}}}
}
