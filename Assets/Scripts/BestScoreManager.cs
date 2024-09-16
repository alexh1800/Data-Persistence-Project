using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScoreManager : MonoBehaviour
{

    public TMP_Text HighestScorerText;
    
    // Start is called before the first frame update (after awake)
    void Start()
    {
        setHighestScorerText();
    }


    private void setHighestScorerText()
    {
        string bestScorer = PersistentManager.instance.BestScorer;
        int bestScore = PersistentManager.instance.BestScore;

        if (bestScore > 0)
        {
            HighestScorerText.text = $"The Current Champion is: {bestScorer}\nWith a Score of: {bestScore}!";
        }
    }
}
