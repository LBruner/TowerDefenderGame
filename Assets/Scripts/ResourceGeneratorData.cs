using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[System.Serializable]
public class ResourceGeneratorData
{
    public float timerMax;
    public ResourceTypeSO resourceType;
    [FormerlySerializedAs("resourceDetectionRaius")] public float resourceDetectionRadius;
    public int maxResourceAmount;
}
