using UnityEngine;

namespace Assets.Scripts
{
    // This the base class for all audio components 
    public class BaseExplanationAudio : MonoBehaviour
    {
        public bool IsPlaying;
        public AudioSource Audio;
        public CameraZoomComponent Zoom;
    }
}
