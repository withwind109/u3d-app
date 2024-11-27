using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoginController : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField passwordInput;
    public Text errorText;
    public Button loginBtn;
    // Start is called before the first frame update
    void Start()
    {
        loginBtn.onClick.AddListener(onSubmit);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void onSubmit()
    {
        string name = nameInput.text;
        string password = nameInput.text;
        Debug.Log("onsub");

        if (string.IsNullOrEmpty(name))
        {
            errorText.text = "请输入用户名";
            return;
        }
        else if (string.IsNullOrEmpty(password))
        {
            errorText.text = "请输入密码";
            return;
        }
        else if (name.Equals("user") && password.Equals("123"))
        {
            // 登录成功
        }
    }
}

