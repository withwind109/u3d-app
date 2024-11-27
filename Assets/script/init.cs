using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject foxRole = Resources.Load<GameObject>("fox1");
        GameObject cloneFox = Instantiate(foxRole);
        cloneFox.name = "foxClone";

        GameObject fox1 = GameObject.Find("foxClone");
        fox1.SetActive(false); // 隐藏

        Debug.Log("game start"); 
        Destroy(fox1, 5); // 移除
        // 场景切换的时候默认会销毁
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
