using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public string OptionScene;

    public Button scenbyte;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = scenbyte.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {

        SceneManager.LoadScene(OptionScene);
        //Debug.Log("Going to Option scenes!");

    }
}
