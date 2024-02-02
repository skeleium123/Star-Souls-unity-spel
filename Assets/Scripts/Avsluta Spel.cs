using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvslutaSpel : MonoBehaviour
{

    public Button Exit;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = Exit.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Application.Quit();
        //Debug.Log("Going to Option scenes!");
    }
}
