﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resetter : MonoBehaviour
{
    public Transform physicsRootChild;
    ResetableRigidbody[] resetables;

    void Awake()
    {
        resetables = GetComponentsInChildren<ResetableRigidbody>();
    }

    public void ResetRig()
    {
        PhysicsRigUtils.FullResetRig(transform, resetables, physicsRootChild);
    }
}
