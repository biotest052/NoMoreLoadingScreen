using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace NoMoreLoadingScreen
{
    public class Plugin : MonoBehaviour
    {
        public static Plugin instance;

        void Start()
        {
            instance = this;

            SceneManager.LoadScene(3);
        }

        public void WriteLine(string text, LogLevel severity = LogLevel.Debug) => Init.initInstance.Log.Log(severity, text);
    }
}
