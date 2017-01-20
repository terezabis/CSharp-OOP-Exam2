using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_10_July_2016
{
    public abstract class Hardware : Sistem
    {
        private string name;
        private string type;

        protected Hardware(string name, string type, int maxCapacity, int maxMemory) 
            : base(maxCapacity, maxMemory)
        {
            this.name = name;
            this.type = type;
            this.MaxCapacity = maxCapacity;
            this.MaxMemory = maxMemory;
        }

        public virtual int MaxCapacity
        {
            get; set;
        }

        public virtual int MaxMemory
        {
            get; set;
        }

        public override int HardwareComponents
        {
            get
            {
                return 1 + base.HardwareComponents;
            }
        }

        public override int TotalCapacity
        {
            get
            {
                return this.Capacity + base.TotalCapacity;
            }
        }

        public override int TotalMemory
        {
            get
            {
                return this.Memory + base.TotalMemory;
            }
        }
    }
}