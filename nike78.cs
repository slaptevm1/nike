using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nike78 : MonoBehaviour
{
   public int level = 5; 
   public int health = 5;
   public  float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        health = health + 1;
        print(health);
        level = level + 1;
        print(level);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Cube = transform.position;
        Cube.z += speed * Time.deltaTime;
        transform.position = Cube;
    }
}
