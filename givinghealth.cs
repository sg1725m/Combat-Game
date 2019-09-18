using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class givinghealth : MonoBehaviour
{
    public Slider ui;
    public Button mybutton;

    void Start()
    {
        Button btn = mybutton.GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClicked);
    }
    void OnButtonClicked() { ui.value += 10; }
}
