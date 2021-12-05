using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuldingGhost : MonoBehaviour
{
    private GameObject spriteGameboGameObject;

    private void Awake()
    {
        spriteGameboGameObject = GameObject.Find("sprite");
        Hide();
    }

    private void Start()
    {
        BuildingManager.Instance.onBuldingSelected += Show;
    }

    private void Update()
    {
        transform.position = UtilsClass.GetMouseWorldPosition();
    }

    private void Show()
    {
        spriteGameboGameObject.gameObject.SetActive(true);

        var sprite = BuildingManager.Instance.GetActiveBuldingType().sprite;
        spriteGameboGameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }
    
    private void Hide()
    {
        spriteGameboGameObject.gameObject.SetActive(false);
    }
}
