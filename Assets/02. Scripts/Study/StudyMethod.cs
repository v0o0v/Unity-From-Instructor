using UnityEngine;

public class StudyMethod : MonoBehaviour
{
    public enum HandType { Scissors, Rock, Paper }
    private HandType computerHandType;

    public HandType myHandType;

    void OnEnable()
    {
        SetComputer_HandType();

        SetWinner();
    }

    public void SetComputer_HandType()
    {
        int ranValue = Random.Range(0, 3); // 0, 1, 2

        if (ranValue == 0)
        {
            computerHandType = HandType.Scissors;
        }
        else if (ranValue == 1)
        {
            computerHandType = HandType.Rock;
        }
        else // ranValue == 2
        {
            computerHandType = HandType.Paper;
        }

        Debug.Log("컴퓨터 : " + computerHandType.ToString());
    }

    public void SetWinner()
    {
        if (computerHandType == myHandType)
        {
            Debug.Log("Draw");
        }
        else // if (computerHandType != myHandType)
        {
            if (computerHandType == HandType.Rock)
            {
                if (myHandType == HandType.Paper)
                {
                    Debug.Log("Player Win!!");
                }
                else if (myHandType == HandType.Scissors)
                {
                    Debug.Log("Computer Win!!");
                }
            } 
            else if (computerHandType == HandType.Scissors)
            {
                if (myHandType == HandType.Paper)
                {
                    Debug.Log("Computer Win!!");
                }
                else if (myHandType == HandType.Rock)
                {
                    Debug.Log("Player Win!!");
                }
            } 
            else if (computerHandType == HandType.Paper)
            {
                if (myHandType == HandType.Rock)
                {
                    Debug.Log("Computer Win!!");
                }
                else if (myHandType == HandType.Scissors)
                {
                    Debug.Log("Player Win!!");
                }
            }
        }
    }
}