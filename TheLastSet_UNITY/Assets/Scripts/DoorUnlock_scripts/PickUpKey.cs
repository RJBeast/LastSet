﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{

    public GameObject pickUp;
    public GameObject original;

    public static string hasKey;

    // Start is called before the first frame update
    void Start()
    {
        original.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Q))
        {
            pickUp.SetActive(false);
            original.SetActive(true);
            hasKey = "Yes";
            Debug.Log("has Key");
        }
    }

    void KeyOff()
    {
        original.SetActive(false);
    }
}
