using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson_6.Animals
{
    public class Pig : FriendlyAnimal
    {
        private bool _goingUp = true;
        protected void Update()
        {
            if (transform.position.z > 50 && _goingUp == true)
            {
                _goingUp = false;
            }
            else if(transform.position.z < 0f && _goingUp == false)
            {
                _goingUp = true;
            }

            if(_goingUp) transform.Translate(Vector3.forward);
            if(!_goingUp) transform.Translate(Vector3.back);
        }
    }
}