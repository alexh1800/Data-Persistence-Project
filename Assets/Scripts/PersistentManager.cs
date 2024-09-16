using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using System.IO;

public class PersistentManager : MonoBehaviour
{

    public static PersistentManager instance;

    public string Username;

    public string BestScorer;

    public int BestScore;


    // Awake is called before start()
    void Awake()
    {
        /*
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        */

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        LoadData();
    }



    [System.Serializable]

    class SaveData
    {
        public string bestScorer;
        public int bestScore;
    }



    public void SubmitScore(string scorer, int score)
    {

        //only save the data if the users score is the highest score
        if (score > BestScore)
        {

            SaveData data = new SaveData();

            data.bestScorer = scorer;
            data.bestScore = score;


            //convert our save data into a json string so it can be stored in a json file
            string saveJson = JsonUtility.ToJson(data);

            //save the data to a file
            File.WriteAllText(Application.persistentDataPath + "/savefile.json", saveJson);


        }
        

    }

    private void LoadData()
    {
        string savePath = Application.persistentDataPath + "/savefile.json";


        //See if file exists and retrieve it
        if (File.Exists(savePath))
        {
            //get all our json text from the file
            string jsonString = File.ReadAllText(savePath);

            //convert the json text from the save file into a SaveData object with our save data in it
            SaveData data = JsonUtility.FromJson<SaveData>(jsonString);

            BestScorer = data.bestScorer;
            BestScore = data.bestScore;

        }

    }


}
