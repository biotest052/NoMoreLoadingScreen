using MelonLoader;
using NoMoreLoadingScreen;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[assembly : MelonInfo(typeof(Class1), "NoMoreLoadingScreen", "0.0.1", "biotest05")]

namespace NoMoreLoadingScreen
{
    public class Class1 : MelonMod
    {
        bool initial;

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (initial == false)
            {
                if (buildIndex == 0)
                {
                    SceneManager.LoadScene(1);
                    initial = true;
                }

            }
            if (buildIndex == 1)
            {
                GameObject canvas = GameObject.Find("Main");
                canvas.transform.parent.Find("choose mode").gameObject.SetActive(true);
                canvas.transform.parent.Find("choose mode").Find("mp").Find("Button").GetComponent<Button>().Press();
                SceneManager.LoadScene(3);
            }
        }

        
    }
}
