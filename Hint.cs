using System;
using System.Collections;
using System.Diagnostics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Hint : MonoBehaviour, IInteractable
{
    private string objName;
    public void Interact()
    {
        objName = this.gameObject.name;
        switch(gameObject.name)
        {
            case  ("PF Props Road Sign W"): ChatLogger.Instance?.Log("�������e�B���Ȃ�͂ŉ����N���邩��");break;
            case ("PF Props Road Sign W (1)"): ChatLogger.Instance?.Log("���΂̗͂Œ��邩��"); break;
            case ("PF Props Road Sign E"): ChatLogger.Instance?.Log("���������̐΂�����Β����邩��"); break;
             default: ChatLogger.Instance?.Log("�Ŕ�"); break;

        }
    }
}
