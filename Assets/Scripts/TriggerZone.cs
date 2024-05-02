using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{

    public string targetTag;
    public UnityEvent<GameObject> OnEnterEvent;

    private void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag(targetTag))
        {
            OnEnterEvent.Invoke(c.gameObject);
        }
    }
}
