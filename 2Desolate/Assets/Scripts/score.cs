using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    TextMeshProUGUI distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = GetComponent<TextMeshProUGUI>();
        distance.text = "You have explored " + Mathf.RoundToInt(spawn.score) + " units";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
