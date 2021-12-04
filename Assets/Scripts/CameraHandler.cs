using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraHandler : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera CMCam;
    [Range(10f, 30f)]
    [SerializeField] float camSpeed = 10f;
    private float orthographicSize;
    private float targetOrthographicSize;

    private void Start()
    {
        orthographicSize = CMCam.m_Lens.OrthographicSize;
        targetOrthographicSize = orthographicSize;
    }

    private void Update()
    {
        HandleMovement(); 
        HandleZoom();
    }

    private void HandleMovement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 moveDir = new Vector3(x, y).normalized;

        transform.position += moveDir * camSpeed * Time.deltaTime;
    }

    private void HandleZoom()
    {
        float zoomAmount = 2f;

        targetOrthographicSize += Input.mouseScrollDelta.y * zoomAmount;

        float minOrtographicSize = 10f;
        float maxOrtographicSize = 30f;
        targetOrthographicSize = Mathf.Clamp(targetOrthographicSize, minOrtographicSize, maxOrtographicSize);

        float zoomSpeed = 5f;
        orthographicSize = Mathf.Lerp(orthographicSize, targetOrthographicSize, Time.deltaTime * zoomSpeed);

        CMCam.m_Lens.OrthographicSize = orthographicSize;
    }
}
