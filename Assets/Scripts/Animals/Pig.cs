using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson_6.Animals
{

    public class Pig : FriendlyAnimal
    {
        private float piggySpeed = 0.2f;
        private bool _goingUp = true;

        private float delayTimer = 0;
        protected void Update()
        {
            if (delayTimer == 0)
            {
                delayTimer = Random.Range(0.5f, 3);
            }
            if (Time.timeSinceLevelLoad > delayTimer)
            {
                if (transform.position.z > 50 && _goingUp == true)
                {
                    _goingUp = false;
                }
                else if (transform.position.z < 0f && _goingUp == false)
                {
                    _goingUp = true;
                }

                if (_goingUp) transform.Translate(Vector3.forward * piggySpeed);
                if (!_goingUp) transform.Translate(Vector3.back * piggySpeed);
            }
        }
    }


}