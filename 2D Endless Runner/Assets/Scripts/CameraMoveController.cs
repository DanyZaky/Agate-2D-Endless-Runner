﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveController : MonoBehaviour
{
    [Header("Position")]
    public Transform player;
    public float horizOffset;

    private void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = player.position.x + horizOffset;
        transform.position = newPosition;
    }
}
