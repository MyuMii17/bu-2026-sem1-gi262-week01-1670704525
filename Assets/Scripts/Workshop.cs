using UnityEngine;
using UnityEngine.InputSystem;

public class Workshop : MonoBehaviour
{
    private InputAction nextStateAction;
    private InputAction backStateAction;
    private InputAction startStateAction;
    private int state;
    private string stateName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = 0;
        StateName();
        Debug.Log($"State : {state} , {stateName}");
        Debug.Log("Press N To Go Next State And Press B To Go To Previous State");
        Debug.Log("Press Spacbar to start.");

        runAction = InputSystem.actions.FindAction("RunSystem");
        nextStateAction = InputSystem.actions.FindAction("NextState");
        backStateAction = InputSystem.actions.FindAction("BackState");
        startStateAction = InputSystem.actions.FindAction("StartState");

        //As01_SyntaxIf();
        //As02_StringComparisonExample();
        // As03_NumberComparisonExample();
        // As04_AndOrOperatorExample();
        // As05_GuessingNumberExample();
        // As06_GuessingNumberMoreOrLessExample();
        // As07_VerifyIdentityExample();
    }
    void Update()
    {
        //Go Bcak to previous State.
        if (backStateAction.WasReleasedThisFrame() && state > 0)
        {
            state--;
            state = state % 8;
            StateName();
            Debug.Log($"State : {state} , {stateName}");
            Debug.Log("Press N To Go Next State And Press B To Go To Previous State");
            Debug.Log("Press Spacbar to start.");
        }

        //Go to Next State.
        if (nextStateAction.WasReleasedThisFrame())
        {
            state++;
            state = state % 8;
            StateName();
            Debug.Log($"State : {state} , {stateName}");
            Debug.Log("Press N To Go Next State And Press B To Go To Previous State");
            Debug.Log("Press Spacbar to start.");
        }

        //Start the state.
        if (startStateAction.WasReleasedThisFrame())
        {
            switch (state)
            {
                case 0:
                    As01_SyntaxIf();
                    break;
                case 1:
                    As02_StringComparisonExample();
                    break;
                case 2:
                    As03_NumberComparisonExample();
                    break;
                case 3:
                    As04_AndOrOperatorExample();
                    break;
                case 4:
                    As05_GuessingNumberExample();
                    break;
                case 5:
                    As06_GuessingNumberMoreOrLessExample();
                    break;
                case 6:
                    As07_VerifyIdentityExample();
                    break;
                case 7:
                    Debug.Log("GET BACK NOW!!! \n We have only 0 - 6 state");
                    break;
            }
        }
    }

    void StateName()
    {
        switch (state)
        {
            case 0:
                stateName = "isSixOClock???";
                break;
            case 1:
                stateName = "Is Password Correct???";
                break;
            case 2:
                stateName = "A Number V1";
                break;
            case 3:
                stateName = "A Number V2";
                break;
            case 4:
                stateName = "Guess The Number 1, 2 or 3 V1";
                break;
            case 5:
                stateName = "Guess The Number 1, 2 or 3 V2";
                break;
            case 6:
                stateName = "Can you Verify you Identity???";
                break;
            case 7:
                stateName = "?????";
                break;
        }
    }

    public bool isSixOClock;
    public void As01_SyntaxIf()
    {
        Debug.Log("Is The Door Open ??");

        if (isSixOClock)
        {
            Debug.Log("It 06:00PM now. \nThe Door Open");
        }
        else
        {
            Debug.Log("It not 06:00PM!!!. \nGet Out !!!");
        }
    }

    public string password;
    public void As02_StringComparisonExample()
    {
        if(password == "113333555555")
        {
            Debug.Log($"{password} is Correct, Now you can get in here");
        }
        else
        {
            Debug.Log($"{password} is not a password. \n Please try again.");
        }
    }

    public int as03Number;
    public void As03_NumberComparisonExample()
    {
        if(as03Number > 10)
        {
            Debug.Log($"The Number {as03Number} is Greater than 10");
        }
        if(as03Number < 10)
        {
            Debug.Log($"The Number {as03Number} is Less than 10");
        }
        if (as03Number >= 10)
        {
            Debug.Log($"The Number {as03Number} is Greater than or equal to 10");
        }
        if (as03Number <= 10)
        {
            Debug.Log($"The Number {as03Number} is Less than or equal to 10");
        }
        if (as03Number != 10)
        {
            Debug.Log($"The Number {as03Number} is not 10");
        }
        if (as03Number == 10)
        {
            Debug.Log($"The Number {as03Number} is equal to 10");
        }
    }

    public int as04Number;
    public void As04_AndOrOperatorExample()
    {
        if(as04Number > 8 && as04Number < 12)
        {
            Debug.Log($"The number {as04Number} is Greater than 8 and Less than 12");
        }
        else if(as04Number > 2 || as04Number > 4)
        {
            Debug.Log($"The number {as04Number} is Greater than 2 or Greater than 4");
        }
        else if (as04Number <= 2)
        {
            Debug.Log($"The number {as04Number} is Less than 2");
        }
    }

    public int as05GuessingNumber;
    public int as05RandomNumber;
    public void As05_GuessingNumberExample()
    {
        as05RandomNumber = Random.Range(1, 3);

        if (as05GuessingNumber == as05RandomNumber)
        {
            Debug.Log("It correct!!! Wow, How did you do that!!!");
        }
        else
        {
            Debug.Log("Wrong!!!!");
        }
    }

    public int as06GuessingNumber;
    public int as06RandomNumber;
    public void As06_GuessingNumberMoreOrLessExample()
    {
        as06RandomNumber = Random.Range(1, 3);

        if (as06GuessingNumber == as06RandomNumber)
        {
            Debug.Log("It correct!!! Wow, How did you do that!!!");
        }
        else if (as06GuessingNumber > as06RandomNumber)
        {
            Debug.Log("Unlucky your number Greater than this number");
        }
        else if (as06GuessingNumber < as06RandomNumber)
        {
            Debug.Log("Unlucky your number Less than this number");
        }
    }

    public string as07Username;
    public string as07Password;
    public int as07Age;
    public bool as07IsPaid;
    public void As07_VerifyIdentityExample()
    {
        if(as07Username == "User" && as07Password == "1234")
        {
            Debug.Log("Logged In");

            if (as07IsPaid)
            {
                Debug.Log($"{as07Username} Is Vip Member");
            }
            else
            {
                Debug.Log($"{as07Username} Is Free Member");
            }

            if(as07Age >= 18)
            {
                Debug.Log("You have access to excusive content");
            }
            else
            {
                Debug.Log("You haven't access to excusive content");
            }
        }
        else
        {
            Debug.Log("Your are Guest Mode");
        }
    }
}
