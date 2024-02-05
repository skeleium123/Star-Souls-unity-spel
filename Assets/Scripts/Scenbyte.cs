using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class Scenbyte : MonoBehaviour
{
    public string nextScene; 

    public Button scenbyte;
    // Start is called before the first frame update
    void Start(){
        Button btn = scenbyte.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
    }

    // Update is called once per frame
    void TaskOnClick(){

        SceneManager.LoadScene(nextScene);
        //Debug.Log("You have clicked the button!");

    }
}
