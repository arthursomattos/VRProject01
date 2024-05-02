using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    [SerializeField] private TriggerZone triggerZone;
    private void Start()
    {
        triggerZone.OnEnterEvent.AddListener(InsideTrash);
    }

    public void InsideTrash(GameObject go)
    {
        go.SetActive(false);
    }
}
