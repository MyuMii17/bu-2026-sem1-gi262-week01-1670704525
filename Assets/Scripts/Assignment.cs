using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;

public class Assignment : MonoBehaviour
{
    private int state;
    private string stateName;
    private InputAction nextStateAction;
    private InputAction backStateAction;
    private InputAction startStateAction;
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

        // As01_CheckNumberSign();
        // As02_GetDayName();
        // As03_ValidatePassword();
        // As04_GetGrade();
        // As05_IsLeapYear();
        // As06_Calculate();
        // As07_GetSeason();
        // As08_PurchasingSystemExample();
        // As09_RockPaperScissorsExample();
        // As10_CalculateWeaponDamage();
        // As11_DeterminePlayerRank();
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
                    As01_CheckNumberSign();
                    break;
                case 1:
                    As02_GetDayName();
                    break;
                case 2:
                    As03_ValidatePassword();
                    break;
                case 3:
                    As03_ValidatePassword();
                    break;
                case 4:
                    As03_ValidatePassword();
                    break;
                case 5:
                    As03_ValidatePassword();
                    break;
                case 6:
                    As03_ValidatePassword();
                    break;
                case 7:
                    Debug.Log("GET BACK NOW!!! \n We have only 0 - 6 state");
                    break;
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

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");
        throw new System.NotImplementedException();
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");
        throw new System.NotImplementedException();
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");
        throw new System.NotImplementedException();
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");
        throw new System.NotImplementedException();
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");
        throw new System.NotImplementedException();
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");
        throw new System.NotImplementedException();
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");
        throw new System.NotImplementedException();
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        throw new System.NotImplementedException();
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        throw new System.NotImplementedException();
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        throw new System.NotImplementedException();
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        throw new System.NotImplementedException();
    }
}
