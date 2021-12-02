using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance { get; private set; }
    public Action onResourceUpdated;

    private Dictionary<ResourceTypeSO, int> resourceAmountDictionary;

    private void Awake()
    {
        Instance = this;

        resourceAmountDictionary = new Dictionary<ResourceTypeSO, int>();

        ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(typeof(ResourceTypeListSO).Name);

        foreach (ResourceTypeSO resourceType in resourceTypeList.list)
        {
            resourceAmountDictionary.Add(resourceType, 0);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(typeof(ResourceTypeListSO).Name);
            AddResource(resourceTypeList.list[0], 5);
        }
    }

    public void AddResource(ResourceTypeSO type, int amount)
    {
        resourceAmountDictionary[type] += amount;

        onResourceUpdated?.Invoke();
    }

    public int GetResourceAmount(ResourceTypeSO resourceType)
    {
        return resourceAmountDictionary[resourceType];
    }
}
