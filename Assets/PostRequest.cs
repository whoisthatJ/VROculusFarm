using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class PostRequest : MonoBehaviour {
    private string url = "http://192.168.137.140:5000/upload";

    IEnumerator Start() {
        // Create JSON data
        string jsonData = "{\"name\":\"Alice\",\"age\":30}";
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
}
