using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SoundController : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private List<String> roomNumber;
    [SerializeField] private List<AudioClip> roomNameVoid;
    [SerializeField] private AudioClip audioCancel;
    private int index;
    public static SoundController Instance{ get{
        return instance;
    }}
    private static SoundController instance;
    private void Awake(){
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CallNumber(string number){
        index = roomNumber.IndexOf(number);
        if(index==-1){
            audioSource.PlayOneShot(audioCancel);
        }else{
            audioSource.Play();
            Invoke(nameof(nghe),Random.Range(2f,6f));
        }
    }
    private void nghe(){
        audioSource.Stop();
        audioSource.PlayOneShot(roomNameVoid[index]);
    }
}
