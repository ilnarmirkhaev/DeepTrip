using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingMachine : MonoBehaviour
{
    private int _healingPoints = 20;

    private Boolean _isUsed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HealPlayer(Player player)
    {
        if (!_isUsed)
        {
            _isUsed = true;
            player.health += _healingPoints;
        }
    }
}
