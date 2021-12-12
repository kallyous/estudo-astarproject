using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathTargetController : MonoBehaviour
{
    private Transform _myTransform;

    private void Start()
    {
        _myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
                _myTransform.position = hit.point;
            }
        }
    }
}
