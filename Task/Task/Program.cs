

using Task.Controllers;
using Task.Helpers.Extensions;



////1) 2 eded extension method yazirsiz. Biri emailin icinde @ isaresinin olub olmamasini yoxlamalidir.
////Digeri passwordun uzunluqunun 8den boyuk olub olmadigini yoxlamalidir.


////Email:

//string email = "ismayil123@gmail.com";

//Console.WriteLine(email.CheckEmail('a'));

////Password:

//string password = "ismayil123";

//Console.WriteLine(password.CheckPassword());



////3) Int arrayi ucun extention method yazirsiz. Hemin extention method arrayin elementlerinin hasilini tapsin.

//int[] numbers = { 1, 2, 3, 4 };

//Console.WriteLine(numbers.MultipleOfArrayElements());


////4) CalculatorService adinda class yaradirsiz, hemin classin icinde Calculation metodunuz olur. 
////Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan calculator olacaq. 
////Reqemler ve operatorlar console-dan daxil edilmelidir.Uygun controller de olsun.

CalculatorController calculatorController = new CalculatorController();

calculatorController.Calculator();


