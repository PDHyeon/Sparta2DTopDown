using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyInterAct : MonoBehaviour
{
    //Player¿¡ ºÎÂøµÊ.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "NPC"))
        {
            collision.GetComponent<NPCBehavior>().ShowInteractWindowOn();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "NPC"))
        {
            collision.GetComponent<NPCBehavior>().ShowInteractWindowOff();
        }
    }
}
