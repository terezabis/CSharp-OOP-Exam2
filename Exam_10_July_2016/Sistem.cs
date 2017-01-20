using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_10_July_2016
{
    public abstract class Sistem
    {
        private int capacity;
        private int memory;

        protected Sistem(int capacity, int memory)
        {
            this.capacity = capacity;
            this.memory = memory;
        }

        public virtual int TotalCapacity
        {
            get { return 0; }
        }

        public virtual int TotalMemory
        {
            get { return 0; }
        }

        public virtual int TotalCapacityTaken
        {
            get { return 0; }
        }
        
        public virtual int TotalMemoryTaken
        {
            get { return 0; }
        }

        public virtual int HardwareComponents
        {
            get { return 0; }
        }

        public virtual int SoftwareComponents
        {
            get { return 0; }
        }

        public virtual int Capacity
        {
            get
            {
                return 0;
            }
        }

        public virtual int Memory
        {
            get
            {
                return 0;
            }
        }
        
    }
}