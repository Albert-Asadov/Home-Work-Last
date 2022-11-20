

#region First Task

//string str = "bU tAsKi eLiYeNe qEdEr cAnIm cIxDi";

//string lower = str.ToLower();

//string[] array = lower.Split();

//string word = string.Empty;



//foreach (string item in array)

//{
//    string firstRemove = item.Remove(0, 1);

//    string secondRemove = item.Remove(1);

//    string toUpper = secondRemove.ToUpper();

//    string replace = item.Replace(secondRemove, toUpper);

//    string final = toUpper + firstRemove;

//    word += final + " ";

//}
//Console.WriteLine(word);
#endregion






#region Second Task

using My_Home_Task;

Student_Information information = new Student_Information("Albert", "Asadov", "P230", 85, true);

Console.WriteLine(information.getNameSurname());
Console.WriteLine(information.allInformation());
Console.WriteLine(information.canAttendToNextExam()); 
#endregion
