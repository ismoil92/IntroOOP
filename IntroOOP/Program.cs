using IntroOOP.Task1;

Task1();

static void Task1()
{
    ICoder acoder = new ACoder();
    ICoder bcoder = new BCoder();

    string text = "Hello World";
    string encoder = acoder.Encode(text);
    Console.WriteLine($"Класс ACoder Шифрований строка:{encoder}");
    string decoder = acoder.Decode(encoder);
    Console.WriteLine($"Класс ACoder Дешифрований строка:{decoder}");
    Console.WriteLine();
    string encoderB = bcoder.Encode("Hello");
    Console.WriteLine($"Класс BCoder Шифрованный строка:{encoderB}");
    string decoderB = bcoder.Decode(encoderB);
    Console.WriteLine($"Класс BCoder Дешифрованный строка:{decoderB}");
}