using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class PointerManager : MonoBehaviour, IMixedRealityPointerHandler
{
    void IMixedRealityPointerHandler.OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        Debug.Log("OnPointerClicked");

        IPointerResult result = eventData.Pointer.Result;
        Debug.Log($"Pointer ({result.Details.Point})");

        Vector3 pos = result.Details.Point;
        Vector3 nor = result.Details.Normal;

        var obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        obj.transform.localScale = Vector3.one * 0.1f;
        obj.transform.position = pos;
        obj.transform.rotation = Quaternion.LookRotation(nor);
        obj.AddComponent<Rigidbody>().drag = 10.0f;
    }

    void IMixedRealityPointerHandler.OnPointerDown(MixedRealityPointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    void IMixedRealityPointerHandler.OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        Debug.Log("OnPointerDragged");
    }

    void IMixedRealityPointerHandler.OnPointerUp(MixedRealityPointerEventData eventData)
    {
        Debug.Log("OnPointerUp");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
