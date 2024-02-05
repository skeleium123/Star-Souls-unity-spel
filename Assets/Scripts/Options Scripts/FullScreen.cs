using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Fullscreen : MonoBehaviour
{
    
    public Button FullScreen;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = FullScreen.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Screen.fullScreen = !Screen.fullScreen;
        //Debug.Log("FullScreen Yes-Yes.");
    }
}
