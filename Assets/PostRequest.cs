using System;
using System.Collections;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Windows;

public class PostRequest : MonoBehaviour {
    public static PostRequest instance { get; private set; }
    private string url = "http://127.0.0.1:5000/store_json";
    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(this);
        }
    }
    public void SendRequest(string tag, float time) { 
        StartCoroutine(SendRequestCor(tag, time));
    }
    private IEnumerator SendRequestCor(string tag, float time) {
        // Create JSON data
        DateTime dateTime = DateTime.Now;
        
        string jsonData = "{\"name\":\""+tag+"\",\"time\":\""+time.ToString()+ "\",\"date\":\"" + dateTime.ToString("HH.mm.ss dd.MM.yy") + "\"}";
        Debug.Log(jsonData);
        // Create a UnityWebRequest with the JSON data
        UnityWebRequest request = UnityWebRequest.Post(url, jsonData, "application/json");
        Debug.Log(request);
        // Send the request and wait for a response
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success) {
            Debug.Log("Error: " + request.error);
        }
        else {
            Debug.Log("Response: " + request.downloadHandler.text);
        }
    }
    void Start() {
        Debug.Log(gameObject.tag);
        string ipAddress = GetLocalIPAddress();
        Debug.Log("Local IP Address: " + ipAddress);
        int lastDotIndex = ipAddress.LastIndexOf('.');

        if (lastDotIndex != -1) {
            string result = ipAddress.Substring(0, lastDotIndex + 1) + "1";
            url = "http://" + result + ":5000/store_json";
        }
        //SendRequest("asdf", 12.511f);
    }

    public string GetLocalIPAddress() {
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList) {
            if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) {
                if (ip.ToString().StartsWith("192.168")) 
                    return ip.ToString();
            }
        }
        throw new System.Exception("No network adapters with an IPv4 address in the system!");
    }
}
