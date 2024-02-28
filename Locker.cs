using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class Locker
    {
        public bool IsOccupied;
        public string size;
        public string pin;
        public Guid id;
        public Package package;
        public Locker(string size, Guid id)
        {
            this.size = size;
            this.id = id;
        }

        public void AllocatePackage(Package package, string pin)
        {
            this.package = package;
            this.IsOccupied = true;
            this.pin = pin;
        }

        public void DeAllocatePackage(Package package)
        {
            this.package = package;
            this.IsOccupied = true;
            this.pin = string.Empty;
        }
    }

    public class Package
    {
        public string Size;
        public Guid LockerId;

        public Package(string size, Guid lockerId)
        {
            this.Size = size;
            this.LockerId = lockerId;
        }

        public string GeneratePin()
        {
            Random random = new Random();
            return random.Next(0, 1000000).ToString("D6");
        }
    }
}
