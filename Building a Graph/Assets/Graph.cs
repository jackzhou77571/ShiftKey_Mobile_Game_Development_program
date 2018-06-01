﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour {
    public Transform pointPrefab;

    [Range(10,100)]
    public int resolution = 10;
    // Use this for initialization
    void Awake()
    {
        float step = 2f / resolution;

        Vector3 scale = Vector3.one *step;
        Vector3 position = Vector3.zero;
        position.x = 0f;
        position.z = 0f;
        for (int i = 0; i < resolution; i++)
        {
            //i = i + 1;
            Transform point = Instantiate(pointPrefab);
            //point.localPosition = Vector3.right*((i+0.5f)/5f-1f);
            position.x = (i + 0.5f) *step - 1f;
            position.y = position.x * position.x;
            point.localPosition = position;
            //point.localScale = Vector3.one / 5f;
            point.localScale = scale;
        }
       
       // point.localPosition = Vector3.right * 2f;
    }
    void Start () {
		
	}
	
	
	void Update () {
		
	}
}
