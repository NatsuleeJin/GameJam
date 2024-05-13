using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [Header("Params")]
    [SerializeField] private float typingSpeed = 0.04f;

    [Header("Dialogue UI")]
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private Story currentStory;
    [SerializeField] private TextMeshProUGUI namePotion; 
    [SerializeField] private Animator potion;
    [SerializeField] private GameObject mondisplay;
    [SerializeField] private Animator slimeAnimation;
    
    private const string POTION_TAG = "potion";
    private const string SLIME_TAG = "slime";
    private const string NAMEPOTION_TAG = "namePotion";

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    [SerializeField] private TextMeshProUGUI[] choiceText;

    private Coroutine diaplayLineCoroutine;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("found more tham 1 dialogue manager in the scence");
        }
        instance = this;
    }

    private void Start()
    {

        LoadStory();

        choiceText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choiceText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }
    public void ContinueStory()
    {
        if (currentStory.canContinue)
        {

            if (diaplayLineCoroutine != null)
            {
                StopCoroutine(diaplayLineCoroutine);
            }
            diaplayLineCoroutine = StartCoroutine(DisplayLine(currentStory.Continue()));

            DisplayChoices();//display choice if have

            HandleTags(currentStory.currentTags);
        }
        else
        {
            dialogueText = null;
        }
    }
    private IEnumerator DisplayLine(string line)
    {
        dialogueText.text = ""; //empty dia text

        foreach (char letter in line.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    private void HandleTags(List<string> currentTags)
    {
        foreach (string tag in currentTags)
        {
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag could not be appropriately parsed:" + tag);
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            switch (tagKey)
            {
                case POTION_TAG:
                    potion.Play(tagValue);
                    break;
                case SLIME_TAG:
                    slimeAnimation.Play(tagValue);
                    break;
                case NAMEPOTION_TAG:
                    namePotion.text = tagValue;
                    break;
            }
        }

    }
    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))//  || Input.GetKeyDown(KeyCode.Mouse0) )
        {

            ContinueStory();

        }

    }

    void LoadStory()
    {
        currentStory = new Story(inkJSON.text);

    }


    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More that UI can support. No. of choices given:" + currentChoices.Count);
        }

        int index = 0;
        //enable choice num up to it amount
        foreach (Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choiceText[index].text = choice.text;
            index++;
        }
        //go to remaining choice and make sure they're hidden
               for (int i = index; i < choices.Length; i++)
               {
                   choices[i].gameObject.SetActive(false);
               }
        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }
    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);


    }

}
