using LinqIntroOefening.Classes;
using LinqIntroOefening.Enum;

List<Course> courses = new List<Course>()
{
    new Course() {Duration = 10, Period = EnumPeriod.Evening, Room = "F30", StudentCount = 10, Teacher = "Arne"},
    new Course() {Duration = 10, Period = EnumPeriod.Day, Room = "F30", StudentCount = 20, Teacher = "Tom"},
    new Course() {Duration = 10, Period = EnumPeriod.Day, Room = "F30", StudentCount = 10, Teacher = "Arne"},
    new Course() {Duration = 10, Period = EnumPeriod.Day, Room = "F30", StudentCount = 20, Teacher = "Tom"},
    new Course() {Duration = 10, Period = EnumPeriod.Evening, Room = "F30", StudentCount = 10, Teacher = "Arne"},
    new Course() {Duration = 10, Period = EnumPeriod.Day, Room = "F30", StudentCount = 120, Teacher = "Arne"},
    new Course() {Duration = 10, Period = EnumPeriod.Day, Room = "F30", StudentCount = 10, Teacher = "Arne"},
    new Course() {Duration = 10, Period = EnumPeriod.Day, Room = "F30", StudentCount = 20, Teacher = "Tom"},
    new Course() {Duration = 10, Period = EnumPeriod.Evening, Room = "F30", StudentCount = 10, Teacher = "Arne"},
    new Course() {Duration = 10, Period = EnumPeriod.Day, Room = "F30", StudentCount = 10, Teacher = "Arne"}
};

//Alle cursussen met minimaal 15 studenten
var courseFiltered = from course in courses 
                     where course.StudentCount >= 15 
                     select course;

var courseFiltered2 = courses.Where(course => course.StudentCount >= 15);

//Alle cursussen die overdag plaatsvinden
var courseFiltered3 = from course in courses
                      where course.Period == EnumPeriod.Day
                      select course;

var courseFiltered4 = courses.Where(course => course.Period == EnumPeriod.Day);

//Toon het aantal cursussen per docent (groupering)
var courseGrouped1 = from course in courses
                     group course by course.Teacher into courseGroup
                     select courseGroup.Key + ": " + courseGroup.Count();

foreach(var course in courseGrouped1)
{
    Console.WriteLine(course);
}