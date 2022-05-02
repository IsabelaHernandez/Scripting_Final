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

    private void OnMouseDown() { dragOffset = transform.position - MousePosition(); } //calcula el centro del objeto que se está agarrando menos la posición del mouse

    private void OnMouseDrag() { boxCollider2D.enabled = false; transform.position = MousePosition() + dragOffset; } //se deshabilitan los box colliders para que mientras se arrastra el player no vaya a interactuar con los enemigos
    private void OnMouseUp() { boxCollider2D.enabled = true; } //se vuelven a activar los box colliders

    private Vector3 MousePosition()
    {
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition); mousePosition.z = 0; //mousePosition calcula donde está el mouse con respecto a la main camera
        return mousePosition;
    }

}