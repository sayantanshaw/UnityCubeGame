﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Object")
        {
            movement.enabled = false;
            FindObjectOfType<GameManeger>().EndGame();
        }
    }
}
