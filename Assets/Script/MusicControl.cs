using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicControl : MonoBehaviour
{
    [SerializeField] private AudioSource fundoMusical;
    public void VolumeMusical(float value)
    {
        fundoMusical.volume = value;
    }
}
