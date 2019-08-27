# Welcome!

link: https://www.codewars.com/kata/577ff15ad648a14b780000e7

Your start-up's BA has told marketing that your website has a large audience in Scandinavia and surrounding countries. Marketing thinks it would be great to welcome visitors to the site in their own language. Luckily you already use an API that detects the user's location, so this is an easy win.

The Task
Think of a way to store the languages as a database (eg an object). The languages are listed below so you can copy and paste!
Write a 'welcome' function that takes a parameter 'language' (always a string), and returns a greeting - if you have it in your database. It should default to English if the language is not in the database, or in the event of an invalid input.
```
public static class Kata
    {
        public static string Greet(string language)
        {
            switch(language){
            case "english": return "Welcome";
            case "czech": return "Vitejte";
            case "danish": return "Velkomst";
            case "dutch": return "Welkom";
            case "estonian": return "Tere tulemast";
            case "finnish": return "Tervetuloa";
            case "flemish": return "Welgekomen";
            case "french": return "Bienvenue";
            case "german": return "Willkommen";
            case "irish": return "Failte";
            case "italian": return "Benvenuto";
            case "latvian": return "Gaidits";
            case "lithuanian": return "Laukiamas";
            case "polish": return "Witamy";
            case "spanish": return "Bienvenido";
            case "swedish": return "Valkommen";
            case "welsh": return "Croeso";
            default: return  "Welcome";
            }
        }
    }
