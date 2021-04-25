using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Color _oldColor = Color.white;

    private void OnTriggerEnter2D(Collider2D other)
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        _oldColor = renderer.color;
        renderer.color = Color.green;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.color = _oldColor;
    }
}
