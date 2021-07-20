﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIBehavior : MonoBehaviour
{
    [SerializeField]
    private UIManagerBehavior _UIManager;

    [SerializeField]
    private GameObject inventoryUI;

    [SerializeField]
    private Text iron;
    [SerializeField]
    private Text oakWood;
    [SerializeField]
    private Text weapon;
    [SerializeField]
    private Text pickaxe;

    private bool inventoryOpen;


    // Start is called before the first frame update
    void Start()
    {
        inventoryOpen = false;   
    }

    // Update is called once per frame
    void Update()
    {
        OpenInventory();
        UpdateUI();
    }

    private void OpenInventory()
    {
        if (Input.GetKeyDown(KeyCode.I) && inventoryOpen == false)
        {
            inventoryUI.SetActive(true);
            inventoryOpen = true;
        }
        else if (Input.GetKeyDown(KeyCode.I) && inventoryOpen == true)
        {
            inventoryUI.SetActive(false);
            inventoryOpen = false;
        }
    }

    private void UpdateUI()
    {
        iron.text = ("Iron held: " + _UIManager._player._ironHeld);
        oakWood.text = ("Oak Wood Held: " + _UIManager._player._oakWoodHeld);
        weapon.text = ("Weapon: " + _UIManager._player._weapon);
        pickaxe.text = ("Pickaxe: " + _UIManager._player._pickaxe);
    }

}
