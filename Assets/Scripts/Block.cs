﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.countBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        destroyBlock();
    }

    private void destroyBlock()
    {
        FindObjectOfType<GameStatus>().addToScore();
        Destroy(gameObject);
        level.destroyBlocks();
    }
}   
