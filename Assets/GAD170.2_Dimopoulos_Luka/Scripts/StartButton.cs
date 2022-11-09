using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LukaDimopoulos
{
    public class StartButton : MonoBehaviour
    {
        // Start is called before the first frame update
        public void StartVutton()
        {
            SceneManager.LoadScene(1);
        }

        public void QuitButton()
        {
            Application.Quit();
            print("Wow... I can't believe you have done this.");
        }
    }
}

