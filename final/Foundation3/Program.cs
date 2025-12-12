using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //add the values to address
        Address address1 = new Address("elm st","yorkee","despair","nowhere");
        Address address2 = new Address("1st st","huskee","ignorance","somewhere?");
        Address address3 = new Address("bane lane","gotham","darkness","underthere");

        //add values for lecture and display
        Lecture lecture1 = new Lecture("jimmy jackson", 160, "how to ruin your life in 12 easy steps", "in this course you will learn how to make all the worst decisions as a way to know what to avoid to achieve success.", "12/11/2025", "2:14pm", address1);
        lecture1.StandardDisplay();
        Event.DelayClear();
        lecture1.FullDisplay();
        Event.DelayClear();
        lecture1.ShortDisplay();
        Event.DelayClear();

        //add values for reception and display
        Reception reception1 = new Reception("jake, john, jimmy, jared, jacob, james, jamal","how to drop out of college with no regrets!","in this talk we will delve into the ways in which you can dive out of college and focus on the important things -- like girls, video games, and chicken nuggies!","12/11/2025", "2:19pm", address2);
        reception1.StandardDisplay();
        Event.DelayClear();
        reception1.FullDisplay();
        Event.DelayClear();
        reception1.ShortDisplay();
        Event.DelayClear();

        //add values for outdoor and display
        Outdoor outdoor1 = new Outdoor("cloudy with a chance of milk","why dairy is of the devil!","we will discuss the ways in which mass companies mistreat and inhumanely treat cows to produce the consumers favorite dairy products.","moo o' clock","2:22pm",address3);
        outdoor1.StandardDisplay();
        Event.DelayClear();
        outdoor1.FullDisplay();
        Event.DelayClear();
        outdoor1.ShortDisplay();
        Event.DelayClear();
        Console.WriteLine("and that's the project! thanks for watching<3");

    }
}

/*
the challenge for me was to understand that Class type objects can access their methods -- so in this case, all I had to do was have a method in Address 
that returned the full address as a string, and then call that to in an Event method so that the subclasses could access it.
*/