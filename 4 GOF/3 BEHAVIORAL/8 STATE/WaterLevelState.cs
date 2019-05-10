using System;
namespace WaterLevelState
{
    //state abstract

    public abstract class WaterLevel
    {
        public Lake _lake { get; set; }
        public int _currentLevel { get; set; }
        public int _maxTreshold { get; set; }
        public int _minTreshold { get; set; }
        public int _rain { get; set; }

        public abstract void Rain(int amount);
        public abstract void GetLevel();
    }

    //concrete state = dry,normal, floating

    public class NormalLevel:WaterLevel
    {
        public NormalLevel(WaterLevel waterLevel)
        {
            this._currentLevel = waterLevel._currentLevel;
            this._lake = waterLevel._lake;
            Initialize();
        }
        public void Initialize()
        {
            _minTreshold = 0;
            _maxTreshold = 1000;
        }
        public override void Rain(int amount)
        {
            this._currentLevel += amount;
        }

        public override void GetLevel()
        {
            if(_currentLevel > _maxTreshold)
            {
                
            }

        }

    }


    //the context = the lake

    public class Lake
    {
        public WaterLevel Level { get; set; }

    }

    //client
    public class Client
    {
        public Client()
        {

        }
    }
}