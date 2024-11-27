using UnityEngine;
using System.Collections;

public class NpcControl : MonoBehaviour
{
    public GameObject canvas;
    // Use this for initialization
    void Start()
    {
        Debug.Log("NPC创建");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(true);
            Debug.Log("遭遇");
        }
    }
}
