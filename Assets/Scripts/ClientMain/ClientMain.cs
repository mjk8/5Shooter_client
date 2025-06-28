using System;
using Cysharp.Threading;
using UnityEngine;

namespace Client
{
    public class ClientMain : MonoBehaviour
    {
        public static ClientMain Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
