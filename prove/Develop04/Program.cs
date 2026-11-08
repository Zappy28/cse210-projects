// To exceed the requirements, I made it so that the program keeps count
// of how much times each activity has be preformed in the session. 
// These counts are then displayed in the home screen.
// Along with this I also made the user interface easier to read with colors
// and a nice layout.


class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        ReflectionActivity myReflectionActivity = new ReflectionActivity();
        ListingActivity myListingActivity = new ListingActivity();
        BreathingActivity myBreathingActivity = new BreathingActivity();

        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;


        int response = 0;

        while(response != 4)
        {
            response = myMenu.ProcessMenu(
                breathingCount,
                reflectionCount,
                listingCount);
            switch (response)
            {
                case 1:
                    breathingCount++;
                    myBreathingActivity.RunActivity(); 
                    break;
                case 2:
                    reflectionCount++;
                    myReflectionActivity.RunActivity(); 
                    break;
                case 3:
                    listingCount++;
                    myListingActivity.RunActivity();
                    break;
            }
        }

        
    }
}