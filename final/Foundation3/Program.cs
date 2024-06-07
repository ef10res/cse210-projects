using System;

class Program
{
    static void Main(string[] args)
    {   
        Address address1 = new Address("200 E 1500 N", "Salt Lake City", "UT", "USA");
        Address address2 = new Address("25 S 200 E", "Kaysville", "UT", "USA");
        Address address3 = new Address("675 W 18000 S", "Sandy", "UT", "USA");

        Lecture lecture = new Lecture("The importance of investing", "A famous rich person will be speaking on the power of investing and how to invest",
        "07/15/2024", "06:00 pm", address1, "Donald Trump", 500);

        Reception reception = new Reception("Mr. and Mrs. Flores wedding", "Join us as we congratulate our Daughter and Son in Law for this important moment in ther lives",
        "08/15/2025", "05:00 pm", address2, "floreserick10@gmail.com");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Marathon", "If you like challenges, this is your opportunity to sign up for our marathon which will have 2000 ft of elevation gain",
        "07/15/2024", "07:00 am", address3, "Forecasted weather is a low temperature of 55 degrees with a high of 80, sunny with clear skies.");

        string eventType1 = "Lecture";
        string eventType2 = "Reception";
        string eventType3 = "Outdoor Gathering";

        lecture.ShortDescription(eventType1);
        lecture.StandardDetails();
        lecture.FullDetails();

        reception.ShortDescription(eventType2);
        reception.StandardDetails();
        reception.FullDetails();

        outdoorGathering.ShortDescription(eventType3);
        outdoorGathering.StandardDetails();
        outdoorGathering.FullDetails();

        
    }
}