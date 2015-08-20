﻿
namespace Enumeration
{
    using System;
    using System.Text;
    public class Battery
    {
        //Enumerator
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

        //Fields
        private string batteryModel;
        private string batteryManufacturer;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType batType;

        //Properties

        public BatteryType BatType
        {
            get
            {
                return this.batType;
            }
            set
            {
                this.batType = value;
            }
        }
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
        //Constructors
        public Battery()
        {
            this.batteryModel = null;
            this.batteryManufacturer = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }

        public Battery(BatteryType batType)
        {
            this.batType = batType;
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
