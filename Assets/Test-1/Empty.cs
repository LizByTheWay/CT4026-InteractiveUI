using TMPro;
using UnityEngine;

public class Empty : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "imagine this spinning";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
