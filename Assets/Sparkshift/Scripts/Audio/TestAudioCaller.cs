using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sparkshift.Audio
{
    public class TestAudioCaller : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown("space"))
            {
                AudioManager.instance.PlaySound(1);
            }
        }
    }
}
