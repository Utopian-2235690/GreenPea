using System.Collections.Generic;
using UnityEngine;

public class FoodGood : MonoBehaviour
{
    [SerializeField] private GameObject _foodPrefab;
    [SerializeField] private List<Transform> _foodLocations = new List<Transform>();

    void Start()
    {
        foreach (Transform location in _foodLocations)
        {
            Instantiate(_foodPrefab, location.position, location.rotation);
        }
    }
}
