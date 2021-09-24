using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Transform target;
    public UnityEngine.UI.Slider slider;
    public Vector3 multiplier = Vector3.zero;
    protected Vector3 startRotation = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        startRotation = target.eulerAngles;
    }

    public void UpdateRotation()
    {
        var val = multiplier * slider.value;
        val = val + startRotation;
        target.eulerAngles = val;
    }
}
