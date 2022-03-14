using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fruit : MonoBehaviour
{
    public Text score;
    public static int counter;

    // Start is called before the first frame update
    void Start()
     {
          score=GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        AddScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void AddScore(){
        Debug.Log("Add the Score");
    }
   
}
