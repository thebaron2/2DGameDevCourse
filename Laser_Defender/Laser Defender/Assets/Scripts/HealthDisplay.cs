﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    Text healthText;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();
    }

    private void UpdateHealth()
    {
        int health = player.GetHealth();
        if (health > 0)
        {
            healthText.text = health.ToString();
        }
        else
        {
            healthText.text = "0";
        }
    }
}
