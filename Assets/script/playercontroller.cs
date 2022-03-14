using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed=20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      var horizontal=Input.GetAxis("Horizontal");
      var vertical=Input.GetAxis("Vertical");
        Rigidbody playerrb=GetComponent<Rigidbody>();
        playerrb.AddForce(Vector3.forward*vertical*speed,ForceMode.Impulse);
        playerrb.AddForce(Vector3.right*horizontal*speed,ForceMode.Impulse);   
        if(transform.position.x>18){
          transform.position=new Vector3(18,transform.position.y,transform.position.z);
          playerrb.velocity=Vector3.zero;
        }
        if(transform.position.x<-18){
          transform.position=new Vector3(-18,transform.position.y,transform.position.z);
          playerrb.velocity=Vector3.zero;
        }
        if (transform.position.z>16)
        {
          transform.position=new Vector3(transform.position.x,transform.position.y,16);
          playerrb.velocity=Vector3.zero;
        }
        if (transform.position.z<-8)
        {
          transform.position=new Vector3(transform.position.x,transform.position.y,-8);   
          playerrb.velocity=Vector3.zero;
        }
    }
}
