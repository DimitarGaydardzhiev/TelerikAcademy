
namespace DefineConstructor
{
    using System;
    public class Battery
    {
        //Fields
        private string batteryModel;
        private string batteryManufacturer;
        private int? hoursIdle;
        private int? hoursTalk;

        //Properties
        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                this.batteryModel = value;
            }
        }

        public string BatteryManufacturer
        {
            get
            {
                return this.batteryManufacturer;
            }
            set
            {
                this.batteryManufacturer = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }
        //Constructor
        public Battery()
        {
            this.batteryModel = null;
            this.batteryManufacturer = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }
        public Battery(string batteryModel, string batteryManufacturer)
        {
            this.batteryModel = batteryModel;
            this.batteryManufacturer = batteryManufacturer;
        }

        public Battery(string batteryModel, string batteryManufacturer, int? hoursIdle = null, int? hoursTalk = null) : 
            this(batteryModel, batteryManufacturer)
        {
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
    }
}
