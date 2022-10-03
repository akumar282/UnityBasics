using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {
            if (SceneManager.GetActiveScene().buildIndex >= 2)
            {
                SceneManager.LoadScene(0);
            }
            else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        }

        if(Input.GetKey(KeyCode.Alpha1))
        {
            SceneManager.LoadScene(0);
        }
        
        if(Input.GetKey(KeyCode.Alpha2))
        {
            SceneManager.LoadScene(1);
        }

        if(Input.GetKey(KeyCode.Alpha3))
        {
            SceneManager.LoadScene(2);
        }
          
        if(Input.GetKey(KeyCode.Space))
        {   
            int scenenum = (int)Random.Range(0.0f, 2.9f);
            SceneManager.LoadScene(scenenum);
        }
    }
}
