﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] spawnobject;


    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        //objects = new GameObject[]
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(spawnobject[Random.Range(0,3)], transform.position, transform.rotation);
    }
}
