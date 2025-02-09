using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof (LineRenderer))]
public class EyeTrackingRay : MonoBehaviour
{
    [SerializeField]
    private float rayWidth = 0.2f;
    [SerializeField]
    private float rayDistance = 5f;
    private LayerMask layerToInclude;
    private LineRenderer lineRenderer;
    [SerializeField] Transform base_point;
    [SerializeField]
    private Color rayColorDefault = Color.yellow;
    [SerializeField]
    private Color rayColorHover = Color.red;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();    
        SetUpRay();
    }

    void SetUpRay() {
        lineRenderer.useWorldSpace = false;
        lineRenderer.positionCount = 2;
        lineRenderer.startWidth = rayWidth;
        lineRenderer.endWidth = rayWidth;
        lineRenderer.startColor = rayColorDefault;
        lineRenderer.endColor = rayColorDefault;
        lineRenderer.SetPosition(0, new Vector3(transform.position.x,0,transform.position.z));
        lineRenderer.SetPosition(1, new Vector3(transform.position.x,transform.localPosition.y,transform.position.z + rayDistance));
        /*        lineRenderer.SetPosition(1, transform.position+Vector3.forward * rayDistance);*/
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        transform.position = base_point.transform.position;
        Vector3 raycastDirection = transform.TransformDirection(Vector3.forward) * rayDistance;
        if (Physics.Raycast(transform.position, raycastDirection, out hit)){//, Mathf.Infinity, layerToInclude)) {
            lineRenderer.startColor = rayColorHover;
            lineRenderer.endColor = rayColorHover;

        }
        else {
            lineRenderer.startColor = rayColorDefault;
            lineRenderer.endColor = rayColorDefault;
        }
    }
}
