using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccountInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text accountId = GetComponent<Text>();
        accountId.text = "Account: \n" + PlayerPrefs.GetString("Account","0x00000000");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
