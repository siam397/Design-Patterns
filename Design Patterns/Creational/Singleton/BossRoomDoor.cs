namespace Design_Patterns.Creational.Singleton
{
    public class BossRoomDoor
    {
        public static bool switch1;
        public static bool switch2;
        public static bool switch3;
        public static BossRoomDoor bossRoomDoor;
        public static bool isbossRoomDoorOpen;
        protected BossRoomDoor()
        {
            switch1= false;
            switch2= false;
            switch3= false;
            isbossRoomDoorOpen = false;
        }

        public static BossRoomDoor Instance()
        {
            if(bossRoomDoor == null)
            {
                bossRoomDoor = new BossRoomDoor();
            }
            else
            {
                if (switch1 && switch2 && switch3)
                {
                    isbossRoomDoorOpen= true;
                    Console.WriteLine("Door is open");
                }
                else
                {
                    Console.WriteLine("Door is closed");
                }
            }
            return bossRoomDoor;
        }

    }
}
