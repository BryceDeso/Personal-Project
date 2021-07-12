﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxeBehavior : MonoBehaviour
{
    public float miningDamage;

    public bool equipped;

    // Update is called once per frame
    void Update()
    {
        Behavior();
    }

    private void Behavior()
    {
        if (equipped == true)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
