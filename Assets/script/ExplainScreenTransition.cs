using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplainScreenTransition : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //�ǉ�����
    //�{�^�������������̏���
    public void PushButton()
    {
        SceneManager.LoadScene("explain");
    }
}