using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
// Add Exercise
        Exercise CodeyThing = new Exercise();
        CodeyThing.name = "CodeyThing";
        CodeyThing.type = "CSharp";

        Exercise AlmondShell = new Exercise();
        AlmondShell.name = "AlmondShell";
        AlmondShell.type = "JavaScript";

        Exercise BreakBread = new Exercise();
        BreakBread.name = "BreakBread";
        BreakBread.type = "React.js";

        Exercise LaymanTribute = new Exercise();
        LaymanTribute.name = "LaymanTribute";
        LaymanTribute.type = "CSS";

// Adding Cohort

        Cohort ThirtyFour = new Cohort();
        ThirtyFour.name = 34;

        Cohort ThirtyFive = new Cohort();
        ThirtyFive.name = 35;

        Cohort TwentyThree = new Cohort();
        TwentyThree.name = 24;

//Adding Student

        Student Michael = new Student();
        Michael.firstName = "Michael";
        Michael.lastName = "Stiles";
        Michael.slackHandle = "mstiles01";
        Michael.Cohort = 34;

        Student Matt = new Student();
        Michael.firstName = "Matt";
        Michael.lastName = "Ross";
        Michael.slackHandle = "mross";
        Michael.Cohort = 34;

        Student Noah = new Student();
        Michael.firstName = "Noah";
        Michael.lastName = "Barfeild";
        Michael.slackHandle = "noahb";
        Michael.Cohort = 35;

        Student Maggie = new Student();
        Michael.firstName = "Maggie";
        Michael.lastName = "Johnson";
        Michael.slackHandle = "mjohn";
        Michael.Cohort = 24;

        }





    }
}
