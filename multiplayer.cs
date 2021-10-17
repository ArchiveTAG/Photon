b  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
public class multiplayer : MonoBehaviourPunCallbacks
{
   public  Transform sp;
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    void Update()
    {

    }
    public override void OnConnectedToMaster() {
        Debug.Log("servere girdi");
        PhotonNetwork.JoinLobby();

    
    }
    public override void OnJoinedLobby()
    {
        Debug.Log("lobiye girdi");
         PhotonNetwork.JoinOrCreateRoom("oda", new RoomOptions { MaxPlayers=10,IsOpen=true,IsVisible=true},TypedLobby.Default);
       // PhotonNetwork.JoinRandomRoom();

    }
    public override void OnJoinedRoom()
    {
        Debug.Log("odaya girdi");
        GameObject karakter = PhotonNetwork.Instantiate("Karakter", Vector3.zero,Quaternion.identity,0,null);
        


    }
    public override void OnLeftLobby()
    {
        Debug.Log("lobiden çıktı");



    }
    public override void OnLeftRoom()
    {
        Debug.Log("odadan çıktı");



    }
    public override void OnJoinRoomFailed(short retoncode,string messenge)
    {
        Debug.Log("Odaya Hatalı giris");



    }
    public override void OnJoinRandomFailed(short retoncode, string messenge)
    {
        Debug.Log("herhangi bir  girimedi");



    }
    public override void OnCreateRoomFailed(short retoncode, string messenge)
    {
        Debug.Log("oda bulunmadı");



    }
}
