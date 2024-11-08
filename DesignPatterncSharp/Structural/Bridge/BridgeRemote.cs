using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterncSharp.Structural.Bridge
{
    public abstract class Remote
    {
        public Device device;
        public  Remote(Device Device) {
            this.device = Device;
        }

        public abstract void PressUp();
        public abstract void PressDown();
        public abstract void PowerOn();
        public abstract void PowerOff();

    }

    public class AdvanceRemoveRemote : Remote
    {
        AdvanceRemoveRemote(Device Device):base(Device)
        {

            this.device = Device;
        }

        public override void PowerOff()
        {
            device.PoweOff();
        }

        public override void PowerOn()
        {
            device.PoweOn();
            // sets favourite channel
            device.SetChannel(0);
        }

        public override void PressDown()
        {
            device.Down();
        }

        public override void PressUp()
        {
            device.Up();
        }
    }
    public class BasicRemoveRemote : Remote
    {
        BasicRemoveRemote(Device Device) : base(Device)
        {

            this.device = Device;
        }

        public override void PowerOff()
        {
            device.PoweOff();
        }

        public override void PowerOn()
        {
            device.PoweOn();
        }

        public override void PressDown()
        {
            device.Down();
        }

        public override void PressUp()
        {
            device.Up();
        }
    }
    public  interface Device {

        void Up();
        void Down();
        void PoweOn();
        void PoweOff();

        void SetChannel(int i);
    
    }

   public class Tv : Device
    {
        public void Down()
        {
            Console.WriteLine("TV Cahnnel set current-1");
        }

        public void PoweOff()
        {
            Console.WriteLine("TV power OFF");
        }

        public void PoweOn()
        {
            Console.WriteLine("TV power ON");
        }

        public void SetChannel(int i)
        {
            Console.WriteLine("Set channel i");
        }

        public void Up()
        {
            Console.WriteLine("TV Cahnnel set current+1");
        }
    }


    public class radio : Device
    {
        public void Down()
        {
            Console.WriteLine("Radio Cahnnel set current-1");
        }

        public void PoweOff()
        {
            Console.WriteLine("Radio power OFF");
        }

        public void PoweOn()
        {
            Console.WriteLine("Radio power ON");
        }

        public void Up()
        {
            Console.WriteLine("Radio Cahnnel set current+1");
        }

        public void SetChannel(int i)
        {
            Console.WriteLine("Set channel i");
        }
    }

   public class Ac : Device
    {
        public void Down()
        {
            Console.WriteLine("AC Temperature set current-1");
        }

        public void PoweOff()
        {
            Console.WriteLine("AC power OFF");
        }

        public void PoweOn()
        {
            Console.WriteLine("AC power ON");
        }

        public void Up()
        {
            Console.WriteLine("AC Temperature set current+1");
        }

        public void SetChannel(int i)
        {
            Console.WriteLine("Set Temperature i");
        }
    }

}

