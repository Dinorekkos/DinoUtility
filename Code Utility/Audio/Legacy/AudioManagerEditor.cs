using Dino.Utility.Audio;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AudioManager))]
public class AudioManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        AudioManager audioManager = (AudioManager)target;
        
        GUILayout.Space(10);
        
        if(audioManager.AudioManagerData == null)
        {
            if (GUILayout.Button("Create AudioManagerData"))
            {
                audioManager.AudioManagerData = ScriptableObject.CreateInstance<AudioManagerData>();
                AssetDatabase.CreateAsset(audioManager.AudioManagerData, "Assets/CasinoGame/ScriptableObjects/Audio/AudioManagerData.asset");
                AssetDatabase.SaveAssets();
            }
            if (GUILayout.Button("Add AudioData"))
            {
                audioManager.AudioManagerData.audioData.Add(new AudioData());
                EditorUtility.SetDirty(audioManager.AudioManagerData);
            }
        }

        // if (GUILayout.Button("PlaySound"))
        // {
        //     audioManager.PlaySound(audioManager._soundNameTest);
        // }
            
        
    }
}