using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCTestEvents : MonoBehaviour
{
    public void LogPartialTranscription(string text)
    {
        Debug.Log($"### transcript partially finished = " + text);
    }
}
