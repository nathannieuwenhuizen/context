﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinningBottle : MonoBehaviour
{
    private RectTransform rt;
    // Start is called before the first frame update
    private float speed = 7f;
    private float maxSpeed = 25f;
    private float cspeed = 0f;
    void Start()
    {
        rt = GetComponent<RectTransform>();
    }
    private IEnumerator SlowDown()
    {
        float waitTime = Random.value * 1f;
        yield return new WaitForSeconds(waitTime);
        while (cspeed > 0)
        {
            cspeed -= .1f;
            yield return new WaitForFixedUpdate();
        }
    }

    public void Spin()
    {
        StopAllCoroutines();
        cspeed += speed;
        cspeed = Mathf.Min(cspeed, maxSpeed);
        StartCoroutine(SlowDown());
    }
    // Update is called once per frame
    void Update()
    {
        if (cspeed > 0)
        {
            rt.transform.Rotate(new Vector3(0, 0, cspeed));
        }
    }
}