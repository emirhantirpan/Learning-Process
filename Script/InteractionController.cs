using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionController : MonoBehaviour
{
    [SerializeField] Camera cam;

    public bool PerformRaycast(out RaycastHit hit, float maxDistance = Mathf.Infinity)
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Ray ray = cam.ScreenPointToRay(mousePosition);

        return Physics.Raycast(ray, out hit, maxDistance);
    }
}
