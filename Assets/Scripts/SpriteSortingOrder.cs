using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SpriteSortingOrder : MonoBehaviour
{
    [SerializeField] private bool runOnce;
    [FormerlySerializedAs("positionOffset")] [SerializeField] private float positionOffsetY;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void LateUpdate()
    {
        var precisionMultiplier = 5f;
        spriteRenderer.sortingOrder = (int) (-(transform.position.y + positionOffsetY) * precisionMultiplier);

        if (runOnce)
        {
            Destroy(this);
        }
    }
}
