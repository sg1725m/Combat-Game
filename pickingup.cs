using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickingup : MonoBehaviour
{

    public GameObject inventoryPanel;
    public GameObject[] inventoryIcons;

    private void OnCollisionEnter(Collision collision)
    {
        foreach (Transform child in inventoryPanel.transform)
        {
            if (child.gameObject.tag == collision.gameObject.tag)
            {
                string c = child.Find("Text").GetComponent<Text>().text;
                int tcount = System.Int32.Parse(c) + 1;
                child.Find("Text").GetComponent<Text>().text = "" + tcount;
                return;
            }
        }
        GameObject i;
        if (collision.gameObject.tag == "health")
        {
            i = Instantiate(inventoryIcons[0]);
            i.transform.SetParent(inventoryPanel.transform);
        }
        else if (collision.gameObject.tag == "keys")
        {
            i = Instantiate(inventoryIcons[1]);
            i.transform.SetParent(inventoryPanel.transform);
        }
        else if (collision.gameObject.tag == "letter")
        {
            i = Instantiate(inventoryIcons[2]);
            i.transform.SetParent(inventoryPanel.transform);
        }
    }
}
