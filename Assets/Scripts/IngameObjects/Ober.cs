﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ober : MonoBehaviour
{
    private SpriteRenderer sr;
    [SerializeField] Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        if (SessionData.CSESSION != null)
        {
            UpdateSprite(SessionData.CSESSION.character);
        }
    }

    public void UpdateSprite(int val) {
        Debug.Log("val = " + val);
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = sprites[val];
        if (val == 1)
        {
            transform.position = new Vector3(0, 1.82f, 0);
        } else
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
