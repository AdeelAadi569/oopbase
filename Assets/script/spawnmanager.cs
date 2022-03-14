using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class spawnmanager : MonoBehaviour
{
    public GameObject[] prefab;
    GameObject conter;
    public Text timer;
    public int timexount=60;
    public Button pause,restart,resume;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=1;
        Timer();
     conter=GameObject.FindGameObjectWithTag("fruit");  
     InvokeRepeating("Spawn",2,3); 
    }
    void Timer(){
         if(timexount>0){
            timexount--;
            timer.text="Timer :"+timexount;
            Invoke("Timer",1);
        }
        else
        Debug.Log("Game Over");
    }

    // Update is called once per frame
    void Update()
    {
       if(timexount==0){
           restart.gameObject.SetActive(true);
           Time.timeScale=0;
       }
    }
    public void Pause(){
       Time.timeScale=0;
       pause.gameObject.SetActive(false);
       restart.gameObject.SetActive(true);
       resume.gameObject.SetActive(true);
    }
    public void Restart(){
      pause.gameObject.SetActive(true);
      resume.gameObject.SetActive(false);
      restart.gameObject.SetActive(false);
      SceneManager.LoadScene(0);
    }
    public void Resume(){
      Time.timeScale=1;
      resume.gameObject.SetActive(false);
      restart.gameObject.SetActive(false);
      pause.gameObject.SetActive(true);
    }
   
    public void Spawn(){
       var xrange=Random.Range(18,-18);
        var zrange=Random.Range(16,8);
        var pos=new Vector3(xrange,0,zrange);
        int i=Random.Range(0,prefab.Length);
        GameObject spawnvar=Instantiate(prefab[i],pos,transform.rotation);
        Destroy(spawnvar,5);
    }
}
