using System;
using UnityEngine;

namespace Asteroid
{
    public class PlayerInput : MonoBehaviour
    {
        public float Horizontal { get; private set; }
        public float Vertical { get; private set; }
        public bool Fire { get; private set; }

        private void Update()
        {
            Horizontal = Input.GetAxis(InputManagers.HORIZONTAL);
            Vertical = Input.GetAxis(InputManagers.VERTICAL);
            Fire = Input.GetButtonDown(InputManagers.FIRE1);
        }
    }
}