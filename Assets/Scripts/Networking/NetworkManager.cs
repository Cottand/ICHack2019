using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NetworkManager : MonoBehaviour
{
    public static string roomName = "room";

    public Text studnetPin;

    // Update is called once per frame
    void Update()
    {
    }

    public static void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions() { IsVisible = true};
        PhotonNetwork.CreateRoom(roomName, roomOptions, TypedLobby.Default);
    }

    public void StudentJoin()
    {
        //var rooms = PhotonNetwork.GetRoomList();
        //bool exists = false;
        //foreach (var room in rooms)
        //{
        //    if (room.Name == studnetPin.text)
        //    {
        //        exists = true;
        //    }
        //}

        //if (exists)
        //{
        staticGlobalVariables.roomName = studnetPin.text;
        PhotonNetwork.JoinRoom(roomName);
        //}
        //else
        //{
        //    Debug.LogError("Room doesn't exist");
        //}

        SceneManager.LoadScene("Student");
    }


}
