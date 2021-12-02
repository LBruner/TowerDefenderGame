﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour
{
    private BuldingTypeSO buildingtype;
    private float timer;
    private float timerMax;

    private void Awake()
    {
        buildingtype = GetComponent<BuildingTypeHolder>().buildingType;
        timerMax = buildingtype.resourceGeneratorData.timerMax;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            Debug.Log("M");
            foreach (var resourceType in buildingtype.resourceGeneratorData.resourceType)
            {
                Debug.Log("OI");
                ResourceManager.Instance.AddResource(resourceType, 1);
            }

            timer += timerMax;
        }
    }
}
