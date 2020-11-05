using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{

    public GameObject scoreText;
    float spacepressed;

    // Start is called before the first frame update
    void Start()
    {
        //scoreText.GetComponent<Text>().text = "SpacePress:" + spacepressed;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacepressed++;
            print(spacepressed);
            scoreText.GetComponent<Text>().text = "SpacePress:" + spacepressed;
        }
    }
}
