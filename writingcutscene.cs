using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class writingcutscene : MonoBehaviour
{

    public Text textArea;
    public string[] strings;
    public float speed = 0.1f;

    int stringIndex = 0;
    int characterIndex = 0;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(DisplayTimer());
    }
    IEnumerator DisplayTimer()
    {
        while (1 == 1)
        {
            yield return new WaitForSeconds(speed);
            if (characterIndex > strings[stringIndex].Length)
            {
                continue;
            }
            textArea.text = strings[stringIndex].Substring(0, characterIndex);
            characterIndex++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (characterIndex < strings[stringIndex].Length)
            {
                characterIndex = strings[stringIndex].Length;
            }
            else if (stringIndex < strings.Length)
            {
                stringIndex++;
                characterIndex = 0;
            }
        }
    }
}
