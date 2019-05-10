using System;

namespace State
{
    //the state
    public abstract class Doneness
    {
        public Steak Steak { get; set; }
        public int CurrentTemp { get; set; }
        public int UpperTemp { get; set; }
        public int LowerTemp { get; set; }
        public bool CanEat { get; set; }

        public abstract void AddTemp(int temp);
        public abstract void RemoveTemp(int temp);
        public abstract void DonenessCheck();


    }

    //the concrete state

    public class undone:Doneness
    {
        public undone(Doneness state)
        {
            CurrentTemp =state.CurrentTemp;
            Steak = state.Steak;

        }
        public void Initialize()
        {
            LowerTemp = 0;
            UpperTemp = 100;
            CanEat = false;
        }

        public override void AddTemp(int temp)
        {
            CurrentTemp =+ temp;
        }
        public override void RemoveTemp(int temp)
        {
            CurrentTemp -= temp;
        }
        public override void DonenessCheck()
        {
            if(CurrentTemp > UpperTemp)
            {
                Steak.State = new Medium(this);
            }

        }
    }

    public class Medium :Doneness
    {
        public Medium(Doneness state):this(state.CurrentTemp,state.Steak)
        {

        }

        public Medium(int currentTemp,Steak steak)
        {
            this.CurrentTemp = currentTemp;
            this.Steak = steak;
            CanEat = true;
           Initialize();

        }

        public void Initialize()
        {
            this.LowerTemp = 101;
            this.UpperTemp = 130;
            CanEat = false;
        }

        public override void AddTemp(int temp)
        {
            CurrentTemp += temp;

        }
        public override void RemoveTemp(int temp)
        {
            CurrentTemp -= temp;
        }

        public override void DonenessCheck()
        {
            if(CurrentTemp > UpperTemp)
            {
                Steak.State = new Done(this);
            }
        }
    }

    public class Done:Doneness
    {
        public Done(Doneness state):this(state.CurrentTemp,state.Steak)
        {

        }

        public Done(int currentTemp,Steak steak)
        {
            this.CurrentTemp =currentTemp;
            this.Steak =steak;
            CanEat= false;
            Initialize();


        }

        public void Initialize()
        {
            this.LowerTemp = 131;
            this.UpperTemp = 150;

        }

        public override void AddTemp(int temp)
        {
            CurrentTemp += temp;
        }
        public override void RemoveTemp(int temp)
        {
            CurrentTemp -= temp;
        }

        public override void DonenessCheck()
        {
            if(CurrentTemp > UpperTemp)
            {
                Steak.State = 
            }

        }
    }


    //the context

    public class Steak
    {
        private Doneness _state;
    private string _beefCut;

    public Steak(string beefCut)
    {
        _cook = beefCut;
        _state = new Rare(0.0, this);
    }

    public double CurrentTemp
    {
        get { return _state.CurrentTemp; }
    }

    public Doneness State
    {
        get { return _state; }
        set { _state = value; }
    }

    public void AddTemp(double amount)
    {
        _state.AddTemp(amount);
        Console.WriteLine("Increased temperature by {0} degrees.", amount);
        Console.WriteLine(" Current temp is {0}", CurrentTemp);
        Console.WriteLine(" Status is {0}", State.GetType().Name);
        Console.WriteLine("");
    }

    public void RemoveTemp(double amount)
    {
        _state.RemoveTemp(amount);
        Console.WriteLine("Decreased temperature by {0} degrees.", amount);
        Console.WriteLine(" Current temp is {0}", CurrentTemp);
        Console.WriteLine(" Status is {0}", State.GetType().Name);
        Console.WriteLine("");
    }
    }


}