using System;
using UnityEngine;

public class House : MonoBehaviour
{
    public event Action<House> HouseEntryDetected;
    public event Action<House> HouseExitDetected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Player>(out Player _))       
            HouseEntryDetected?.Invoke(this);       
    }

    private void OnTriggerExit(Collider other) => 
        HouseExitDetected?.Invoke(this);
}