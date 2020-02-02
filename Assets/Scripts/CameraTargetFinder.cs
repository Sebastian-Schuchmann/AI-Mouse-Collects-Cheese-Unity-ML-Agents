using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CameraMultiTarget))]
public class CameraTargetFinder : MonoBehaviour
{
    private CameraMultiTarget multiTargetCam;

    public GameObject[] targets;

    void Start()
    {
        multiTargetCam = GetComponent<CameraMultiTarget>();
        multiTargetCam.SetTargets(targets);
    }

    void Update()
    {
        
    }
}
