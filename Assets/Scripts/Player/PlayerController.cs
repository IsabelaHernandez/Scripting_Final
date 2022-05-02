using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 dragOffset;
    private BoxCollider2D boxCollider2D;

    private void Awake()
    {
        mainCamera = Camera.main;
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void OnMouseDown() { dragOffset = transform.position - MousePosition(); }

    private void OnMouseDrag() { boxCollider2D.enabled = false; transform.position = MousePosition() + dragOffset; }
    private void OnMouseUp() { boxCollider2D.enabled = true; }

    private Vector3 MousePosition()
    {
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition); mousePosition.z = 0;
        return mousePosition;
    }

}