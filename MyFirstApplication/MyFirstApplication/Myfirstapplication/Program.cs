using Myfirstapplication;
using Myfirstapplication.Lessons;

// The Below Statement calls a local function
HouseExample();

/*
multi line comment.
 */

void HouseExample()
{
House myHouse = new House();
myHouse.DoorOpenClose();
}

/* This local function is 
 * for my first exercise lab
 */

MyLocalFunction();

void MyLocalFunction()
{
    Console.WriteLine("This is my first sentence.");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is c0ol.");
    Console.WriteLine("I am learning stuff everyday.");
}

void Lesson1Example()
{
    lesson1 myLesson = new lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongfromInt();


}


