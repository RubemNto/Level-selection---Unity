using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelselection : MonoBehaviour
{
    [Header ("levels of the game")]
    public string[] levelNames;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadLevel()
    {
        string name =  EventSystem.current.currentSelectedGameObject.name;
        for(int i = 0; i < levelNames.Length; i++)
        {
            if(name == levelNames[i])
            {
                Debug.Log("play level" + name);
                SceneManager.LoadScene(name);
            }
        }
    }
}
