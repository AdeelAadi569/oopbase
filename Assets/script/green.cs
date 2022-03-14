using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class green : fruit
{
    // Start is called before the first frame update
  void Start()
     {
    
          score=GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void AddScore(){
        Debug.Log("collided with "+gameObject.name +"Recived " +counter +"Score");
            counter+=20;
            score.text="Score :"+counter;
            Destroy(gameObject);
    }
     public void OnCollisionEnter(Collision col){
        if(col.gameObject.tag=="player"){
          
            AddScore();
        }
    }
}