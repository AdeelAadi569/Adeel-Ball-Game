using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject[] ball;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBall",2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBall(){
        var randomspawn=Random.Range(0,ball.Length);
        Vector3 pos=new Vector3(18,Random.Range(-3,9),0);
        Instantiate(ball[randomspawn],pos,ball[randomspawn].transform.rotation);
        Instantiate(ball[randomspawn],new Vector3(-15.4f,Random.Range(-3,9),0),ball[randomspawn].transform.rotation);
    }
}
