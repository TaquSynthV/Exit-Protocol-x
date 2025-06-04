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
            case  ("PF Props Road Sign W"): ChatLogger.Instance?.Log("‰ö‚µ‚¢‰eB¹‚È‚é—Í‚Å‰½‚©‹N‚±‚é‚©‚à");break;
            case ("PF Props Road Sign W (1)"): ChatLogger.Instance?.Log("“•‰Î‚Ì—Í‚Å’¼‚é‚©‚à"); break;
            case ("PF Props Road Sign E"): ChatLogger.Instance?.Log("‚¢‚¢Š´‚¶‚ÌÎ‚ª‚ ‚ê‚Î’¼‚¹‚é‚©‚à"); break;
             default: ChatLogger.Instance?.Log("ŠÅ”Â‚¾"); break;

        }
    }
}
